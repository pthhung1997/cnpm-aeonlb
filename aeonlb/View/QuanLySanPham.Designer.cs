﻿namespace aeonlb.View
{
    partial class QuanLySanPham
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
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.tblHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._cnpm_aeonlbDataSet = new aeonlb._cnpm_aeonlbDataSet();
            this.tblHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTenHang = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btupdate = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.tblHangTableAdapter = new aeonlb._cnpm_aeonlbDataSetTableAdapters.tblHangTableAdapter();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.sTenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMotaHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSLHienTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDonViTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGiaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoGenerateColumns = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTenHangDataGridViewTextBoxColumn,
            this.sMotaHangDataGridViewTextBoxColumn,
            this.fSLHienTaiDataGridViewTextBoxColumn,
            this.sDonViTinhDataGridViewTextBoxColumn,
            this.fGiaBanDataGridViewTextBoxColumn,
            this.Column1});
            this.dgvSanPham.DataSource = this.tblHangBindingSource1;
            this.dgvSanPham.Location = new System.Drawing.Point(12, 76);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(516, 237);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            this.dgvSanPham.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSanPham_DataBindingComplete);
            // 
            // tblHangBindingSource1
            // 
            this.tblHangBindingSource1.DataMember = "tblHang";
            this.tblHangBindingSource1.DataSource = this._cnpm_aeonlbDataSet;
            // 
            // _cnpm_aeonlbDataSet
            // 
            this._cnpm_aeonlbDataSet.DataSetName = "_cnpm_aeonlbDataSet";
            this._cnpm_aeonlbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHangBindingSource
            // 
            this.tblHangBindingSource.DataMember = "tblHang";
            this.tblHangBindingSource.DataSource = this._cnpm_aeonlbDataSet;
            // 
            // sTenHang
            // 
            this.sTenHang.AutoSize = true;
            this.sTenHang.Location = new System.Drawing.Point(534, 77);
            this.sTenHang.Name = "sTenHang";
            this.sTenHang.Size = new System.Drawing.Size(55, 13);
            this.sTenHang.TabIndex = 1;
            this.sTenHang.Text = "Tên Hàng";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(604, 74);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(100, 20);
            this.txtTenHang.TabIndex = 2;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(604, 128);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(100, 20);
            this.txtMoTa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mô Tả";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(604, 181);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 20);
            this.txtGiaBan.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá Bán";
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(540, 231);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 7;
            this.btupdate.Text = "Sửa";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // bthuy
            // 
            this.bthuy.Location = new System.Drawing.Point(636, 231);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(75, 23);
            this.bthuy.TabIndex = 8;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // tblHangTableAdapter
            // 
            this.tblHangTableAdapter.ClearBeforeFill = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(12, 23);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(267, 20);
            this.txtTimKiem.TabIndex = 9;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(306, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // sTenHangDataGridViewTextBoxColumn
            // 
            this.sTenHangDataGridViewTextBoxColumn.DataPropertyName = "sTenHang";
            this.sTenHangDataGridViewTextBoxColumn.HeaderText = "Tên Hàng";
            this.sTenHangDataGridViewTextBoxColumn.Name = "sTenHangDataGridViewTextBoxColumn";
            // 
            // sMotaHangDataGridViewTextBoxColumn
            // 
            this.sMotaHangDataGridViewTextBoxColumn.DataPropertyName = "sMotaHang";
            this.sMotaHangDataGridViewTextBoxColumn.HeaderText = "Mô Tả";
            this.sMotaHangDataGridViewTextBoxColumn.Name = "sMotaHangDataGridViewTextBoxColumn";
            // 
            // fSLHienTaiDataGridViewTextBoxColumn
            // 
            this.fSLHienTaiDataGridViewTextBoxColumn.DataPropertyName = "fSLHienTai";
            this.fSLHienTaiDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.fSLHienTaiDataGridViewTextBoxColumn.Name = "fSLHienTaiDataGridViewTextBoxColumn";
            this.fSLHienTaiDataGridViewTextBoxColumn.Width = 50;
            // 
            // sDonViTinhDataGridViewTextBoxColumn
            // 
            this.sDonViTinhDataGridViewTextBoxColumn.DataPropertyName = "sDonViTinh";
            this.sDonViTinhDataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.sDonViTinhDataGridViewTextBoxColumn.Name = "sDonViTinhDataGridViewTextBoxColumn";
            // 
            // fGiaBanDataGridViewTextBoxColumn
            // 
            this.fGiaBanDataGridViewTextBoxColumn.DataPropertyName = "fGiaBan";
            this.fGiaBanDataGridViewTextBoxColumn.HeaderText = "Giá Bán";
            this.fGiaBanDataGridViewTextBoxColumn.Name = "fGiaBanDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sMaHang";
            this.Column1.HeaderText = "Ma Hang";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 325);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.sTenHang);
            this.Controls.Add(this.dgvSanPham);
            this.Name = "QuanLySanPham";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.DataGridView dgvSanPham;
		private System.Windows.Forms.Label sTenHang;
		private System.Windows.Forms.TextBox txtTenHang;
		private System.Windows.Forms.TextBox txtMoTa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtGiaBan;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btupdate;
		private System.Windows.Forms.Button bthuy;
		private _cnpm_aeonlbDataSet _cnpm_aeonlbDataSet;
		private System.Windows.Forms.BindingSource tblHangBindingSource;
		private _cnpm_aeonlbDataSetTableAdapters.tblHangTableAdapter tblHangTableAdapter;
		private System.Windows.Forms.BindingSource tblHangBindingSource1;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMotaHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSLHienTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDonViTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGiaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}