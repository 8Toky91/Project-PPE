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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void ConnecterBtn_Click(object sender, EventArgs e)
        {
            if (NomUtZT.Text == "" || MotPasseZT.Text == "")
            {
                MessageBox.Show("Info Incomplete");
            }
            else if (NomUtZT.Text == "Admin" && MotPasseZT.Text == "Admin")
            {
                Employé Obj = new Employé();
                Obj.Show();
                this.Hide();
            }
            else
            {
                NomUtZT.Text = "";
                MotPasseZT.Text = "";
                MessageBox.Show("Mot de passe ou nom d'utilisateur incorrecte");
            }
        }

        private void NomUtZT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
