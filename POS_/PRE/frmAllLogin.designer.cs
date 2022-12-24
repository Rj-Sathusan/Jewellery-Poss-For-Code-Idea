namespace POS_
{
    partial class frmAllLogin
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
            this.admin_button = new System.Windows.Forms.Button();
            this.shift_button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // admin_button
            // 
            this.admin_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.admin_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_button.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_button.ForeColor = System.Drawing.Color.White;
            this.admin_button.Location = new System.Drawing.Point(2, 52);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(376, 47);
            this.admin_button.TabIndex = 3;
            this.admin_button.Text = "Admin Login";
            this.admin_button.UseVisualStyleBackColor = false;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // shift_button
            // 
            this.shift_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shift_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.shift_button.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shift_button.ForeColor = System.Drawing.Color.White;
            this.shift_button.Location = new System.Drawing.Point(2, 2);
            this.shift_button.Name = "shift_button";
            this.shift_button.Size = new System.Drawing.Size(376, 47);
            this.shift_button.TabIndex = 2;
            this.shift_button.Text = "Shift Login";
            this.shift_button.UseVisualStyleBackColor = false;
            this.shift_button.Click += new System.EventHandler(this.shift_button_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // frmAllLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(378, 102);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.shift_button);
            this.Controls.Add(this.admin_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAllLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAllLogin";
            this.Load += new System.EventHandler(this.frmAllLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.Button shift_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}