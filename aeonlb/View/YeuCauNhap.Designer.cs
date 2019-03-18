namespace aeonlb.View
{
    partial class YeuCauNhap
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaYCN = new System.Windows.Forms.TextBox();
            this.txtTGYC = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.dgvYCN = new System.Windows.Forms.DataGridView();
            this.sMaYeuCauNhapKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dThoiGianYeuCauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTrangThaiYeuCauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblYeuCauNhapKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._cnpm_aeonlbDataSet = new aeonlb._cnpm_aeonlbDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tblYeuCauNhapKhoTableAdapter = new aeonlb._cnpm_aeonlbDataSetTableAdapters.tblYeuCauNhapKhoTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYeuCauNhapKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Yêu Cầu Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian yêu cầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng thái:";
            // 
            // txtMaYCN
            // 
            this.txtMaYCN.Location = new System.Drawing.Point(166, 55);
            this.txtMaYCN.Name = "txtMaYCN";
            this.txtMaYCN.Size = new System.Drawing.Size(175, 20);
            this.txtMaYCN.TabIndex = 4;
            // 
            // txtTGYC
            // 
            this.txtTGYC.Location = new System.Drawing.Point(166, 93);
            this.txtTGYC.Name = "txtTGYC";
            this.txtTGYC.Size = new System.Drawing.Size(175, 20);
            this.txtTGYC.TabIndex = 5;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(166, 127);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(175, 20);
            this.txtMaNV.TabIndex = 6;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(166, 163);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(175, 20);
            this.txtTrangThai.TabIndex = 7;
            // 
            // dgvYCN
            // 
            this.dgvYCN.AutoGenerateColumns = false;
            this.dgvYCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYCN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaYeuCauNhapKhoDataGridViewTextBoxColumn,
            this.sMaNVDataGridViewTextBoxColumn,
            this.dThoiGianYeuCauDataGridViewTextBoxColumn,
            this.sTrangThaiYeuCauDataGridViewTextBoxColumn});
            this.dgvYCN.DataSource = this.tblYeuCauNhapKhoBindingSource;
            this.dgvYCN.Location = new System.Drawing.Point(513, 58);
            this.dgvYCN.Name = "dgvYCN";
            this.dgvYCN.Size = new System.Drawing.Size(442, 232);
            this.dgvYCN.TabIndex = 8;
            // 
            // sMaYeuCauNhapKhoDataGridViewTextBoxColumn
            // 
            this.sMaYeuCauNhapKhoDataGridViewTextBoxColumn.DataPropertyName = "sMaYeuCauNhapKho";
            this.sMaYeuCauNhapKhoDataGridViewTextBoxColumn.HeaderText = "sMaYeuCauNhapKho";
            this.sMaYeuCauNhapKhoDataGridViewTextBoxColumn.Name = "sMaYeuCauNhapKhoDataGridViewTextBoxColumn";
            // 
            // sMaNVDataGridViewTextBoxColumn
            // 
            this.sMaNVDataGridViewTextBoxColumn.DataPropertyName = "sMaNV";
            this.sMaNVDataGridViewTextBoxColumn.HeaderText = "sMaNV";
            this.sMaNVDataGridViewTextBoxColumn.Name = "sMaNVDataGridViewTextBoxColumn";
            // 
            // dThoiGianYeuCauDataGridViewTextBoxColumn
            // 
            this.dThoiGianYeuCauDataGridViewTextBoxColumn.DataPropertyName = "dThoiGianYeuCau";
            this.dThoiGianYeuCauDataGridViewTextBoxColumn.HeaderText = "dThoiGianYeuCau";
            this.dThoiGianYeuCauDataGridViewTextBoxColumn.Name = "dThoiGianYeuCauDataGridViewTextBoxColumn";
            // 
            // sTrangThaiYeuCauDataGridViewTextBoxColumn
            // 
            this.sTrangThaiYeuCauDataGridViewTextBoxColumn.DataPropertyName = "sTrangThaiYeuCau";
            this.sTrangThaiYeuCauDataGridViewTextBoxColumn.HeaderText = "sTrangThaiYeuCau";
            this.sTrangThaiYeuCauDataGridViewTextBoxColumn.Name = "sTrangThaiYeuCauDataGridViewTextBoxColumn";
            // 
            // tblYeuCauNhapKhoBindingSource
            // 
            this.tblYeuCauNhapKhoBindingSource.DataMember = "tblYeuCauNhapKho";
            this.tblYeuCauNhapKhoBindingSource.DataSource = this._cnpm_aeonlbDataSet;
            // 
            // _cnpm_aeonlbDataSet
            // 
            this._cnpm_aeonlbDataSet.DataSetName = "_cnpm_aeonlbDataSet";
            this._cnpm_aeonlbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tblYeuCauNhapKhoTableAdapter
            // 
            this.tblYeuCauNhapKhoTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(358, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // YeuCauNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 346);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvYCN);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtTGYC);
            this.Controls.Add(this.txtMaYCN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeuCauNhap";
            this.Text = "Yêu cầu nhập hàng";
            this.Load += new System.EventHandler(this.YeuCauNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYeuCauNhapKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaYCN;
        private System.Windows.Forms.TextBox txtTGYC;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.DataGridView dgvYCN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private _cnpm_aeonlbDataSet _cnpm_aeonlbDataSet;
        private System.Windows.Forms.BindingSource tblYeuCauNhapKhoBindingSource;
        private _cnpm_aeonlbDataSetTableAdapters.tblYeuCauNhapKhoTableAdapter tblYeuCauNhapKhoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaYeuCauNhapKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dThoiGianYeuCauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTrangThaiYeuCauDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}