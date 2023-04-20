using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            Con = new Functions();
            AfficherPhones();
        }
        private void AfficherPhones()
        {
            string Req = " select * from PhoneTable";
            PhonesListe.DataSource = Con.RecupererData(Req);
        }
        Functions Con;
        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            if (NomZT.Text == "" || ModelZT.Text == "" || PrixZT.Text == "" || QteZT.Text == "" || CouleurZT.Text == "")
            {
                MessageBox.Show("information incomplète");
            }
            else
            {
                try
                {
                    string Nom = NomZT.Text;
                    string Model = ModelZT.Text;
                    int Qte = Convert.ToInt32(QteZT.Text);
                    int Prix = Convert.ToInt32(PrixZT.Text);
                    string Couleur = CouleurZT.Text;
                    string Req = "insert INTO PhoneTable values ('{0}','{1}', {2}, {3}, '{4}')";
                    Req = string.Format(Req, Nom, Model, Prix, Qte, Couleur);
                    Con.EnvoyerData(Req);
                    MessageBox.Show("Téléphone ajouté");
                    AfficherPhones();
                    NomZT.Text = "";
                    ModelZT.Text = "";
                    PrixZT.Text = "";
                    QteZT.Text = "";
                    CouleurZT.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }
        int Cle = 0;
        private void PhonesListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Vérifier si la ligne est valide
            {
                DataGridViewRow row = PhonesListe.Rows[e.RowIndex];
                NomZT.Text = row.Cells[1].Value.ToString();
                ModelZT.Text = row.Cells[2].Value.ToString();
                PrixZT.Text = row.Cells[3].Value.ToString();
                QteZT.Text = row.Cells[4].Value.ToString();
                CouleurZT.Text = row.Cells[5].Value.ToString();
                if (NomZT.Text == "")
                {
                    Cle = 0;
                }
                else
                {
                    Cle = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            if (Cle == 0)
            {
                MessageBox.Show("information incomplète");
            }
            else
            {
                try
                {
                    string Nom = NomZT.Text;
                    string Model = ModelZT.Text;
                    int Qte = Convert.ToInt32(QteZT.Text);
                    int Prix = Convert.ToInt32(PrixZT.Text);
                    string Couleur = CouleurZT.Text;
                    string Req = "Delete from PhoneTable where PCode = {0}";
                    Req = string.Format(Req, Cle);
                    Con.EnvoyerData(Req);
                    MessageBox.Show("Téléphone Supprimé");
                    AfficherPhones();
                    NomZT.Text = "";
                    ModelZT.Text = "";
                    PrixZT.Text = "";
                    QteZT.Text = "";
                    CouleurZT.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            if (NomZT.Text == "" || ModelZT.Text == "" || PrixZT.Text == "" || QteZT.Text == "" || CouleurZT.Text == "")
            {
                MessageBox.Show("information incomplète");
            }
            else
            {
                try
                {
                    string Nom = NomZT.Text;
                    string Model = ModelZT.Text;
                    int Qte = Convert.ToInt32(QteZT.Text);
                    int Prix = Convert.ToInt32(PrixZT.Text);
                    string Couleur = CouleurZT.Text;
                    string Req = "Update PhoneTable set PMarque = '{0}',PModele= '{1}',Prix = {2},PQte = {3},PCouleur = '{4}' where PCode = {5}";
                    Req = string.Format(Req, Nom, Model, Prix, Qte, Couleur, Cle);
                    Con.EnvoyerData(Req);
                    MessageBox.Show("Téléphone modifié");
                    AfficherPhones();
                    NomZT.Text = "";
                    ModelZT.Text = "";
                    PrixZT.Text = "";
                    QteZT.Text = "";
                    CouleurZT.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shop Obj = new Shop();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu Obj = new Menu();
            Obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Facture Obj = new Facture();
            Obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Accessoires Obj = new Accessoires();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
