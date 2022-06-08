namespace DemirbaşListeleme
{
    partial class FrmMuhasebe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMuhasebe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.malTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMuhasebeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasinirMalDataSet4 = new DemirbaşListeleme.tasinirMalDataSet4();
            this.tbl_MuhasebeTableAdapter = new DemirbaşListeleme.tasinirMalDataSet4TableAdapters.Tbl_MuhasebeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMuhasebeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasinirMalDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malTutarDataGridViewTextBoxColumn,
            this.malTarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMuhasebeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 439);
            this.dataGridView1.TabIndex = 5;
            // 
            // malTutarDataGridViewTextBoxColumn
            // 
            this.malTutarDataGridViewTextBoxColumn.DataPropertyName = "MalTutar";
            this.malTutarDataGridViewTextBoxColumn.HeaderText = "MalTutar";
            this.malTutarDataGridViewTextBoxColumn.Name = "malTutarDataGridViewTextBoxColumn";
            // 
            // malTarihDataGridViewTextBoxColumn
            // 
            this.malTarihDataGridViewTextBoxColumn.DataPropertyName = "MalTarih";
            this.malTarihDataGridViewTextBoxColumn.HeaderText = "MalTarih";
            this.malTarihDataGridViewTextBoxColumn.Name = "malTarihDataGridViewTextBoxColumn";
            // 
            // tblMuhasebeBindingSource
            // 
            this.tblMuhasebeBindingSource.DataMember = "Tbl_Muhasebe";
            this.tblMuhasebeBindingSource.DataSource = this.tasinirMalDataSet4;
            // 
            // tasinirMalDataSet4
            // 
            this.tasinirMalDataSet4.DataSetName = "tasinirMalDataSet4";
            this.tasinirMalDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_MuhasebeTableAdapter
            // 
            this.tbl_MuhasebeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMuhasebe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(595, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmMuhasebe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muhasebe";
            this.Load += new System.EventHandler(this.FrmMuhasebe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMuhasebeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasinirMalDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private tasinirMalDataSet4 tasinirMalDataSet4;
        private System.Windows.Forms.BindingSource tblMuhasebeBindingSource;
        private tasinirMalDataSet4TableAdapters.Tbl_MuhasebeTableAdapter tbl_MuhasebeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn malTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}