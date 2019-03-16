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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this._cnpm_aeonlbDataSet = new aeonlb._cnpm_aeonlbDataSet();
            this.tblYeuCauNhapKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblYeuCauNhapKhoTableAdapter = new aeonlb._cnpm_aeonlbDataSetTableAdapters.tblYeuCauNhapKhoTableAdapter();
            this.sMaYeuCauNhapKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dThoiGianYeuCauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTrangThaiYeuCauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYeuCauNhapKhoBindingSource)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(166, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaYeuCauNhapKhoDataGridViewTextBoxColumn,
            this.sMaNVDataGridViewTextBoxColumn,
            this.dThoiGianYeuCauDataGridViewTextBoxColumn,
            this.sTrangThaiYeuCauDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblYeuCauNhapKhoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(322, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 232);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // _cnpm_aeonlbDataSet
            // 
            this._cnpm_aeonlbDataSet.DataSetName = "_cnpm_aeonlbDataSet";
            this._cnpm_aeonlbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblYeuCauNhapKhoBindingSource
            // 
            this.tblYeuCauNhapKhoBindingSource.DataMember = "tblYeuCauNhapKho";
            this.tblYeuCauNhapKhoBindingSource.DataSource = this._cnpm_aeonlbDataSet;
            // 
            // tblYeuCauNhapKhoTableAdapter
            // 
            this.tblYeuCauNhapKhoTableAdapter.ClearBeforeFill = true;
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
            // YeuCauNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 346);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeuCauNhap";
            this.Text = "YeuCauNhap";
            this.Load += new System.EventHandler(this.YeuCauNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cnpm_aeonlbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYeuCauNhapKhoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}