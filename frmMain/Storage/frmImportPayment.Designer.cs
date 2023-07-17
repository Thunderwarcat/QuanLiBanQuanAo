namespace frmMain.Storage
{
    partial class frmImportPayment
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
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnpaidAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewDept = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(227, 187);
            this.txtTotalBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(148, 26);
            this.txtTotalBill.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số tiền cần thanh toán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thanh toán:";
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(227, 243);
            this.txtPayAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(148, 26);
            this.txtPayAmount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Còn nợ: ";
            // 
            // txtUnpaidAmount
            // 
            this.txtUnpaidAmount.Location = new System.Drawing.Point(227, 299);
            this.txtUnpaidAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnpaidAmount.Name = "txtUnpaidAmount";
            this.txtUnpaidAmount.Size = new System.Drawing.Size(148, 26);
            this.txtUnpaidAmount.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Công nợ trước đây:";
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(227, 73);
            this.txtDept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDept.Name = "txtDept";
            this.txtDept.ReadOnly = true;
            this.txtDept.Size = new System.Drawing.Size(148, 26);
            this.txtDept.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // txtSupCode
            // 
            this.txtSupCode.Location = new System.Drawing.Point(227, 17);
            this.txtSupCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupCode.Name = "txtSupCode";
            this.txtSupCode.ReadOnly = true;
            this.txtSupCode.Size = new System.Drawing.Size(148, 26);
            this.txtSupCode.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phương thức thanh toán:";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Quẹt thẻ",
            "Khác"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(227, 129);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(148, 28);
            this.cbPaymentMethod.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Tạo phiếu nhập";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 27);
            this.button2.TabIndex = 14;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Công nợ mới:";
            // 
            // txtNewDept
            // 
            this.txtNewDept.Location = new System.Drawing.Point(227, 355);
            this.txtNewDept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewDept.Name = "txtNewDept";
            this.txtNewDept.Size = new System.Drawing.Size(148, 26);
            this.txtNewDept.TabIndex = 15;
            // 
            // frmImportPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 430);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNewDept);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbPaymentMethod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSupCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUnpaidAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPayAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalBill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmImportPayment";
            this.Text = "Thông tin thanh toán";
            this.Load += new System.EventHandler(this.frmImportPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnpaidAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSupCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewDept;
    }
}