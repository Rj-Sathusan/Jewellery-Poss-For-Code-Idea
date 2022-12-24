namespace POS_
{
    partial class frmAdminLogin
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
            this.textpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lacashirid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labranchid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.admin_login_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textpass
            // 
            this.textpass.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpass.Location = new System.Drawing.Point(158, 85);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(404, 28);
            this.textpass.TabIndex = 1;
            this.textpass.UseSystemPasswordChar = true;
            this.textpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textpass_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // textuser
            // 
            this.textuser.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textuser.Location = new System.Drawing.Point(158, 46);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(404, 28);
            this.textuser.TabIndex = 0;
            this.textuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textuser_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 28);
            this.dateTimePicker1.TabIndex = 177;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lacashirid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labranchid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.admin_login_button);
            this.groupBox1.Controls.Add(this.textuser);
            this.groupBox1.Controls.Add(this.textpass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(173, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 172);
            this.groupBox1.TabIndex = 178;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign in";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(169, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 22);
            this.label6.TabIndex = 190;
            this.label6.Text = "Cashier ID : ";
            // 
            // lacashirid
            // 
            this.lacashirid.AutoSize = true;
            this.lacashirid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lacashirid.ForeColor = System.Drawing.Color.Black;
            this.lacashirid.Location = new System.Drawing.Point(273, 133);
            this.lacashirid.Name = "lacashirid";
            this.lacashirid.Size = new System.Drawing.Size(18, 22);
            this.lacashirid.TabIndex = 189;
            this.lacashirid.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 188;
            this.label5.Text = "Branch ID : ";
            // 
            // labranchid
            // 
            this.labranchid.AutoSize = true;
            this.labranchid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labranchid.ForeColor = System.Drawing.Color.Black;
            this.labranchid.Location = new System.Drawing.Point(118, 131);
            this.labranchid.Name = "labranchid";
            this.labranchid.Size = new System.Drawing.Size(18, 22);
            this.labranchid.TabIndex = 187;
            this.labranchid.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(154, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 20);
            this.label3.TabIndex = 179;
            this.label3.Text = "Welcome ! please enter your user name and password below";
            // 
            // admin_login_button
            // 
            this.admin_login_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.admin_login_button.BackgroundImage = global::POS_.Properties.Resources.newbutton;
            this.admin_login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_login_button.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_login_button.ForeColor = System.Drawing.Color.Black;
            this.admin_login_button.Image = global::POS_.Properties.Resources.i;
            this.admin_login_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_login_button.Location = new System.Drawing.Point(415, 122);
            this.admin_login_button.Name = "admin_login_button";
            this.admin_login_button.Size = new System.Drawing.Size(147, 37);
            this.admin_login_button.TabIndex = 2;
            this.admin_login_button.Text = "Login";
            this.admin_login_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_login_button.UseVisualStyleBackColor = false;
            this.admin_login_button.Click += new System.EventHandler(this.admin_login_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_.Properties.Resources.download__4_;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 179;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 175);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdminLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POINT OF SALE >>>> Admin Login";
            this.Load += new System.EventHandler(this.frmAdminLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admin_login_button;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lacashirid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labranchid;

    }
}