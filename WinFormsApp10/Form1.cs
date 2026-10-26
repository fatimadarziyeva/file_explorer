using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        string secilenQovluq = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnQovluq_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                secilenQovluq = dialog.SelectedPath;
                txtYol.Text = secilenQovluq; 

                QovluqdakiFayllariYukle();
            }
        }

        private void QovluqdakiFayllariYukle()
        {
            lstFayllar.Items.Clear();

            if (Directory.Exists(secilenQovluq))
            {
                string[] fayllar = Directory.GetFiles(secilenQovluq);

                foreach (string faylYolu in fayllar)
                {
                    string faylAdi = Path.GetFileName(faylYolu);
                    lstFayllar.Items.Add(faylAdi);
                }

                lblStatus.Text = "Hazırdır | Fayl sayı: " + lstFayllar.Items.Count;
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedItem == null)
            {
                MessageBox.Show("Zəhmət olmasa bir fayl seçin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secilenFaylAdi = lstFayllar.SelectedItem.ToString();
            string tamYol = Path.Combine(secilenQovluq, secilenFaylAdi);

            if (File.Exists(tamYol))
            {
                txtMetn.Text = File.ReadAllText(tamYol);
            }
        }

        private void btnSaxla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(secilenQovluq))
            {
                MessageBox.Show("Əvvəlcə qovluq seçin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string faylAdi = "";
            if (lstFayllar.SelectedItem != null)
            {
                faylAdi = lstFayllar.SelectedItem.ToString();
            }
            else
            {
                faylAdi = "yeni_fayl.txt";
            }

            string tamYol = Path.Combine(secilenQovluq, faylAdi);
            File.WriteAllText(tamYol, txtMetn.Text);

            MessageBox.Show("Fayl uğurla yadda saxlanıldı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            QovluqdakiFayllariYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedItem == null)
            {
                MessageBox.Show("Lütfən silmək üçün bir fayl seçin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult cavab = MessageBox.Show("Seçilmiş faylı silməyə əminsiniz?", "Fayl Silinməsi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                string secilenFaylAdi = lstFayllar.SelectedItem.ToString();
                string tamYol = Path.Combine(secilenQovluq, secilenFaylAdi);

                if (File.Exists(tamYol))
                {
                    File.Delete(tamYol);
                    txtMetn.Clear();
                    lblMelumat.Text = "Ad: -   Ölçü: -   Yaranma tarixi: -";

                    QovluqdakiFayllariYukle(); 
                    MessageBox.Show("Fayl silindi!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lstFayllar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedItem != null)
            {
                string secilenFaylAdi = lstFayllar.SelectedItem.ToString();
                string tamYol = Path.Combine(secilenQovluq, secilenFaylAdi);

                FileInfo faylMelumati = new FileInfo(tamYol);

                if (faylMelumati.Exists)
                {
                    double olcuKB = Math.Round((double)faylMelumati.Length / 1024, 1);
                    if (olcuKB == 0 && faylMelumati.Length > 0) olcuKB = 0.1;

                    lblMelumat.Text = $"Ad: {faylMelumati.Name}   Ölçü: {olcuKB} KB   Yaranma tarixi: {faylMelumati.CreationTime:dd.MM.yyyy}";
                }
            }
        }
    }
}