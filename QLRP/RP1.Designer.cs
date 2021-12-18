namespace QLRP
{
    partial class RP1
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
            this.txtMaRap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenRap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.butOk = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.cbbName1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã rạp phim";
            // 
            // txtMaRap
            // 
            this.txtMaRap.Location = new System.Drawing.Point(123, 12);
            this.txtMaRap.Multiline = true;
            this.txtMaRap.Name = "txtMaRap";
            this.txtMaRap.Size = new System.Drawing.Size(254, 31);
            this.txtMaRap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên rạp phim";
            // 
            // txtTenRap
            // 
            this.txtTenRap.Location = new System.Drawing.Point(123, 58);
            this.txtTenRap.Multiline = true;
            this.txtTenRap.Name = "txtTenRap";
            this.txtTenRap.Size = new System.Drawing.Size(254, 34);
            this.txtTenRap.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên nhân viên quản lý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã nhân viên quản lý";
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(123, 194);
            this.txtMa.Multiline = true;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(254, 36);
            this.txtMa.TabIndex = 5;
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(74, 248);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 34);
            this.butOk.TabIndex = 6;
            this.butOk.Text = "OK";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(237, 248);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 34);
            this.butExit.TabIndex = 7;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // cbbName1
            // 
            this.cbbName1.FormattingEnabled = true;
            this.cbbName1.Location = new System.Drawing.Point(123, 158);
            this.cbbName1.Name = "cbbName1";
            this.cbbName1.Size = new System.Drawing.Size(253, 21);
            this.cbbName1.TabIndex = 4;
            this.cbbName1.SelectedIndexChanged += new System.EventHandler(this.cbbName1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(123, 107);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(254, 34);
            this.txtDiaChi.TabIndex = 3;
            // 
            // RP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 294);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbName1);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenRap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaRap);
            this.Controls.Add(this.label1);
            this.Name = "RP1";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaRap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenRap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.ComboBox cbbName1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
    }
}