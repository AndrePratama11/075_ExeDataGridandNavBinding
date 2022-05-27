
namespace ExeDataGridandNavBinding
{
    partial class Data_Grid_View
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
            this.nIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMhsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatMhsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneMhsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodiTIDataSet = new ExeDataGridandNavBinding.ProdiTIDataSet();
            this.mahasiswaTableAdapter = new ExeDataGridandNavBinding.ProdiTIDataSetTableAdapters.MahasiswaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIMDataGridViewTextBoxColumn,
            this.namaMhsDataGridViewTextBoxColumn,
            this.alamatMhsDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.phoneMhsDataGridViewTextBoxColumn,
            this.iDUserDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mahasiswaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(893, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // nIMDataGridViewTextBoxColumn
            // 
            this.nIMDataGridViewTextBoxColumn.DataPropertyName = "NIM";
            this.nIMDataGridViewTextBoxColumn.HeaderText = "NIM";
            this.nIMDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nIMDataGridViewTextBoxColumn.Name = "nIMDataGridViewTextBoxColumn";
            this.nIMDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaMhsDataGridViewTextBoxColumn
            // 
            this.namaMhsDataGridViewTextBoxColumn.DataPropertyName = "NamaMhs";
            this.namaMhsDataGridViewTextBoxColumn.HeaderText = "NamaMhs";
            this.namaMhsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaMhsDataGridViewTextBoxColumn.Name = "namaMhsDataGridViewTextBoxColumn";
            this.namaMhsDataGridViewTextBoxColumn.Width = 150;
            // 
            // alamatMhsDataGridViewTextBoxColumn
            // 
            this.alamatMhsDataGridViewTextBoxColumn.DataPropertyName = "AlamatMhs";
            this.alamatMhsDataGridViewTextBoxColumn.HeaderText = "AlamatMhs";
            this.alamatMhsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatMhsDataGridViewTextBoxColumn.Name = "alamatMhsDataGridViewTextBoxColumn";
            this.alamatMhsDataGridViewTextBoxColumn.Width = 150;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneMhsDataGridViewTextBoxColumn
            // 
            this.phoneMhsDataGridViewTextBoxColumn.DataPropertyName = "PhoneMhs";
            this.phoneMhsDataGridViewTextBoxColumn.HeaderText = "PhoneMhs";
            this.phoneMhsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneMhsDataGridViewTextBoxColumn.Name = "phoneMhsDataGridViewTextBoxColumn";
            this.phoneMhsDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDUserDataGridViewTextBoxColumn
            // 
            this.iDUserDataGridViewTextBoxColumn.DataPropertyName = "IDUser";
            this.iDUserDataGridViewTextBoxColumn.HeaderText = "IDUser";
            this.iDUserDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDUserDataGridViewTextBoxColumn.Name = "iDUserDataGridViewTextBoxColumn";
            this.iDUserDataGridViewTextBoxColumn.Width = 150;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.prodiTIDataSet;
            // 
            // prodiTIDataSet
            // 
            this.prodiTIDataSet.DataSetName = "ProdiTIDataSet";
            this.prodiTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("News706 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Grid View";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("News706 BT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(34, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Data_Grid_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(917, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Data_Grid_View";
            this.Text = "DataGridV";
            this.Load += new System.EventHandler(this.Data_Grid_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProdiTIDataSet prodiTIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private ProdiTIDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMhsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatMhsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneMhsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}