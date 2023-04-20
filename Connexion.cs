using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{

    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void ConnecterBtn_Click(object sender, EventArgs e)
        {
                string nomUtilisateur = NomUtZT.Text;
                string motDePasse = MotPasseZT.Text;

                if (nomUtilisateur == "" || motDePasse == "")
                {
                    MessageBox.Show("Info Incomplete");
                }
                else
                {
                    Functions fonctions = new Functions();
                    DataTable dt = fonctions.RecupererData("SELECT * FROM UserTbl WHERE NomUt='" + nomUtilisateur + "' AND Mdp='" + motDePasse + "'");
                    if (dt.Rows.Count == 1)
                    {
                        Menu Obj = new Menu();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        NomUtZT.Text = "";
                        MotPasseZT.Text = "";
                        MessageBox.Show("Mot de passe ou nom d'utilisateur incorrect");
                    }
                }
            

        }


        private void label7_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(); 
            admin.Show(); 
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}