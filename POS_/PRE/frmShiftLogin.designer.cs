namespace POS_
{
    partial class frmShiftLogin
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
            this.textuser = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtopeningbalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lacashirid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labranchid = new System.Windows.Forms.Label();
            this.shift_login_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lanewinvoiceno = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textuser
            // 
            this.textuser.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textuser.Location = new System.Drawing.Point(139, 37);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(406, 28);
            this.textuser.TabIndex = 0;
            this.textuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textuser_KeyDown);
            // 
            // textpass
            // 
            this.textpass.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpass.Location = new System.Drawing.Point(139, 67);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(406, 28);
            this.textpass.TabIndex = 1;
            this.textpass.UseSystemPasswordChar = true;
            this.textpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textpass_KeyDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 25);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(137, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 20);
            this.label3.TabIndex = 182;
            this.label3.Text = "Welcome ! please enter your user name and password below";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 180;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 181;
            this.label2.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtopeningbalance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lacashirid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labranchid);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.shift_login_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textpass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textuser);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(174, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 159);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign in";
            // 
            // txtopeningbalance
            // 
            this.txtopeningbalance.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtopeningbalance.Location = new System.Drawing.Point(139, 97);
            this.txtopeningbalance.Name = "txtopeningbalance";
            this.txtopeningbalance.Size = new System.Drawing.Size(218, 28);
            this.txtopeningbalance.TabIndex = 187;
            this.txtopeningbalance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtopeningbalance_KeyDown);
            this.txtopeningbalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtopeningbalance_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 188;
            this.label4.Text = "Opening Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(172, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 22);
            this.label6.TabIndex = 186;
            this.label6.Text = "Cashier ID : ";
            // 
            // lacashirid
            // 
            this.lacashirid.AutoSize = true;
            this.lacashirid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lacashirid.ForeColor = System.Drawing.Color.Black;
            this.lacashirid.Location = new System.Drawing.Point(276, 132);
            this.lacashirid.Name = "lacashirid";
            this.lacashirid.Size = new System.Drawing.Size(18, 22);
            this.lacashirid.TabIndex = 185;
            this.lacashirid.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 184;
            this.label5.Text = "Branch ID : ";
            // 
            // labranchid
            // 
            this.labranchid.AutoSize = true;
            this.labranchid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labranchid.ForeColor = System.Drawing.Color.Black;
            this.labranchid.Location = new System.Drawing.Point(121, 130);
            this.labranchid.Name = "labranchid";
            this.labranchid.Size = new System.Drawing.Size(18, 22);
            this.labranchid.TabIndex = 183;
            this.labranchid.Text = "1";
            // 
            // shift_login_button
            // 
            this.shift_login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shift_login_button.BackgroundImage = global::POS_.Properties.Resources.newbutton;
            this.shift_login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shift_login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.shift_login_button.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shift_login_button.ForeColor = System.Drawing.Color.Black;
            this.shift_login_button.Image = global::POS_.Properties.Resources.i;
            this.shift_login_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shift_login_button.Location = new System.Drawing.Point(398, 117);
            this.shift_login_button.Name = "shift_login_button";
            this.shift_login_button.Size = new System.Drawing.Size(147, 37);
            this.shift_login_button.TabIndex = 2;
            this.shift_login_button.Text = "Login";
            this.shift_login_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.shift_login_button.UseVisualStyleBackColor = false;
            this.shift_login_button.Click += new System.EventHandler(this.shift_login_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_.Properties.Resources.cashier;
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lanewinvoiceno
            // 
            this.lanewinvoiceno.AutoSize = true;
            this.lanewinvoiceno.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lanewinvoiceno.ForeColor = System.Drawing.Color.Black;
            this.lanewinvoiceno.Location = new System.Drawing.Point(474, 164);
            this.lanewinvoiceno.Name = "lanewinvoiceno";
            this.lanewinvoiceno.Size = new System.Drawing.Size(18, 22);
            this.lanewinvoiceno.TabIndex = 189;
            this.lanewinvoiceno.Text = "0";
            // 
            // frmShiftLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 164);
            this.Controls.Add(this.lanewinvoiceno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShiftLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POINT OF SALE >>>> Shift Login";
            this.Load += new System.EventHandler(this.frmShiftLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Button shift_login_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lacashirid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labranchid;
        private System.Windows.Forms.TextBox txtopeningbalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lanewinvoiceno;
    }
}