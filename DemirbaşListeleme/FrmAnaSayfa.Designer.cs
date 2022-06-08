namespace DemirbaşListeleme
{
    partial class FrmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKayitliMal = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnMuhasebe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 26);
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            // 
            // btnKayitliMal
            // 
            this.btnKayitliMal.BackColor = System.Drawing.Color.RosyBrown;
            this.btnKayitliMal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKayitliMal.BackgroundImage")));
            this.btnKayitliMal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayitliMal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKayitliMal.Location = new System.Drawing.Point(208, 162);
            this.btnKayitliMal.Margin = new System.Windows.Forms.Padding(5);
            this.btnKayitliMal.Name = "btnKayitliMal";
            this.btnKayitliMal.Size = new System.Drawing.Size(155, 141);
            this.btnKayitliMal.TabIndex = 1;
            this.btnKayitliMal.UseVisualStyleBackColor = false;
            this.btnKayitliMal.Click += new System.EventHandler(this.btnKayitliMal_Click_1);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.RosyBrown;
            this.btnList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnList.BackgroundImage")));
            this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnList.Location = new System.Drawing.Point(14, 162);
            this.btnList.Margin = new System.Windows.Forms.Padding(5);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(156, 141);
            this.btnList.TabIndex = 0;
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnMuhasebe
            // 
            this.btnMuhasebe.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMuhasebe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMuhasebe.BackgroundImage")));
            this.btnMuhasebe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMuhasebe.Location = new System.Drawing.Point(396, 162);
            this.btnMuhasebe.Margin = new System.Windows.Forms.Padding(5);
            this.btnMuhasebe.Name = "btnMuhasebe";
            this.btnMuhasebe.Size = new System.Drawing.Size(154, 141);
            this.btnMuhasebe.TabIndex = 2;
            this.btnMuhasebe.UseVisualStyleBackColor = false;
            this.btnMuhasebe.Click += new System.EventHandler(this.btnKayitliMal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 106);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ana Sayfa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mal Listesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kayıtlı Mallar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Muhasebe";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 439);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMuhasebe);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnKayitliMal);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.Button btnKayitliMal;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnMuhasebe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}