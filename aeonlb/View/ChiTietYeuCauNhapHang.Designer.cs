namespace aeonlb.View
{
    partial class ChiTietYeuCauNhapHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.txtMaYCN = new System.Windows.Forms.TextBox();
            this.txtSLYC = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Thêm = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this._cnpm_aeonlbDataSet = new aeonlb._cnpm_aeonlbDataSet();
            this.tblChiTietYeuCauNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblChiTietYeuCauNhapTableAdapter = new aeonlb._cnpm_aeonlbDataSetTableAdapters.tblChiTietYeuCauNhapTableAdapter();
            this.sMaHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaYeuCauNhapKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSoLuongYeuCauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietYeuCauNhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Yêu Cầu Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng Yêu Cầu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(161, 79);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(163, 20);
            this.txtMahang.TabIndex = 3;
            // 
            // txtMaYCN
            // 
            this.txtMaYCN.Location = new System.Drawing.Point(161, 126);
            this.txtMaYCN.Name = "txtMaYCN";
            this.txtMaYCN.Size = new System.Drawing.Size(163, 20);
            this.txtMaYCN.TabIndex = 4;
            // 
            // txtSLYC
            // 
            this.txtSLYC.Location = new System.Drawing.Point(161, 172);
            this.txtSLYC.Name = "txtSLYC";
            this.txtSLYC.Size = new System.Drawing.Size(163, 20);
            this.txtSLYC.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaHangDataGridViewTextBoxColumn,
            this.sMaYeuCauNhapKhoDataGridViewTextBoxColumn,
            this.fSoLuongYeuCauDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblChiTietYeuCauNhapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(368, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 285);
            this.dataGridView1.TabIndex = 6;
            // 
            // Thêm
            // 
            this.Thêm.Location = new System.Drawing.Point(24, 249);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(75, 23);
            this.Thêm.TabIndex = 7;
            this.Thêm.Text = "Thêm";
            this.Thêm.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(145, 249);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(270, 249);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // _cnpm_aeonlbDataSet
            // 
            this._cnpm_aeonlbDataSet.DataSetName = "_cnpm_aeonlbDataSet";
            this._cnpm_aeonlbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblChiTietYeuCauNhapBindingSource
            // 
            this.tblChiTietYeuCauNhapBindingSource.DataMember = "tblChiTietYeuCauNhap";
            this.tblChiTietYeuCauNhapBindingSource.DataSource = this._cnpm_aeonlbDataSet;
            // 
            // tblChiTietYeuCauNhapTableAdapter
            // 
            this.tblChiTietYeuCauNhapTableAdapter.ClearBeforeFill = true;
            // 
            // sMaHangDataGridViewTextBoxColumn
            // 
            this.sMaHangDataGridViewTextBoxColumn.DataPropertyName = "sMaHang";
            this.sMaHangDataGridViewTextBoxColumn.HeaderText = "sMaHang";
            this.sMaHangDataGridViewTextBoxColumn.Name = "sMaHangDataGridViewTextBoxColumn";
            // 
            // sMaYeuCauNhapKhoDataGridViewTextBoxColumn
            // 
            this.sMaYeuCauNhapKhoDataGridViewTextBoxColumn.DataPropertyName = "sMaYeuCauNhapKho";
            this.sMaYeuCauNhapKhoDataGridViewTextBoxColumn.HeaderText = "sMaYeuCauNhapKho";
            this.sMaYeuCauNhapKhoDataGridViewTextBoxColumn.Name = "sMaYeuCauNhapKhoDataGridViewTextBoxColumn";
            // 
            // fSoLuongYeuCauDataGridViewTextBoxColumn
            // 
            this.fSoLuongYeuCauDataGridViewTextBoxColumn.DataPropertyName = "fSoLuongYeuCau";
            this.fSoLuongYeuCauDataGridViewTextBoxColumn.HeaderText = "fSoLuongYeuCau";
            this.fSoLuongYeuCauDataGridViewTextBoxColumn.Name = "fSoLuongYeuCauDataGridViewTextBoxColumn";
            // 
            // ChiTietYeuCauNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 444);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.Thêm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSLYC);
            this.Controls.Add(this.txtMaYCN);
            this.Controls.Add(this.txtMahang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietYeuCauNhapHang";
            this.Text = "ChiTietYeuCauNhapHang";
            this.Load += new System.EventHandler(this.ChiTietYeuCauNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietYeuCauNhapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.TextBox txtMaYCN;
        private System.Windows.Forms.TextBox txtSLYC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Thêm;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private _cnpm_aeonlbDataSet _cnpm_aeonlbDataSet;
        private System.Windows.Forms.BindingSource tblChiTietYeuCauNhapBindingSource;
        private _cnpm_aeonlbDataSetTableAdapters.tblChiTietYeuCauNhapTableAdapter tblChiTietYeuCauNhapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaYeuCauNhapKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSoLuongYeuCauDataGridViewTextBoxColumn;
    }
}