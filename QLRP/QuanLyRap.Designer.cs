namespace QLRP
{
    partial class QuanLyRap
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaRP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenRap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cbbTenNhanVien = new System.Windows.Forms.ComboBox();
            this.butSort = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(368, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(505, 456);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã rạp phim";
            // 
            // txtMaRP
            // 
            this.txtMaRP.Location = new System.Drawing.Point(92, 17);
            this.txtMaRP.Name = "txtMaRP";
            this.txtMaRP.Size = new System.Drawing.Size(204, 20);
            this.txtMaRP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên rạp phim";
            // 
            // txtTenRap
            // 
            this.txtTenRap.Location = new System.Drawing.Point(92, 55);
            this.txtTenRap.Name = "txtTenRap";
            this.txtTenRap.Size = new System.Drawing.Size(204, 20);
            this.txtTenRap.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên nhân viên ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(92, 199);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(204, 20);
            this.txtMaNV.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(92, 94);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(204, 51);
            this.txtDiaChi.TabIndex = 3;
            // 
            // cbbTenNhanVien
            // 
            this.cbbTenNhanVien.FormattingEnabled = true;
            this.cbbTenNhanVien.Location = new System.Drawing.Point(92, 162);
            this.cbbTenNhanVien.Name = "cbbTenNhanVien";
            this.cbbTenNhanVien.Size = new System.Drawing.Size(204, 21);
            this.cbbTenNhanVien.TabIndex = 4;
            this.cbbTenNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbbTenNhanVien_SelectedIndexChanged);
            // 
            // butSort
            // 
            this.butSort.Image = global::QLRP.Properties.Resources.sort_descending_icon;
            this.butSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSort.Location = new System.Drawing.Point(148, 296);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(78, 41);
            this.butSort.TabIndex = 11;
            this.butSort.Text = "Sắp xếp";
            this.butSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butSort.UseVisualStyleBackColor = true;
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
            // 
            // butExit
            // 
            this.butExit.Image = global::QLRP.Properties.Resources.Close_icon;
            this.butExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butExit.Location = new System.Drawing.Point(287, 237);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 42);
            this.butExit.TabIndex = 9;
            this.butExit.Text = "Thoát";
            this.butExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // butDel
            // 
            this.butDel.Image = global::QLRP.Properties.Resources.trash_icon;
            this.butDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDel.Location = new System.Drawing.Point(196, 237);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(75, 42);
            this.butDel.TabIndex = 8;
            this.butDel.Text = "Xóa";
            this.butDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butEdit
            // 
            this.butEdit.Image = global::QLRP.Properties.Resources.Actions_edit_undo_icon;
            this.butEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butEdit.Location = new System.Drawing.Point(101, 237);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(75, 42);
            this.butEdit.TabIndex = 7;
            this.butEdit.Text = "Sửa";
            this.butEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butAdd
            // 
            this.butAdd.Image = global::QLRP.Properties.Resources.Add_Folder_icon;
            this.butAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butAdd.Location = new System.Drawing.Point(9, 237);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 42);
            this.butAdd.TabIndex = 6;
            this.butAdd.Text = "Thêm";
            this.butAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // cbbSort
            // 
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Location = new System.Drawing.Point(232, 307);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(113, 21);
            this.cbbSort.TabIndex = 12;
            // 
            // QuanLyRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 465);
            this.Controls.Add(this.cbbSort);
            this.Controls.Add(this.butSort);
            this.Controls.Add(this.cbbTenNhanVien);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenRap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaRP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLyRap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyRap";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaRP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenRap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cbbTenNhanVien;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.ComboBox cbbSort;
    }
}