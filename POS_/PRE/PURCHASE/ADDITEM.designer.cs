
namespace POS_.PRE.PURCHASE
{
    partial class ADDITEM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_itemname = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_linetotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_profit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpropercent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_unitprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shiftidtxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_itemname);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_linetotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_profit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtpropercent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_total);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_unitprice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Item ---- ";
            // 
            // cmb_itemname
            // 
            this.cmb_itemname.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmb_itemname.FormattingEnabled = true;
            this.cmb_itemname.Location = new System.Drawing.Point(154, 11);
            this.cmb_itemname.Name = "cmb_itemname";
            this.cmb_itemname.Size = new System.Drawing.Size(349, 29);
            this.cmb_itemname.TabIndex = 89;
            this.cmb_itemname.SelectedIndexChanged += new System.EventHandler(this.cmb_itemname_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(217, 372);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 27);
            this.btn_save.TabIndex = 86;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(411, 372);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(91, 27);
            this.btn_close.TabIndex = 85;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(314, 372);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(91, 27);
            this.btn_reset.TabIndex = 84;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(5, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 83;
            this.label6.Text = "Line Total";
            // 
            // txt_linetotal
            // 
            this.txt_linetotal.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_linetotal.Location = new System.Drawing.Point(154, 327);
            this.txt_linetotal.Name = "txt_linetotal";
            this.txt_linetotal.ReadOnly = true;
            this.txt_linetotal.Size = new System.Drawing.Size(349, 28);
            this.txt_linetotal.TabIndex = 82;
            this.txt_linetotal.TextChanged += new System.EventHandler(this.txt_linetotal_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(7, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 22);
            this.label7.TabIndex = 81;
            this.label7.Text = "Profit";
            // 
            // txt_profit
            // 
            this.txt_profit.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_profit.Location = new System.Drawing.Point(154, 274);
            this.txt_profit.Name = "txt_profit";
            this.txt_profit.ReadOnly = true;
            this.txt_profit.Size = new System.Drawing.Size(349, 28);
            this.txt_profit.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(5, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 22);
            this.label5.TabIndex = 79;
            this.label5.Text = "Profit Percentage";
            // 
            // txtpropercent
            // 
            this.txtpropercent.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtpropercent.Location = new System.Drawing.Point(154, 228);
            this.txtpropercent.Name = "txtpropercent";
            this.txtpropercent.Size = new System.Drawing.Size(349, 28);
            this.txtpropercent.TabIndex = 78;
            this.txtpropercent.TextChanged += new System.EventHandler(this.txtpropercent_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 77;
            this.label4.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_total.Location = new System.Drawing.Point(154, 175);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(349, 28);
            this.txt_total.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 75;
            this.label3.Text = "Quantity";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_quantity.Location = new System.Drawing.Point(154, 120);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(349, 28);
            this.txt_quantity.TabIndex = 74;
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 73;
            this.label2.Text = "Unite Price";
            // 
            // txt_unitprice
            // 
            this.txt_unitprice.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_unitprice.Location = new System.Drawing.Point(154, 66);
            this.txt_unitprice.Name = "txt_unitprice";
            this.txt_unitprice.Size = new System.Drawing.Size(349, 28);
            this.txt_unitprice.TabIndex = 72;
            this.txt_unitprice.TextChanged += new System.EventHandler(this.txt_unitprice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 71;
            this.label1.Text = "Item Name";
            // 
            // shiftidtxt
            // 
            this.shiftidtxt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.shiftidtxt.Location = new System.Drawing.Point(98, 445);
            this.shiftidtxt.Name = "shiftidtxt";
            this.shiftidtxt.Size = new System.Drawing.Size(55, 28);
            this.shiftidtxt.TabIndex = 91;
            this.shiftidtxt.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(159, 445);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 28);
            this.textBox1.TabIndex = 90;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.idtxt_TextChanged);
            // 
            // idtxt
            // 
            this.idtxt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.idtxt.Location = new System.Drawing.Point(37, 445);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(55, 28);
            this.idtxt.TabIndex = 90;
            this.idtxt.Visible = false;
            this.idtxt.TextChanged += new System.EventHandler(this.idtxt_TextChanged);
            // 
            // ADDITEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 445);
            this.Controls.Add(this.shiftidtxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.textBox1);
            this.Name = "ADDITEM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ADDITEM_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_itemname;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_linetotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_profit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpropercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_unitprice;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox shiftidtxt;
        public System.Windows.Forms.TextBox textBox1;
    }
}