namespace aeonlb.View
{
    partial class ChiTietNhapHang
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
            this.dgvCTNH = new System.Windows.Forms.DataGridView();
            this.sMaHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNhapKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSoLuongThucNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblChiTietNhapKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._cnpm_aeonlbDataSet = new aeonlb._cnpm_aeonlbDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.txtMakhonhap = new System.Windows.Forms.TextBox();
            this.txtSoluongthucnhap = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tblChiTietNhapKhoTableAdapter = new aeonlb._cnpm_aeonlbDataSetTableAdapters.tblChiTietNhapKhoTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietNhapKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTNH
            // 
            this.dgvCTNH.AutoGenerateColumns = false;
            this.dgvCTNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTNH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaHangDataGridViewTextBoxColumn,
            this.sMaNhapKhoDataGridViewTextBoxColumn,
            this.fSoLuongThucNhapDataGridViewTextBoxColumn});
            this.dgvCTNH.DataSource = this.tblChiTietNhapKhoBindingSource;
            this.dgvCTNH.Location = new System.Drawing.Point(488, 49);
            this.dgvCTNH.Name = "dgvCTNH";
            this.dgvCTNH.Size = new System.Drawing.Size(343, 280);
            this.dgvCTNH.TabIndex = 0;
            // 
            // sMaHangDataGridViewTextBoxColumn
            // 
            this.sMaHangDataGridViewTextBoxColumn.DataPropertyName = "sMaHang";
            this.sMaHangDataGridViewTextBoxColumn.HeaderText = "sMaHang";
            this.sMaHangDataGridViewTextBoxColumn.Name = "sMaHangDataGridViewTextBoxColumn";
            // 
            // sMaNhapKhoDataGridViewTextBoxColumn
            // 
            this.sMaNhapKhoDataGridViewTextBoxColumn.DataPropertyName = "sMaNhapKho";
            this.sMaNhapKhoDataGridViewTextBoxColumn.HeaderText = "sMaNhapKho";
            this.sMaNhapKhoDataGridViewTextBoxColumn.Name = "sMaNhapKhoDataGridViewTextBoxColumn";
            // 
            // fSoLuongThucNhapDataGridViewTextBoxColumn
            // 
            this.fSoLuongThucNhapDataGridViewTextBoxColumn.DataPropertyName = "fSoLuongThucNhap";
            this.fSoLuongThucNhapDataGridViewTextBoxColumn.HeaderText = "fSoLuongThucNhap";
            this.fSoLuongThucNhapDataGridViewTextBoxColumn.Name = "fSoLuongThucNhapDataGridViewTextBoxColumn";
            // 
            // tblChiTietNhapKhoBindingSource
            // 
            this.tblChiTietNhapKhoBindingSource.DataMember = "tblChiTietNhapKho";
            this.tblChiTietNhapKhoBindingSource.DataSource = this._cnpm_aeonlbDataSet;
            // 
            // _cnpm_aeonlbDataSet
            // 
            this._cnpm_aeonlbDataSet.DataSetName = "_cnpm_aeonlbDataSet";
            this._cnpm_aeonlbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã kho nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng thực nhập:";
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(145, 61);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(130, 20);
            this.txtMahang.TabIndex = 4;
            // 
            // txtMakhonhap
            // 
            this.txtMakhonhap.Location = new System.Drawing.Point(145, 120);
            this.txtMakhonhap.Name = "txtMakhonhap";
            this.txtMakhonhap.Size = new System.Drawing.Size(130, 20);
            this.txtMakhonhap.TabIndex = 5;
            // 
            // txtSoluongthucnhap
            // 
            this.txtSoluongthucnhap.Location = new System.Drawing.Point(145, 173);
            this.txtSoluongthucnhap.Name = "txtSoluongthucnhap";
            this.txtSoluongthucnhap.Size = new System.Drawing.Size(130, 20);
            this.txtSoluongthucnhap.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tblChiTietNhapKhoTableAdapter
            // 
            this.tblChiTietNhapKhoTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(337, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ChiTietNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 390);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSoluongthucnhap);
            this.Controls.Add(this.txtMakhonhap);
            this.Controls.Add(this.txtMahang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCTNH);
            this.Name = "ChiTietNhapHang";
            this.Text = "ChiTietNhapHang";
            this.Load += new System.EventHandler(this.ChiTietNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietNhapKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTNH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.TextBox txtMakhonhap;
        private System.Windows.Forms.TextBox txtSoluongthucnhap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private _cnpm_aeonlbDataSet _cnpm_aeonlbDataSet;
        private System.Windows.Forms.BindingSource tblChiTietNhapKhoBindingSource;
        private _cnpm_aeonlbDataSetTableAdapters.tblChiTietNhapKhoTableAdapter tblChiTietNhapKhoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNhapKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSoLuongThucNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}