namespace POS_.PRE.PURCHASE
{
    partial class PURCHASE
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
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.vattxt = new System.Windows.Forms.TextBox();
            this.sub_toteltxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_loading = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.additional_chargetxt = new System.Windows.Forms.TextBox();
            this.invoice_net_toteltxt = new System.Windows.Forms.TextBox();
            this.discounttxt = new System.Windows.Forms.TextBox();
            this.discount_percentagetxt = new System.Windows.Forms.TextBox();
            this.toteltxt = new System.Windows.Forms.TextBox();
            this.profittxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.additm_btn = new System.Windows.Forms.Button();
            this.supplier_idtxt = new System.Windows.Forms.ComboBox();
            this.invoice_idtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_save.Location = new System.Drawing.Point(49, 191);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(133, 24);
            this.btn_save.TabIndex = 89;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(2, 337);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(883, 347);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
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
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Unit Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Profit %";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Profit";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Line Totel";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "VAT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = " Sub Totel :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Discount % : ";
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
            this.btn_exit.Location = new System.Drawing.Point(225, 191);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(142, 24);
            this.btn_exit.TabIndex = 91;
            this.btn_exit.Text = "Exit ";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // vattxt
            // 
            this.vattxt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.vattxt.Location = new System.Drawing.Point(584, 69);
            this.vattxt.Name = "vattxt";
            this.vattxt.Size = new System.Drawing.Size(260, 28);
            this.vattxt.TabIndex = 45;
            this.vattxt.TextChanged += new System.EventHandler(this.vattxt_TextChanged);
            // 
            // sub_toteltxt
            // 
            this.sub_toteltxt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.sub_toteltxt.Location = new System.Drawing.Point(584, 35);
            this.sub_toteltxt.Name = "sub_toteltxt";
            this.sub_toteltxt.ReadOnly = true;
            this.sub_toteltxt.Size = new System.Drawing.Size(260, 28);
            this.sub_toteltxt.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Totel :";
            // 
            // pb_loading
            // 
            this.pb_loading.Location = new System.Drawing.Point(19, 224);
            this.pb_loading.Margin = new System.Windows.Forms.Padding(2);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(398, 10);
            this.pb_loading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pb_loading.TabIndex = 197;
            this.pb_loading.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Addditional Charge :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pb_loading);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.additional_chargetxt);
            this.groupBox1.Controls.Add(this.invoice_net_toteltxt);
            this.groupBox1.Controls.Add(this.vattxt);
            this.groupBox1.Controls.Add(this.sub_toteltxt);
            this.groupBox1.Controls.Add(this.discounttxt);
            this.groupBox1.Controls.Add(this.discount_percentagetxt);
            this.groupBox1.Controls.Add(this.toteltxt);
            this.groupBox1.Controls.Add(this.profittxt);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Location = new System.Drawing.Point(6, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 242);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NEW PURCHASE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(428, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Invoice Net Total : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Discount : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Profit : ";
            // 
            // additional_chargetxt
            // 
            this.additional_chargetxt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.additional_chargetxt.Location = new System.Drawing.Point(584, 103);
            this.additional_chargetxt.Name = "additional_chargetxt";
            this.additional_chargetxt.Size = new System.Drawing.Size(260, 28);
            this.additional_chargetxt.TabIndex = 45;
            this.additional_chargetxt.TextChanged += new System.EventHandler(this.additional_chargetxt_TextChanged);
            // 
            // invoice_net_toteltxt
            // 
            this.invoice_net_toteltxt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.invoice_net_toteltxt.Location = new System.Drawing.Point(584, 137);
            this.invoice_net_toteltxt.Name = "invoice_net_toteltxt";
            this.invoice_net_toteltxt.ReadOnly = true;
            this.invoice_net_toteltxt.Size = new System.Drawing.Size(260, 28);
            this.invoice_net_toteltxt.TabIndex = 45;
            // 
            // discounttxt
            // 
            this.discounttxt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.discounttxt.Location = new System.Drawing.Point(114, 137);
            this.discounttxt.Name = "discounttxt";
            this.discounttxt.Size = new System.Drawing.Size(260, 28);
            this.discounttxt.TabIndex = 45;
            this.discounttxt.TextChanged += new System.EventHandler(this.discounttxt_TextChanged);
            // 
            // discount_percentagetxt
            // 
            this.discount_percentagetxt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.discount_percentagetxt.Location = new System.Drawing.Point(114, 103);
            this.discount_percentagetxt.Name = "discount_percentagetxt";
            this.discount_percentagetxt.Size = new System.Drawing.Size(260, 28);
            this.discount_percentagetxt.TabIndex = 45;
            this.discount_percentagetxt.TextChanged += new System.EventHandler(this.discount_percentagetxt_TextChanged);
            // 
            // toteltxt
            // 
            this.toteltxt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.toteltxt.Location = new System.Drawing.Point(114, 35);
            this.toteltxt.Name = "toteltxt";
            this.toteltxt.ReadOnly = true;
            this.toteltxt.Size = new System.Drawing.Size(260, 28);
            this.toteltxt.TabIndex = 45;
            this.toteltxt.TextChanged += new System.EventHandler(this.toteltxt_TextChanged);
            // 
            // profittxt
            // 
            this.profittxt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.profittxt.Location = new System.Drawing.Point(114, 69);
            this.profittxt.Name = "profittxt";
            this.profittxt.ReadOnly = true;
            this.profittxt.Size = new System.Drawing.Size(260, 28);
            this.profittxt.TabIndex = 45;
            this.profittxt.TextChanged += new System.EventHandler(this.profittxt_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.additm_btn);
            this.groupBox2.Controls.Add(this.supplier_idtxt);
            this.groupBox2.Controls.Add(this.invoice_idtxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(6, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 84);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADD ITEM";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // additm_btn
            // 
            this.additm_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.additm_btn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.additm_btn.FlatAppearance.BorderSize = 0;
            this.additm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.additm_btn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additm_btn.ForeColor = System.Drawing.Color.White;
            this.additm_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.additm_btn.Location = new System.Drawing.Point(379, 37);
            this.additm_btn.Margin = new System.Windows.Forms.Padding(2);
            this.additm_btn.Name = "additm_btn";
            this.additm_btn.Size = new System.Drawing.Size(101, 24);
            this.additm_btn.TabIndex = 198;
            this.additm_btn.Text = "+ ADD ITEM";
            this.additm_btn.UseVisualStyleBackColor = false;
            this.additm_btn.Click += new System.EventHandler(this.additm_btn_Click);
            // 
            // supplier_idtxt
            // 
            this.supplier_idtxt.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_idtxt.FormattingEnabled = true;
            this.supplier_idtxt.Location = new System.Drawing.Point(584, 35);
            this.supplier_idtxt.Name = "supplier_idtxt";
            this.supplier_idtxt.Size = new System.Drawing.Size(260, 26);
            this.supplier_idtxt.TabIndex = 198;
            this.supplier_idtxt.SelectedIndexChanged += new System.EventHandler(this.supplier_idtxt_SelectedIndexChanged);
            // 
            // invoice_idtxt
            // 
            this.invoice_idtxt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.invoice_idtxt.Location = new System.Drawing.Point(114, 35);
            this.invoice_idtxt.Name = "invoice_idtxt";
            this.invoice_idtxt.Size = new System.Drawing.Size(260, 28);
            this.invoice_idtxt.TabIndex = 45;
            this.invoice_idtxt.TextChanged += new System.EventHandler(this.invoice_idtxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(500, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Supplier : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Invoice Num : ";
            // 
            // idtxt
            // 
            this.idtxt.AutoSize = true;
            this.idtxt.Location = new System.Drawing.Point(22, 33);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(13, 13);
            this.idtxt.TabIndex = 199;
            this.idtxt.Text = "0";
            // 
            // PURCHASE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 659);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.idtxt);
            this.Name = "PURCHASE";
            this.Text = "PURCHASE";
            this.Load += new System.EventHandler(this.PURCHASE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox vattxt;
        private System.Windows.Forms.TextBox sub_toteltxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pb_loading;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox discount_percentagetxt;
        private System.Windows.Forms.TextBox profittxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox additional_chargetxt;
        private System.Windows.Forms.TextBox invoice_net_toteltxt;
        private System.Windows.Forms.TextBox discounttxt;
        private System.Windows.Forms.TextBox toteltxt;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox supplier_idtxt;
        public System.Windows.Forms.TextBox invoice_idtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label idtxt;
        private System.Windows.Forms.Button additm_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}