  using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using MySql.Data.MySqlClient;

namespace POS_
{
    public class Functions
    {
        public static MySqlConnection connection = new MySqlConnection(Connection.connString);

        public void auto_fill_text_box(TextBox text_box,string sql)
        {
            
            text_box.AutoCompleteMode = AutoCompleteMode.Suggest;
            text_box.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection, sql);
            text_box.AutoCompleteCustomSource = DataCollection;
        }


        public void getData(AutoCompleteStringCollection dataCollection,string sql)
        {
            //string connetionString = null;
            //SqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            // connetionString = @"Data Source=RITHA\RIZWAN;Initial Catalog=atlas_stock_maintainc;Integrated Security=True";
            
            //connection = new SqlConnection(connetionString);
            //MySqlConnection connection = new MySqlConnection(Connection.connString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    


        public string fill_combo_value(string query, ComboBox combobox, string display_member_column_name, string value_member_column_name)
        {
            
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            da.Fill(ds);
            combobox.DataSource = ds.Tables[0].DefaultView;
            combobox.DisplayMember = display_member_column_name;
            combobox.ValueMember = value_member_column_name;
            return combobox.SelectedValue.ToString();
        }


        public string prepareInsertQuery(string table, string[] fields)
        {
            string query = "insert into " + table + " values(";
            for (int i = 0; i < fields.Length; i++) { query += "'" + fields[i] + "',"; }
            string newQuery = query.Remove(query.Length - 1);
            newQuery += ")";
            return newQuery;
        }

        public string prepareUpdateQuery(string table, string[] fields, string[] datas , string[] wheresFields, string[] wheresDatas, bool andCondition)
        {
            string finalQuery = string.Empty;
            string refreshQuery = string.Empty;
            string queryObject1 = "update " + table + " set ";

            for (int i = 0; i < fields.Length; i++)
            {
                queryObject1 += fields[i] + "=";
                queryObject1 += "'" + datas[i] + "'" + ", ";
            }

            string queryObject2 = queryObject1.Remove(queryObject1.Length - 2);
            string queryObject3 = queryObject2 + " where ";

            if (wheresFields.Length == 1) 
            { 
                finalQuery = queryObject3 + wheresFields[0] + "=" + "'" + wheresDatas[0] + "'";
                refreshQuery = finalQuery;
            }
            else 
            {
                switch (andCondition)
                {
                    case true:
                        finalQuery = queryObject3 + wheresFields[0] + "=" + "'" + wheresDatas[0] + "' " + " and ";
                        for (int i = 1; i < wheresFields.Length; i++)
                        {
                            finalQuery += wheresFields[i] + "=" + "'" + wheresDatas[i] + "'" + " and ";
                        }
                        refreshQuery = finalQuery.Remove(finalQuery.Length - 4);
                        break;

                    default :
                        finalQuery = queryObject3 + wheresFields[0] + "=" + "'" + wheresDatas[0] + "' " + " or ";
                        for (int i = 1; i < wheresFields.Length; i++)
                        {
                            finalQuery += wheresFields[i] + "=" + "'" + wheresDatas[i] + "'" + " or ";
                        }
                        refreshQuery = finalQuery.Remove(finalQuery.Length - 3);
                        break;
                }
            }           
            return refreshQuery;
        }

        public void uploadData(string query, string message, bool msg)
        {
            MySqlCommand command = new MySqlCommand(query, connection);

            if (connection.State == ConnectionState.Open) { connection.Close(); }

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            if (msg == true) { Messages.showInformMessages(message); }
        }

        public DataTable dataTable(string query)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

            if (connection.State == ConnectionState.Open) { connection.Close(); }
            connection.Open();
            
            adapter.Fill(table);
            connection.Close();

            return table;
        }

        public void clearText(TextBox[] boxs)
        {
            for (int i = 0; i < boxs.Length; i++) { boxs[i].Text = string.Empty; }
        }

        public List<string> bindRecord(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            List<string> rec = new List<string>();
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++) { rec.Add(reader[i].ToString().Trim()); }
            }
            connection.Close();
            return rec;
        }

        public void browseImage(PictureBox picBox)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files |*.jpg; *.png;";
                DialogResult result = ofd.ShowDialog();
                picBox.Image = Image.FromFile(ofd.FileName);
            }
            catch { }
        }

        //convert image to bytes
        public byte[] picture(PictureBox picBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            picBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = new byte[memoryStream.Length];
            memoryStream.Position = 0;
            memoryStream.Read(pic, 0, pic.Length);
            return pic;
        }


        //send byte to sql
        public void imageToSql(string table, string id, byte[] pic, string task)
        {
            MySqlCommand command;

            if (task == "insert") { command = new MySqlCommand("insert into " + table + "(Id,Photo)values(@id,@pic)", connection); }
            else { command = new MySqlCommand("update " + table + " set Id=@id, Photo=@pic where Id = @id", connection); }

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@pic", pic);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        //convert bytes to image
        public void sqlImage(PictureBox picbox, string query)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                byte[] image = (byte[])reader["Photo"];
                MemoryStream mstream = new MemoryStream(image);
                mstream.Seek(0, SeekOrigin.Begin);
                picbox.Image = Image.FromStream(mstream);
            }

            connection.Close();
        }

        public void fillCombo(ComboBox combo, string query)
        {
            combo.Items.Clear();
            MySqlCommand command = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) { combo.Items.Add(reader[0].ToString().Trim()); }

                connection.Close();
            }
            catch (MySqlException ex) { 
                
               Messages.showWarnMessage("Unable connect to the server !!!");
                //MessageBox.Show(ex.Message);
            }
        }

        public void addDefautImage(PictureBox picBox)
        {
            picBox.Image = Image.FromFile(Application.StartupPath + "\\Image\\photo.jpg");
        }

        public void fillListView(ListView listView, string query)
        {
            listView.Items.Clear();
            DataTable table = dataTable(query);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                listView.Items.Add(new ListViewItem(table.Rows[i].ItemArray.GetValue(0).ToString()));

                for (int x = 1; x < table.Columns.Count; x++)
                {
                    listView.Items[i].SubItems.Add(table.Rows[i].ItemArray.GetValue(x).ToString());
                }
            }
        }

        public void fillGridView(DataGridView dgv, DataTable table)
        {
            dgv.RowCount = table.Rows.Count;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int x = 0; x < dgv.ColumnCount; x++)
                {
                    dgv[x, i].Value = table.Rows[i].ItemArray.GetValue(x).ToString().Trim();
                }
            }
        }


        public void checkString(KeyPressEventArgs e, TextBox txt)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 46 || e.KeyChar == 8)//true or false
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        public void fillGridByColumn(DataGridView dgv, DataTable table, int column)
        {
            if (table.Rows.Count == 0) { Messages.showInformMessages("Data not found !!!"); dgv.RowCount = 0; }
            else
            {
                dgv.RowCount = table.Rows.Count;
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    for (int x = 0; x < column; x++)
                    {
                        dgv[x, i].Value = table.Rows[i].ItemArray.GetValue(x).ToString().Trim();
                    }
                }
            }
            
        }

        public void fillGridSingleColumn(DataGridView dgv, DataTable table, int index)
        {
            if (table.Rows.Count == 0) { Messages.showInformMessages("Data not found !!!"); dgv.RowCount = 0; }
            else
            {
                dgv.RowCount = table.Rows.Count;

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dgv[index, i].Value = table.Rows[i].ItemArray.GetValue(0).ToString();
                }
            }
        }

        public void fillListBox(ListBox lb, DataTable table)
        {
            lb.Items.Clear();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                lb.Items.Add(table.Rows[i].ItemArray.GetValue(0).ToString().Trim());
            }
        }

        public void fillDataGridViewCombo(DataTable table, DataGridView dgv, int columnIndex, string header, bool NA)
        {
            DataGridViewComboBoxColumn colunm = new DataGridViewComboBoxColumn();
            colunm.HeaderText = header;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                colunm.Items.Add(table.Rows[i].ItemArray.GetValue(0).ToString().Trim());
            }
            if (NA == true) { colunm.Items.Add("N/A"); }
            dgv.Columns.Add(colunm);
        }

        public void removeComboBoxItem(ComboBox combo, string key)
        {
            for (int i = 0; i < combo.Items.Count; i++)
            {
                if (key == combo.Items[i].ToString()) { combo.Items.RemoveAt(i); }
            }
        }

        public void addDate(ComboBox combo, int total)
        {
            combo.Items.Clear();
            for (int i = 1; i <= total; i++) { combo.Items.Add(i.ToString()); }
        }

        public void addDateMonthWise(ComboBox combo, string month)
        {
            switch (month)
            {
                case "January":
                    addDate(combo, 31); break;
                case "March":
                    addDate(combo, 31); break;
                case "April":
                    addDate(combo, 30); break;
                case "May":
                    addDate(combo, 31); break;
                case "June":
                    addDate(combo, 30); break;
                case "July":
                    addDate(combo, 31); break;
                case "August":
                    addDate(combo, 31); break;
                case "September":
                    addDate(combo, 30); break;
                case "October":
                    addDate(combo, 31); break;
                case "November":
                    addDate(combo, 30); break;
                case "December":
                    addDate(combo, 31); break;                    
            }
        }

        public string month()
        {
            DateTime datetime = DateTime.Now;
            string fulldate = datetime.ToLongDateString();
            string[] dates = fulldate.Split(' ');
            return dates[1].ToString().Trim();
        }

        public int day() { DateTime dt = DateTime.Now; return dt.Day; }

        public string prepareDate(string year, string month, string day)
        {
            string date = string.Empty;
            switch (month)
            {
                case "January":
                    date = "1/" +day+"/"+year; break;
                case "February":
                    date = "2/" +day+"/"+year; break;
                case "March":
                    date = "3/" +day+"/"+year; break;
                case "April":
                    date = "4/" +day+"/"+year; break;
                case "May":
                    date = "5/" +day+"/"+year; break;
                case "June":
                    date = "6/" +day+"/"+year; break;
                case "July":
                    date = "7/" +day+"/"+year; break;
                case "August":
                    date = "8/" +day+"/"+year; break;
                case "September":
                    date = "9/" +day+"/"+year; break;
                case "October":
                    date = "10/" +day+"/"+year; break;
                case "November":
                    date = "11/" +day+"/"+year; break;
                case "December":
                    date = "13/" +day+"/"+year; break;
            }
            return date;
        }

        public string dateId(string caldate)
        {
            string[] dates = caldate.Split('/');
            string newdate = dates[2] + "-" + dates[0] + "-" + dates[1];
            string query = "select datediff('" + newdate + "','2014-1-1')";
            string date = bindRecord(query)[0];
            return date;
        }


    }
}
