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
    public partial class Employé : Form
    {
        public Employé()
        {
            InitializeComponent();
            Con = new Functions();
            AfficherUser();
        }


        private void AfficherUser()
        {
            string Req = "select * from UserTbl";
            UserListe.DataSource = Con.RecupererData(Req);
        }

        Functions Con;

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            if (NomUtZT.Text == "" || MdpZT.Text == "")
            {
                MessageBox.Show("information incomplète");
            }
            else
            {
                try
                {
                    string NomUt = NomUtZT.Text;
                    string Mdp = MdpZT.Text;
                    string Req = "INSERT INTO [UserTbl] (NomUt, Mdp) VALUES ('{0}','{1}')";
                    Req = string.Format(Req, NomUt, Mdp);
                    Con.EnvoyerData(Req);
                    MessageBox.Show("Utilisateur ajouté");
                    AfficherUser();
                    NomUtZT.Text = "";
                    MdpZT.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Cle = 0;

        private void UserListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Vérifier si la ligne est valide
            {
                DataGridViewRow row = UserListe.Rows[e.RowIndex];
                NomUtZT.Text = row.Cells[1].Value.ToString();
                MdpZT.Text = row.Cells[2].Value.ToString();
                if (NomUtZT.Text == "")
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
                    string NomUT = NomUtZT.Text;
                    string Mdp = MdpZT.Text;
                    string Req = "Delete from UserTbl where id = {0}";
                    Req = string.Format(Req, Cle);
                    Con.EnvoyerData(Req);
                    MessageBox.Show("Utilisateur Supprimé");
                    AfficherUser();
                    NomUtZT.Text = "";
                    MdpZT.Text = "";

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            if (NomUtZT.Text == "" || MdpZT.Text == "")
            {
                MessageBox.Show("information incomplète");
            }
            else
            {
                try
                {
                    string NomUt = NomUtZT.Text;
                    string Mdp = MdpZT.Text;
                    string Req = "Update UserTbl set NomUt = '{0}',Mdp = '{1}' where id = {2}";
                    Req = string.Format(Req, NomUt, Mdp, Cle);
                    Con.EnvoyerData(Req);
                    MessageBox.Show("Utilisateur modifié");
                    AfficherUser();
                    NomUtZT.Text = "";
                    MdpZT.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NomUtZT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu Obj = new Menu();
            Obj.Show();
            this.Hide();
        }
    }
}
