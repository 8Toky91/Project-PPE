using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Facture : Form
    {
        Functions Con;
        public Facture()
        {
            InitializeComponent();
            Con = new Functions();
            AfficherFacture();
        }

        private void AfficherFacture()
        {
            string Req = " select * from FactureTbl";
            FactureListe.DataSource = Con.RecupererData(Req);
        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            if (DateZT.Value == null || MontantZT.Text == "")
            {
                MessageBox.Show("information incomplète");
            }
            else
            {
                try
                {
                    string FDate = DateZT.Value.ToString("yyyy-MM-dd");
                    string Phone = PhoneZT.Text;
                    string Accessoire = AccessoireZT.Text;
                    string Montant = MontantZT.Text;
                    string Req = "insert INTO FactureTbl values ('{0}','{1}','{2}','{3}')";
                    Req = string.Format(Req, FDate, Phone, Accessoire, Montant);
                    Con.EnvoyerData(Req);
                    MessageBox.Show("Facture ajouté");
                    AfficherFacture();
                    DateZT.Value = DateTime.Now;
                    PhoneZT.Text = "";
                    AccessoireZT.Text = "";
                    MontantZT.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Cle = 0;
        private void FactureListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Vérifier si la ligne est valide
            {
                DataGridViewRow row = FactureListe.Rows[e.RowIndex];
                DateZT.Value = DateTime.Parse(row.Cells["FDate"].Value.ToString());
                PhoneZT.Text = row.Cells["Phone"].Value.ToString();
                AccessoireZT.Text = row.Cells["Accessoire"].Value.ToString();
                MontantZT.Text = row.Cells["Montant"].Value.ToString();
                if (row.Cells["FCode"].Value.ToString() == "")
                {
                    Cle = 0;
                }
                else
                {
                    Cle = Convert.ToInt32(row.Cells["FCode"].Value.ToString());
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu Obj = new Menu();
            Obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shop Obj = new Shop();
            Obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Accessoires Obj = new Accessoires();
            Obj.Show();
            this.Hide();
        }
    }
}

