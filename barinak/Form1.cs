using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barinak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            FormListe formListe = new FormListe();
            formListe.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FormEkle formekle = new FormEkle();
            formekle.ShowDialog();
        }
    }
}
