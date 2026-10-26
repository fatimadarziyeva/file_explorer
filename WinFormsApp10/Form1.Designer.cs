namespace WinFormsApp10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnQovluq = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.btnSaxla = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtYol = new System.Windows.Forms.TextBox();
            this.lstFayllar = new System.Windows.Forms.ListBox();
            this.txtMetn = new System.Windows.Forms.RichTextBox();
            this.lblMelumat = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFayllarHeader = new System.Windows.Forms.Label();
            this.lblMetnHeader = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
        
            this.btnQovluq.Location = new System.Drawing.Point(20, 20);
            this.btnQovluq.Name = "btnQovluq";
            this.btnQovluq.Size = new System.Drawing.Size(100, 35);
            this.btnQovluq.TabIndex = 0;
            this.btnQovluq.Text = "Qovluq seç";
            this.btnQovluq.UseVisualStyleBackColor = true;
            this.btnQovluq.Click += new System.EventHandler(this.btnQovluq_Click);
            
            this.btnAc.Location = new System.Drawing.Point(130, 20);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(100, 35);
            this.btnAc.TabIndex = 1;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            
            this.btnSaxla.Location = new System.Drawing.Point(240, 20);
            this.btnSaxla.Name = "btnSaxla";
            this.btnSaxla.Size = new System.Drawing.Size(100, 35);
            this.btnSaxla.TabIndex = 2;
            this.btnSaxla.Text = "Yadda saxla";
            this.btnSaxla.UseVisualStyleBackColor = true;
            this.btnSaxla.Click += new System.EventHandler(this.btnSaxla_Click);
           
            this.btnSil.Location = new System.Drawing.Point(350, 20);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 35);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            
            this.txtYol.Location = new System.Drawing.Point(460, 26);
            this.txtYol.Name = "txtYol";
            this.txtYol.ReadOnly = true;
            this.txtYol.Size = new System.Drawing.Size(220, 22);
            this.txtYol.TabIndex = 4;
            
            this.lblFayllarHeader.AutoSize = true;
            this.lblFayllarHeader.Location = new System.Drawing.Point(20, 68);
            this.lblFayllarHeader.Name = "lblFayllarHeader";
            this.lblFayllarHeader.Size = new System.Drawing.Size(48, 16);
            this.lblFayllarHeader.Text = "Fayllar";
             
            this.lstFayllar.FormattingEnabled = true;
            this.lstFayllar.ItemHeight = 16;
            this.lstFayllar.Location = new System.Drawing.Point(20, 90);
            this.lstFayllar.Name = "lstFayllar";
            this.lstFayllar.Size = new System.Drawing.Size(180, 292);
            this.lstFayllar.TabIndex = 5;
            this.lstFayllar.SelectedIndexChanged += new System.EventHandler(this.lstFayllar_SelectedIndexChanged);
             
            this.lblMetnHeader.AutoSize = true;
            this.lblMetnHeader.Location = new System.Drawing.Point(215, 68);
            this.lblMetnHeader.Name = "lblMetnHeader";
            this.lblMetnHeader.Size = new System.Drawing.Size(36, 16);
            this.lblMetnHeader.Text = "Mətn";
            
            this.txtMetn.Location = new System.Drawing.Point(215, 90);
            this.txtMetn.Name = "txtMetn";
            this.txtMetn.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtMetn.Size = new System.Drawing.Size(465, 292);
            this.txtMetn.TabIndex = 6;
            this.txtMetn.Text = "";
             
            this.lblMelumat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMelumat.Location = new System.Drawing.Point(20, 395);
            this.lblMelumat.Name = "lblMelumat";
            this.lblMelumat.Padding = new System.Windows.Forms.Padding(5);
            this.lblMelumat.Size = new System.Drawing.Size(660, 35);
            this.lblMelumat.TabIndex = 7;
            this.lblMelumat.Text = "Ad: -   Ölçü: -   Yaranma tarixi: -";
             
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(700, 26);
            this.statusStrip1.TabIndex = 8;
             
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(130, 20);
            this.lblStatus.Text = "Hazırdır | Fayl sayı: 0";
             
            this.ClientSize = new System.Drawing.Size(700, 471);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblMelumat);
            this.Controls.Add(this.txtMetn);
            this.Controls.Add(this.lblMetnHeader);
            this.Controls.Add(this.lstFayllar);
            this.Controls.Add(this.lblFayllarHeader);
            this.Controls.Add(this.txtYol);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSaxla);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.btnQovluq);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fayl Meneceri";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnQovluq;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnSaxla;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtYol;
        private System.Windows.Forms.ListBox lstFayllar;
        private System.Windows.Forms.RichTextBox txtMetn;
        private System.Windows.Forms.Label lblMelumat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label lblFayllarHeader;
        private System.Windows.Forms.Label lblMetnHeader;
    }
}