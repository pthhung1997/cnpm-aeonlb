namespace aeonlb.View
{
    partial class QuanLyNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sMaNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHoTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._cnpm_aeonlbDataSet = new aeonlb._cnpm_aeonlbDataSet();
            this.tblNhanVienTableAdapter = new aeonlb._cnpm_aeonlbDataSetTableAdapters.tblNhanVienTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cbbJob = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnResetMatKhau = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaNVDataGridViewTextBoxColumn,
            this.sHoTenNVDataGridViewTextBoxColumn,
            this.sChucVuDataGridViewTextBoxColumn,
            this.sTenDangNhapDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblNhanVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(447, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sMaNVDataGridViewTextBoxColumn
            // 
            this.sMaNVDataGridViewTextBoxColumn.DataPropertyName = "sMaNV";
            this.sMaNVDataGridViewTextBoxColumn.HeaderText = "sMaNV";
            this.sMaNVDataGridViewTextBoxColumn.Name = "sMaNVDataGridViewTextBoxColumn";
            this.sMaNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sHoTenNVDataGridViewTextBoxColumn
            // 
            this.sHoTenNVDataGridViewTextBoxColumn.DataPropertyName = "sHoTenNV";
            this.sHoTenNVDataGridViewTextBoxColumn.HeaderText = "sHoTenNV";
            this.sHoTenNVDataGridViewTextBoxColumn.Name = "sHoTenNVDataGridViewTextBoxColumn";
            this.sHoTenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sChucVuDataGridViewTextBoxColumn
            // 
            this.sChucVuDataGridViewTextBoxColumn.DataPropertyName = "sChucVu";
            this.sChucVuDataGridViewTextBoxColumn.HeaderText = "sChucVu";
            this.sChucVuDataGridViewTextBoxColumn.Name = "sChucVuDataGridViewTextBoxColumn";
            this.sChucVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTenDangNhapDataGridViewTextBoxColumn
            // 
            this.sTenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "sTenDangNhap";
            this.sTenDangNhapDataGridViewTextBoxColumn.HeaderText = "sTenDangNhap";
            this.sTenDangNhapDataGridViewTextBoxColumn.Name = "sTenDangNhapDataGridViewTextBoxColumn";
            this.sTenDangNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource.DataSource = this._cnpm_aeonlbDataSet;
            // 
            // _cnpm_aeonlbDataSet
            // 
            this._cnpm_aeonlbDataSet.DataSetName = "_cnpm_aeonlbDataSet";
            this._cnpm_aeonlbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên đăng nhập";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(577, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(577, 155);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(163, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // cbbJob
            // 
            this.cbbJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbJob.FormattingEnabled = true;
            this.cbbJob.Location = new System.Drawing.Point(577, 116);
            this.cbbJob.Name = "cbbJob";
            this.cbbJob.Size = new System.Drawing.Size(121, 21);
            this.cbbJob.TabIndex = 6;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(510, 213);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnResetMatKhau
            // 
            this.btnResetMatKhau.Location = new System.Drawing.Point(565, 253);
            this.btnResetMatKhau.Name = "btnResetMatKhau";
            this.btnResetMatKhau.Size = new System.Drawing.Size(97, 23);
            this.btnResetMatKhau.TabIndex = 8;
            this.btnResetMatKhau.Text = "Đặt lại mật khẩu";
            this.btnResetMatKhau.UseVisualStyleBackColor = true;
            this.btnResetMatKhau.Click += new System.EventHandler(this.btnResetMatKhau_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(634, 213);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 344);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnResetMatKhau);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbbJob);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _cnpm_aeonlbDataSet _cnpm_aeonlbDataSet;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private _cnpm_aeonlbDataSetTableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHoTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cbbJob;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnResetMatKhau;
        private System.Windows.Forms.Button btnHuy;
    }
}