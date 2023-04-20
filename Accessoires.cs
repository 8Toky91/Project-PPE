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
    public partial class Accessoires : Form
    {
        public Accessoires()
        {
            InitializeComponent();
            Con = new Functions();
            AfficherAccessoires();
        }



        private void AfficherAccessoires()
        {
            string Req = " select * from AccessoireTbl";
            AccessoiresListe.DataSource = Con.RecupererData(Req);
        }
        Functions Con;
       
        int Cle = 0;
        private void AccessoiresListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Vérifier si la ligne est valide
            {
                DataGridViewRow row = AccessoiresListe.Rows[e.RowIndex];
                TypeZT.Text = row.Cells[1].Value.ToString();
                MarqueZT.Text = row.Cells[2].Value.ToString();
                ModelZT.Text = row.Cells[3].Value.ToString();
                PrixZT.Text = row.Cells[4].Value.ToString();
                QteZT.Text = row.Cells[5].Value.ToString();
                if (TypeZT.Text == "")
                {
                    Cle = 0;
                }
                else
                {
                    Cle = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }

        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            if (TypeZT.Text == "" || MarqueZT.Text == "" || ModelZT.Text == "" || PrixZT.Text == "" || QteZT.Text == "")
            {
                MessageBox.Show("information incomplète");
            }
            else
            {
                try
                {
                    string Type = TypeZT.Text;
                    string Marque = MarqueZT.Text;
                    string Modele = ModelZT.Text;
                    int Qte = Convert.ToInt32(QteZT.Text);
                    int Prix = Convert.ToInt32(PrixZT.Text);
                    string Req = "INSERT INTO AccessoireTbl (AcNom, AcMarque, AcModel, AcPrix, AcQte) VALUES ('{0}', '{1}', '{2}', {3}, {4})";

                    Req = string.Format(Req, Type, Marque, Modele, Prix, Qte);
                    Con.EnvoyerData(Req);
                    MessageBox.Show("Accessoire ajouté");
                    AfficherAccessoires();
                    TypeZT.Text = "";
                    MarqueZT.Text = "";
                    ModelZT.Text = "";
                    PrixZT.Text = "";
                    QteZT.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
        


            }
        }
        private void AccessoiresListe_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Vérifier si la ligne est valide
            {
                DataGridViewRow row = AccessoiresListe.Rows[e.RowIndex];
                TypeZT.Text = row.Cells[1].Value.ToString();
                MarqueZT.Text = row.Cells[2].Value.ToString();
                ModelZT.Text = row.Cells[3].Value.ToString();
                PrixZT.Text = row.Cells[4].Value.ToString();
                QteZT.Text = row.Cells[5].Value.ToString();
                if (TypeZT.Text == "")
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
                    string Type = TypeZT.Text;
                    string Marque = MarqueZT.Text;
                    string Modele = ModelZT.Text;
                    int Qte = Convert.ToInt32(QteZT.Text);
                    int Prix = Convert.ToInt32(PrixZT.Text);
                    string Req = "Delete from AccessoireTbl where AcCode = {0}";
                    Req = string.Format(Req, Cle);
                    Con.EnvoyerData(Req);
                    MessageBox.Show("Accessoire Supprimé");
                    AfficherAccessoires();
                    TypeZT.Text = "";
                    MarqueZT.Text = "";
                    ModelZT.Text = "";
                    PrixZT.Text = "";
                    QteZT.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            if (TypeZT.Text == "" || MarqueZT.Text == "" || ModelZT.Text == "" || PrixZT.Text == "" || QteZT.Text == "")
            {
                MessageBox.Show("information incomplète");
            }
            else
            {
                try
                {
                    string Type = TypeZT.Text;
                    string Marque = MarqueZT.Text;
                    string Modele = ModelZT.Text;
                    int Qte = Convert.ToInt32(QteZT.Text);
                    int Prix = Convert.ToInt32(PrixZT.Text);
                    string Req = "Update AccessoireTbl set AcNom = '{0}',AcMarque = '{1}',AcModel = '{2}',AcPrix = {3},AcQte = '{4}' where AcCode = {5}";
                    Req = string.Format(Req, Type, Marque, Modele, Prix, Qte, Cle);
                    Con.EnvoyerData(Req);
                    MessageBox.Show("Accessoire modifié");
                    AfficherAccessoires();
                    TypeZT.Text = "";
                    MarqueZT.Text = "";
                    ModelZT.Text = "";
                    PrixZT.Text = "";
                    QteZT.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
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

