using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPSI2
{
    public partial class FAjout : Form
    {
        public FAjout()
        {
            InitializeComponent();
            Nom.Enabled = false;
            Prenom.Enabled = false;
            Section.Enabled = false;
            Groupe.Enabled = false;
            AjoutB.Enabled = false;
        }

        private void Matricule_Click(object sender, EventArgs e)
        {
            if (Matricule.Text.Equals("Matricule"))
                Matricule.Text = "";
        }

        private void Nom_Click(object sender, EventArgs e)
        {
            if (Nom.Text.Equals("Nom Etudiant"))
                Nom.Text = "";
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            if (Prenom.Text.Equals("Prenom Etudiant"))
                Prenom.Text = "";
        }

        private void materialSingleLineTextField4_Click(object sender, EventArgs e)
        {
            if (Section.Text.Equals("Section"))
                Section.Text = "";
        }

        private void Groupe_Click(object sender, EventArgs e)
        {
            if (Groupe.Text.Equals("Groupe"))
                Groupe.Text = "";
        }
    }
}
