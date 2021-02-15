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
    public partial class FSupp : Form
    {
        public FSupp()
        {
            InitializeComponent();
            Nom.Enabled = false;
            Prenom.Enabled = false;
            Section.Enabled = false;
            Groupe.Enabled = false;
            SuprimB.Enabled = false;
        }

        private void Matricule_Click(object sender, EventArgs e)
        {
            if (Matricule.Text.Equals("Matricule"))
                Matricule.Text = "";
        }
    }
}
