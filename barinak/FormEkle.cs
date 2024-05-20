using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace barinak
{
    public partial class FormEkle : Form
    {
        public FormEkle()
        {
            InitializeComponent();
        }
        string baglanti = "Server=localhost;Database=barinak;Uid=root;Pwd=''";
        string hedefDosya;

        private void btnResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "resim dosyası |*.jpg;*.nef;*.png|video|*.avi|Tüm dosyalar|*.*";
            dosya.Title = "Dosya Seçin";

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                string kaynakDosya = dosya.FileName;
                hedefDosya = Path.Combine("resimler", Guid.NewGuid() + ".jpg");


                if (!Directory.Exists("resimler"))
                {
                    Directory.CreateDirectory("resimler");
                }

                File.Copy(kaynakDosya, hedefDosya);
                pbEHayvan.ImageLocation = hedefDosya;
                pbEHayvan.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {

                string sql = "INSERT INTO hayvanlar (tur,cins,ad,dogumyil,saglikli,resim) VALUES (@tur,@cins,@ad,@dogumyil,@saglikli,@resim);";

                con.Open();



                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@tur", cmbETur.Text);
                cmd.Parameters.AddWithValue("@cins", txtECins.Text);
                cmd.Parameters.AddWithValue("@ad", txtEAd.Text);
                cmd.Parameters.AddWithValue("@dogumyil", dtpEDogum.Value);
                cmd.Parameters.AddWithValue("@saglikli", chkESaglikli.Checked);
                cmd.Parameters.AddWithValue("@resim", hedefDosya);



                DialogResult result = MessageBox.Show("Hayvan eklensin mi?", "Hayvan Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();

                    txtEAd.Clear();
                    txtECins.Clear();
                    cmbETur.SelectedIndex = -1;
                    
                }



            }
        }
    }
}
