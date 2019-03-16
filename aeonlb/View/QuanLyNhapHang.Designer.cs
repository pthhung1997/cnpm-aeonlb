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
            this.cnpmaeonlbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNhapKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNhapKhoTableAdapter = new aeonlb._cnpm_aeonlbDataSetTableAdapters.tblNhapKhoTableAdapter();
            this.sMaNhapKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayNhapKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmaeonlbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhapKhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaNhapKhoDataGridViewTextBoxColumn,
            this.dNgayNhapKhoDataGridViewTextBoxColumn,
            this.sMaNVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblNhapKhoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(353, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 269);
            this.dataGridView1.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 20);
            this.textBox3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 226);
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
            // cnpmaeonlbDataSetBindingSource
            // 
            this.cnpmaeonlbDataSetBindingSource.DataSource = this._cnpm_aeonlbDataSet;
            this.cnpmaeonlbDataSetBindingSource.Position = 0;
            // 
            // tblNhapKhoBindingSource
            // 
            this.tblNhapKhoBindingSource.DataMember = "tblNhapKho";
            this.tblNhapKhoBindingSource.DataSource = this.cnpmaeonlbDataSetBindingSource;
            // 
            // tblNhapKhoTableAdapter
            // 
            this.tblNhapKhoTableAdapter.ClearBeforeFill = true;
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
            // QuanLyNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 373);
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
            this.Name = "QuanLyNhapHang";
            this.Text = "QuanLyNhapHang";
            this.Load += new System.EventHandler(this.QuanLyNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmaeonlbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhapKhoBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource cnpmaeonlbDataSetBindingSource;
        private _cnpm_aeonlbDataSet _cnpm_aeonlbDataSet;
        private System.Windows.Forms.BindingSource tblNhapKhoBindingSource;
        private _cnpm_aeonlbDataSetTableAdapters.tblNhapKhoTableAdapter tblNhapKhoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNhapKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayNhapKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNVDataGridViewTextBoxColumn;
    }
}