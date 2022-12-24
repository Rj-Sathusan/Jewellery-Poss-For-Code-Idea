using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_.PRE.BANK
{
    public partial class BANK : Form
    {
        private string id;
        private string name;
        private string account_typ;
        private string account_num;

        BUSS.bank bank;

        POS_.function_ fun = new POS_.function_();

        public BANK()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            nametxt.Text = "";
            account_numtxt.Text = "";
            account_typtxt.Text = "";
            idtxt.Text = "";
            btn_save.Text = "Save";
           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    if (fun.ShowMessage("Are You Sure You Want To " + btn_save.Text + "  ?", "Confirm"))
                    {

                        if (string.IsNullOrEmpty(this.idtxt.Text.Trim())) { id = "0"; }

                        this.bank = new BUSS.bank(id, name, account_typ, account_num);

                        if (btn_save.Text == "Save")
                        {
                            this.bank.Savebank();
                            Clear();
                        }

                        else if (btn_save.Text == "Edit")
                        {
                            this.bank.Editbank();
                            Clear();
                        }
                        else { fun.validationMessge("Something Wrong!"); }
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (fun.ShowMessage("Are You Sure You Want To Delete  ?", "Confirm"))
                {

                    if (Validation())
                    {
                       
                        this.bank = new BUSS.bank(id, name, account_typ, account_num);
                        if (this.bank.Deletebank())
                        {

                            Clear();


                        }
                        else
                        {
                            fun.validationMessge("Check your inputs !");

                        }
                    }
                    else
                    { }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /*-------------------------Validation process--------------------------*/

        public bool Validation()
        {
                if (string.IsNullOrEmpty(this.nametxt.Text.Trim()))
                { fun.validationMessge("Please Enter name"); this.nametxt.Focus(); return false; }
                if (string.IsNullOrEmpty(this.account_typtxt.Text.Trim()))
                { fun.validationMessge("Please Enter account_typ"); this.account_typtxt.Focus(); return false; }
                if (string.IsNullOrEmpty(this.account_numtxt.Text.Trim()))
                { fun.validationMessge("Please Enter account_num"); this.account_numtxt.Focus(); return false; }

                else
                {
                    this.id = this.idtxt.Text.Trim();
                    this.name = this.nametxt.Text.Trim();
                    this.account_typ = this.account_typtxt.Text.Trim();
                    this.account_num = this.account_numtxt.Text.Trim();
                }
            
            return true;
        }

        private void account_typtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }
    }
}
