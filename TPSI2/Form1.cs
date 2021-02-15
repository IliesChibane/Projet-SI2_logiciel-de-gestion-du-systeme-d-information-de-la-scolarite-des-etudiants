using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPSI2.Classe;

namespace TPSI2
{
    public partial class Authentifiation : Form
    {
        private int TentativeConnection = 0;
        public Authentifiation()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            String nom = Pseudo.Text.Substring(0, Pseudo.Text.IndexOf('.'));
            String prenom = Pseudo.Text.Substring(Pseudo.Text.IndexOf('.') + 1);
            String query = "Select * From utilisateur where Nom = '" + nom + "' and Prenom = '"+prenom+"' and MotDePasse = '" + MDP.Text + "'";
            MySqlCommand msc = new MySqlCommand(query, BDConnect.conect);
            try
            {
                BDConnect.conect.Open();
                MySqlDataReader msdr = msc.ExecuteReader();
                if (msdr.Read())
                {
                    this.Hide();
                    MenuPrincipale m = new MenuPrincipale();
                    m.Show();
                }
                else
                {
                    erreurCO.Refresh();
                    erreurCO.Text = "Nom d'utilisateur ou mot de passe invalide";
                    TentativeConnection++;
                }
                if (TentativeConnection == 3)
                {
                    FermerConnection();
                    //timer();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FermerConnection()
        {
            Pseudo.Enabled = false;
            MDP.Enabled = false;
            int a = erreurCO.Text.Length;
            erreurCO.Refresh();
            Pseudo.Text = "";
            MDP.Text = "";
            erreurCO.Text = "Vous avez échoué à vous connecter à 3 reprises\n\tVeuillez re essayer utlterieurment";

        }

        private void Pseudo_Click(object sender, EventArgs e)
        {
            if (Pseudo.Text.Equals("Nom Utilisateur"))
                Pseudo.Text = "";
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            if (MDP.Text.Equals("Mot De Passe"))
                MDP.Text = "";
            MDP.PasswordChar = '*';
        }
    }
}
