using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace barinak
{
    public partial class FormListe : Form
    {
        public FormListe()
        {
            InitializeComponent();
        }


        string baglanti = "Server=localhost;Database=barinak;Uid=root;Pwd=''";
        DataTable dt;
        void VeriGetir()
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {

                string sql = "SELECT *FROM hayvanlar";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                dt = new DataTable();

                da.Fill(dt);

                dgvListe.DataSource = dt;
                dgvListe.Invalidate();
                dgvListe.Refresh();


            }
        }



        void VeriFiltrele(string sql)
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {


                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                dt = new DataTable();

                da.Fill(dt);

                dgvListe.DataSource = dt;
                dgvListe.Invalidate();
                dgvListe.Refresh();

            }
        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgvListe.CurrentRow.Cells["ad"].Value.ToString();
            cmbTur.Text = dgvListe.CurrentRow.Cells["tur"].Value.ToString();
            txtCins.Text = dgvListe.CurrentRow.Cells["cins"].Value.ToString();
            //dtpDogum.Value =Convert.ToDateTime (dgvListe.CurrentRow.Cells["dogumyil"].Value);
            int dogumYili = (int)dgvListe.CurrentRow.Cells["dogumyil"].Value;
            string resimYolu = dgvListe.CurrentRow.Cells["resim"].Value.ToString();
            pbHayvan.ImageLocation = resimYolu;
            this.Text = resimYolu;
            chkSaglikli.Checked = Convert.ToBoolean(dgvListe.CurrentRow.Cells["saglikli"].Value);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {
                string sql = "DELETE FROM hayvanlar WHERE id=@id";
                int Id = Convert.ToInt32(dgvListe.CurrentRow.Cells["id"].Value);

                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", Id);

                DialogResult result = MessageBox.Show("Hayvan silinsin mi?", "Hayvanı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    VeriGetir();
                }
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            using (MySqlConnection con = new MySqlConnection(baglanti))
            {
                string sql = "UPDATE hayvanlar SET tur=@tur, cins=@cins,ad=@ad,dogumyil=@dogumyil,saglikli=@saglikli,resim=@resim WHERE id=@id;";
                int secilenId = Convert.ToInt32(dgvListe.CurrentRow.Cells["id"].Value);
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@tur", cmbTur.Text);
                cmd.Parameters.AddWithValue("@cins", txtCins.Text);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@dogumyil", dtpDogum.Value);
                cmd.Parameters.AddWithValue("@saglikli", chkSaglikli.Checked);
                cmd.Parameters.AddWithValue("@resim", pbHayvan.Image);
                cmd.Parameters.AddWithValue("@id", secilenId);



                DialogResult result = MessageBox.Show("Kayıt güncellensin mi?", "Kayıt Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    VeriGetir();
                }


            }
        }

      

        private void FormListe_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }
    }

}
