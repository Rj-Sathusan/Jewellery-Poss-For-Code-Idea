namespace POS_.PRE.Customer
{
    partial class frmRoutAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lausername = new System.Windows.Forms.Label();
            this.lauser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_loading = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lacatergory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labank = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnewaccountno = new System.Windows.Forms.Button();
            this.txtrotid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(429, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 18);
            this.label16.TabIndex = 195;
            this.label16.Text = "User ID :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(382, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 18);
            this.label13.TabIndex = 194;
            this.label13.Text = "Username :";
            // 
            // lausername
            // 
            this.lausername.AutoSize = true;
            this.lausername.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lausername.ForeColor = System.Drawing.SystemColors.Control;
            this.lausername.Location = new System.Drawing.Point(382, 65);
            this.lausername.Name = "lausername";
            this.lausername.Size = new System.Drawing.Size(67, 18);
            this.lausername.TabIndex = 193;
            this.lausername.Text = "username";
            // 
            // lauser
            // 
            this.lauser.AutoSize = true;
            this.lauser.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lauser.ForeColor = System.Drawing.SystemColors.Control;
            this.lauser.Location = new System.Drawing.Point(234, 11);
            this.lauser.Name = "lauser";
            this.lauser.Size = new System.Drawing.Size(45, 18);
            this.lauser.TabIndex = 192;
            this.lauser.Text = "lauser";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pb_loading);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.lacatergory);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lausername);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lauser);
            this.panel2.Controls.Add(this.txtto);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.labank);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnewaccountno);
            this.panel2.Controls.Add(this.txtrotid);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtfrom);
            this.panel2.Location = new System.Drawing.Point(2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 491);
            this.panel2.TabIndex = 189;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pb_loading
            // 
            this.pb_loading.Location = new System.Drawing.Point(6, 153);
            this.pb_loading.Margin = new System.Windows.Forms.Padding(2);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(274, 10);
            this.pb_loading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pb_loading.TabIndex = 196;
            this.pb_loading.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ampara",
            "Anuradhapura",
            "Badulla",
            "Batticaloa",
            "Colombo",
            "Kandy",
            "Nuwara Eliya",
            "Galle",
            "Trincomalee",
            "Jaffna",
            "Ratnapura",
            "Matale",
            "Puttalam",
            "Kalutara",
            "Polonnaruwa",
            "Vavuniya",
            "Matara",
            "Mannar",
            "Monaragala",
            "Hambantota",
            "Kurunagala",
            "Mullaitivu",
            "Kilinochchi",
            "Gampaha",
            "Kegalle"});
            this.comboBox1.Location = new System.Drawing.Point(106, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 26);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // lacatergory
            // 
            this.lacatergory.AutoSize = true;
            this.lacatergory.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lacatergory.ForeColor = System.Drawing.Color.Black;
            this.lacatergory.Location = new System.Drawing.Point(3, 93);
            this.lacatergory.Name = "lacatergory";
            this.lacatergory.Size = new System.Drawing.Size(90, 18);
            this.lacatergory.TabIndex = 181;
            this.lacatergory.Text = "Select District";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 179;
            this.label1.Text = "To Route";
            // 
            // txtto
            // 
            this.txtto.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtto.Location = new System.Drawing.Point(106, 63);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(250, 25);
            this.txtto.TabIndex = 2;
            this.txtto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtto_KeyDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(98, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Enter += new System.EventHandler(this.button2_Enter);
            this.button2.Leave += new System.EventHandler(this.button2_Leave);
            // 
            // labank
            // 
            this.labank.AutoSize = true;
            this.labank.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labank.ForeColor = System.Drawing.Color.Black;
            this.labank.Location = new System.Drawing.Point(3, 13);
            this.labank.Name = "labank";
            this.labank.Size = new System.Drawing.Size(58, 18);
            this.labank.TabIndex = 177;
            this.labank.Text = "Route Id";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(187, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Enter += new System.EventHandler(this.button1_Enter);
            this.button1.Leave += new System.EventHandler(this.button1_Leave);
            // 
            // btnewaccountno
            // 
            this.btnewaccountno.BackColor = System.Drawing.SystemColors.Control;
            this.btnewaccountno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnewaccountno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnewaccountno.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnewaccountno.ForeColor = System.Drawing.Color.Black;
            this.btnewaccountno.Location = new System.Drawing.Point(6, 122);
            this.btnewaccountno.Name = "btnewaccountno";
            this.btnewaccountno.Size = new System.Drawing.Size(91, 26);
            this.btnewaccountno.TabIndex = 4;
            this.btnewaccountno.Text = "Save";
            this.btnewaccountno.UseVisualStyleBackColor = false;
            this.btnewaccountno.Click += new System.EventHandler(this.btnewaccountno_Click);
            this.btnewaccountno.Enter += new System.EventHandler(this.btnewaccountno_Enter);
            this.btnewaccountno.Leave += new System.EventHandler(this.btnewaccountno_Leave);
            // 
            // txtrotid
            // 
            this.txtrotid.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrotid.Location = new System.Drawing.Point(106, 9);
            this.txtrotid.Name = "txtrotid";
            this.txtrotid.ReadOnly = true;
            this.txtrotid.Size = new System.Drawing.Size(105, 25);
            this.txtrotid.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "From Route";
            // 
            // txtfrom
            // 
            this.txtfrom.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfrom.Location = new System.Drawing.Point(106, 36);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(250, 25);
            this.txtfrom.TabIndex = 1;
            this.txtfrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfrom_KeyDown);
            // 
            // frmRoutAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(948, 496);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRoutAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Route Add";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRoutAdd_FormClosing);
            this.Load += new System.EventHandler(this.frmRoutAdd_Load);
            this.Shown += new System.EventHandler(this.frmRoutAdd_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lausername;
        private System.Windows.Forms.Label lauser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labank;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnewaccountno;
        private System.Windows.Forms.TextBox txtrotid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lacatergory;
        private System.Windows.Forms.ProgressBar pb_loading;
    }
}