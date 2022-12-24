namespace POS_.PRE.PURCHASE
{
    partial class PURCHASE_SUMMARY
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PURCHASE = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.notetxt = new System.Windows.Forms.TextBox();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.invoice_idtxt = new System.Windows.Forms.TextBox();
            this.collection_datetxt = new System.Windows.Forms.DateTimePicker();
            this.cheque_datetxt = new System.Windows.Forms.DateTimePicker();
            this.banktxt = new System.Windows.Forms.ComboBox();
            this.payment_methodtxt = new System.Windows.Forms.ComboBox();
            this.pb_loading = new System.Windows.Forms.ProgressBar();
            this.cheque_notxt = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.Label();
            this.chek = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank = new System.Windows.Forms.Label();
            this.PURCHASE.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier : Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Invoice Net Total : Rs. 14,175.20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(204, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Due Payment : Rs. 14,175.20";
            // 
            // PURCHASE
            // 
            this.PURCHASE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PURCHASE.Controls.Add(this.label3);
            this.PURCHASE.Controls.Add(this.label1);
            this.PURCHASE.Controls.Add(this.label2);
            this.PURCHASE.Location = new System.Drawing.Point(0, 5);
            this.PURCHASE.Name = "PURCHASE";
            this.PURCHASE.Size = new System.Drawing.Size(851, 147);
            this.PURCHASE.TabIndex = 1;
            this.PURCHASE.TabStop = false;
            this.PURCHASE.Text = "PURCHASE SUMMERY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Paid Amount :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(429, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Note :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Payment Method :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Collection Date :";
            // 
            // notetxt
            // 
            this.notetxt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.notetxt.Location = new System.Drawing.Point(505, 27);
            this.notetxt.Name = "notetxt";
            this.notetxt.Size = new System.Drawing.Size(255, 28);
            this.notetxt.TabIndex = 51;
            this.notetxt.TextChanged += new System.EventHandler(this.notetxt_TextChanged);
            // 
            // amounttxt
            // 
            this.amounttxt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.amounttxt.Location = new System.Drawing.Point(147, 27);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(260, 28);
            this.amounttxt.TabIndex = 53;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.invoice_idtxt);
            this.groupBox1.Controls.Add(this.collection_datetxt);
            this.groupBox1.Controls.Add(this.cheque_datetxt);
            this.groupBox1.Controls.Add(this.banktxt);
            this.groupBox1.Controls.Add(this.payment_methodtxt);
            this.groupBox1.Controls.Add(this.pb_loading);
            this.groupBox1.Controls.Add(this.cheque_notxt);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.amounttxt);
            this.groupBox1.Controls.Add(this.chek);
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.notetxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(0, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 198);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // invoice_idtxt
            // 
            this.invoice_idtxt.Location = new System.Drawing.Point(505, 93);
            this.invoice_idtxt.Name = "invoice_idtxt";
            this.invoice_idtxt.ReadOnly = true;
            this.invoice_idtxt.Size = new System.Drawing.Size(255, 20);
            this.invoice_idtxt.TabIndex = 204;
            this.invoice_idtxt.TextChanged += new System.EventHandler(this.idtxt_TextChanged);
            // 
            // collection_datetxt
            // 
            this.collection_datetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collection_datetxt.Location = new System.Drawing.Point(147, 64);
            this.collection_datetxt.Name = "collection_datetxt";
            this.collection_datetxt.Size = new System.Drawing.Size(260, 22);
            this.collection_datetxt.TabIndex = 203;
            // 
            // cheque_datetxt
            // 
            this.cheque_datetxt.Enabled = false;
            this.cheque_datetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheque_datetxt.Location = new System.Drawing.Point(147, 163);
            this.cheque_datetxt.Name = "cheque_datetxt";
            this.cheque_datetxt.Size = new System.Drawing.Size(260, 22);
            this.cheque_datetxt.TabIndex = 203;
            // 
            // banktxt
            // 
            this.banktxt.Enabled = false;
            this.banktxt.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banktxt.FormattingEnabled = true;
            this.banktxt.Location = new System.Drawing.Point(505, 61);
            this.banktxt.Name = "banktxt";
            this.banktxt.Size = new System.Drawing.Size(255, 26);
            this.banktxt.TabIndex = 202;
            // 
            // payment_methodtxt
            // 
            this.payment_methodtxt.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_methodtxt.FormattingEnabled = true;
            this.payment_methodtxt.Location = new System.Drawing.Point(147, 96);
            this.payment_methodtxt.Name = "payment_methodtxt";
            this.payment_methodtxt.Size = new System.Drawing.Size(260, 26);
            this.payment_methodtxt.TabIndex = 202;
            this.payment_methodtxt.SelectedIndexChanged += new System.EventHandler(this.payment_methodtxt_SelectedIndexChanged);
            // 
            // pb_loading
            // 
            this.pb_loading.Location = new System.Drawing.Point(433, 166);
            this.pb_loading.Margin = new System.Windows.Forms.Padding(2);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(310, 10);
            this.pb_loading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pb_loading.TabIndex = 201;
            this.pb_loading.Visible = false;
            // 
            // cheque_notxt
            // 
            this.cheque_notxt.Enabled = false;
            this.cheque_notxt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.cheque_notxt.Location = new System.Drawing.Point(147, 128);
            this.cheque_notxt.Name = "cheque_notxt";
            this.cheque_notxt.Size = new System.Drawing.Size(260, 28);
            this.cheque_notxt.TabIndex = 53;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(10, 165);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(104, 20);
            this.date.TabIndex = 58;
            this.date.Text = "Cheque Date :";
            // 
            // chek
            // 
            this.chek.AutoSize = true;
            this.chek.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chek.Location = new System.Drawing.Point(10, 131);
            this.chek.Name = "chek";
            this.chek.Size = new System.Drawing.Size(93, 20);
            this.chek.TabIndex = 58;
            this.chek.Text = "Cheque No :";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(656, 135);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 24);
            this.btn_exit.TabIndex = 200;
            this.btn_exit.Text = "Exit ";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(549, 135);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 24);
            this.btn_delete.TabIndex = 199;
            this.btn_delete.Text = "Delete ";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(432, 135);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 24);
            this.btn_save.TabIndex = 198;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Bank :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(0, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(851, 269);
            this.dataGridView1.TabIndex = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Invoice No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Collection Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Pay Method";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cheque no";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cheque Date";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Bank";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Note";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // bank
            // 
            this.bank.Location = new System.Drawing.Point(0, 0);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(100, 23);
            this.bank.TabIndex = 0;
            // 
            // PURCHASE_SUMMARY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 628);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PURCHASE);
            this.Name = "PURCHASE_SUMMARY";
            this.Text = "PURCHASE_SUMMARY";
            this.Load += new System.EventHandler(this.PURCHASE_SUMMARY_Load);
            this.PURCHASE.ResumeLayout(false);
            this.PURCHASE.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox PURCHASE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox notetxt;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pb_loading;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker cheque_datetxt;
        private System.Windows.Forms.ComboBox banktxt;
        private System.Windows.Forms.ComboBox payment_methodtxt;
        private System.Windows.Forms.TextBox cheque_notxt;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label chek;
        private System.Windows.Forms.Label bank;
        public System.Windows.Forms.TextBox invoice_idtxt;
        private System.Windows.Forms.DateTimePicker collection_datetxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}