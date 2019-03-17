namespace aeonlb.View
{
    partial class QuanLyNhapHang
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
            this.dgvQLNH = new System.Windows.Forms.DataGridView();
            this.sMaNhapKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayNhapKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNhapKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cnpmaeonlbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._cnpm_aeonlbDataSet = new aeonlb._cnpm_aeonlbDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtManhapkho = new System.Windows.Forms.TextBox();
            this.txtNgaynhapkho = new System.Windows.Forms.TextBox();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tblNhapKhoTableAdapter = new aeonlb._cnpm_aeonlbDataSetTableAdapters.tblNhapKhoTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhapKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmaeonlbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLNH
            // 
            this.dgvQLNH.AutoGenerateColumns = false;
            this.dgvQLNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaNhapKhoDataGridViewTextBoxColumn,
            this.dNgayNhapKhoDataGridViewTextBoxColumn,
            this.sMaNVDataGridViewTextBoxColumn});
            this.dgvQLNH.DataSource = this.tblNhapKhoBindingSource;
            this.dgvQLNH.Location = new System.Drawing.Point(504, 66);
            this.dgvQLNH.Name = "dgvQLNH";
            this.dgvQLNH.Size = new System.Drawing.Size(342, 269);
            this.dgvQLNH.TabIndex = 0;
            // 
            // sMaNhapKhoDataGridViewTextBoxColumn
            // 
            this.sMaNhapKhoDataGridViewTextBoxColumn.DataPropertyName = "sMaNhapKho";
            this.sMaNhapKhoDataGridViewTextBoxColumn.HeaderText = "sMaNhapKho";
            this.sMaNhapKhoDataGridViewTextBoxColumn.Name = "sMaNhapKhoDataGridViewTextBoxColumn";
            // 
            // dNgayNhapKhoDataGridViewTextBoxColumn
            // 
            this.dNgayNhapKhoDataGridViewTextBoxColumn.DataPropertyName = "dNgayNhapKho";
            this.dNgayNhapKhoDataGridViewTextBoxColumn.HeaderText = "dNgayNhapKho";
            this.dNgayNhapKhoDataGridViewTextBoxColumn.Name = "dNgayNhapKhoDataGridViewTextBoxColumn";
            // 
            // sMaNVDataGridViewTextBoxColumn
            // 
            this.sMaNVDataGridViewTextBoxColumn.DataPropertyName = "sMaNV";
            this.sMaNVDataGridViewTextBoxColumn.HeaderText = "sMaNV";
            this.sMaNVDataGridViewTextBoxColumn.Name = "sMaNVDataGridViewTextBoxColumn";
            // 
            // tblNhapKhoBindingSource
            // 
            this.tblNhapKhoBindingSource.DataMember = "tblNhapKho";
            this.tblNhapKhoBindingSource.DataSource = this.cnpmaeonlbDataSetBindingSource;
            // 
            // cnpmaeonlbDataSetBindingSource
            // 
            this.cnpmaeonlbDataSetBindingSource.DataSource = this._cnpm_aeonlbDataSet;
            this.cnpmaeonlbDataSetBindingSource.Position = 0;
            // 
            // _cnpm_aeonlbDataSet
            // 
            this._cnpm_aeonlbDataSet.DataSetName = "_cnpm_aeonlbDataSet";
            this._cnpm_aeonlbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã nhân viên:";
            // 
            // txtManhapkho
            // 
            this.txtManhapkho.Location = new System.Drawing.Point(146, 80);
            this.txtManhapkho.Name = "txtManhapkho";
            this.txtManhapkho.Size = new System.Drawing.Size(166, 20);
            this.txtManhapkho.TabIndex = 4;
            // 
            // txtNgaynhapkho
            // 
            this.txtNgaynhapkho.Location = new System.Drawing.Point(146, 121);
            this.txtNgaynhapkho.Name = "txtNgaynhapkho";
            this.txtNgaynhapkho.Size = new System.Drawing.Size(166, 20);
            this.txtNgaynhapkho.TabIndex = 5;
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Location = new System.Drawing.Point(146, 163);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(166, 20);
            this.txtManhanvien.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tblNhapKhoTableAdapter
            // 
            this.tblNhapKhoTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(403, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // QuanLyNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 373);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtManhanvien);
            this.Controls.Add(this.txtNgaynhapkho);
            this.Controls.Add(this.txtManhapkho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQLNH);
            this.Name = "QuanLyNhapHang";
            this.Text = "QuanLyNhapHang";
            this.Load += new System.EventHandler(this.QuanLyNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhapKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmaeonlbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLNH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtManhapkho;
        private System.Windows.Forms.TextBox txtNgaynhapkho;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource cnpmaeonlbDataSetBindingSource;
        private _cnpm_aeonlbDataSet _cnpm_aeonlbDataSet;
        private System.Windows.Forms.BindingSource tblNhapKhoBindingSource;
        private _cnpm_aeonlbDataSetTableAdapters.tblNhapKhoTableAdapter tblNhapKhoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNhapKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayNhapKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}