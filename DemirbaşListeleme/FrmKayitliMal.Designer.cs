namespace DemirbaşListeleme
{
    partial class FrmKayitliMal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayitliMal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMalListeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasinirMalDataSet3 = new DemirbaşListeleme.tasinirMalDataSet3();
            this.tbl_MalListeTableAdapter = new DemirbaşListeleme.tasinirMalDataSet3TableAdapters.Tbl_MalListeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalListeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasinirMalDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maladDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMalListeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 439);
            this.dataGridView1.TabIndex = 0;
            // 
            // maladDataGridViewTextBoxColumn
            // 
            this.maladDataGridViewTextBoxColumn.DataPropertyName = "Malad";
            this.maladDataGridViewTextBoxColumn.HeaderText = "Malad";
            this.maladDataGridViewTextBoxColumn.Name = "maladDataGridViewTextBoxColumn";
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "Adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            // 
            // tblMalListeBindingSource
            // 
            this.tblMalListeBindingSource.DataMember = "Tbl_MalListe";
            this.tblMalListeBindingSource.DataSource = this.tasinirMalDataSet3;
            // 
            // tasinirMalDataSet3
            // 
            this.tasinirMalDataSet3.DataSetName = "tasinirMalDataSet3";
            this.tasinirMalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_MalListeTableAdapter
            // 
            this.tbl_MalListeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(248, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmKayitliMal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmKayitliMal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıtlı Mallar";
            this.Load += new System.EventHandler(this.FrmKayitliMal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalListeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasinirMalDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private tasinirMalDataSet3 tasinirMalDataSet3;
        private System.Windows.Forms.BindingSource tblMalListeBindingSource;
        private tasinirMalDataSet3TableAdapters.Tbl_MalListeTableAdapter tbl_MalListeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}