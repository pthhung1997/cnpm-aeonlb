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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this._cnpm_aeonlbDataSet = new aeonlb._cnpm_aeonlbDataSet();
            this.tblChiTietNhapKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblChiTietNhapKhoTableAdapter = new aeonlb._cnpm_aeonlbDataSetTableAdapters.tblChiTietNhapKhoTableAdapter();
            this.sMaHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNhapKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSoLuongThucNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietNhapKhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaHangDataGridViewTextBoxColumn,
            this.sMaNhapKhoDataGridViewTextBoxColumn,
            this.fSoLuongThucNhapDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblChiTietNhapKhoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(308, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 280);
            this.dataGridView1.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // _cnpm_aeonlbDataSet
            // 
            this._cnpm_aeonlbDataSet.DataSetName = "_cnpm_aeonlbDataSet";
            this._cnpm_aeonlbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblChiTietNhapKhoBindingSource
            // 
            this.tblChiTietNhapKhoBindingSource.DataMember = "tblChiTietNhapKho";
            this.tblChiTietNhapKhoBindingSource.DataSource = this._cnpm_aeonlbDataSet;
            // 
            // tblChiTietNhapKhoTableAdapter
            // 
            this.tblChiTietNhapKhoTableAdapter.ClearBeforeFill = true;
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
            // ChiTietNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 390);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ChiTietNhapHang";
            this.Text = "ChiTietNhapHang";
            this.Load += new System.EventHandler(this.ChiTietNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietNhapKhoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private _cnpm_aeonlbDataSet _cnpm_aeonlbDataSet;
        private System.Windows.Forms.BindingSource tblChiTietNhapKhoBindingSource;
        private _cnpm_aeonlbDataSetTableAdapters.tblChiTietNhapKhoTableAdapter tblChiTietNhapKhoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNhapKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSoLuongThucNhapDataGridViewTextBoxColumn;
    }
}