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
    public partial class FAjoutM : Form
    {
        public FAjoutM()
        {
            InitializeComponent();
            Nom.Enabled = false;
            Coeff.Enabled = false;
            Prof.Enabled = false;
            AjoutB.Enabled = false;
        }

        private void CM_Click(object sender, EventArgs e)
        {
            if (CM.Text.Equals("Code Module"))
                CM.Text = "";
        }

        private void Prof_Click(object sender, EventArgs e)
        {
            if (Prof.Text.Equals("Enseignant"))
                Prof.Text = "";
        }

        private void Coeff_Click(object sender, EventArgs e)
        {
            if (Coeff.Text.Equals("Coefficient"))
                Coeff.Text = "";
        }

        private void Nom_Click(object sender, EventArgs e)
        {
            if (Nom.Text.Equals("Nom Module"))
                Nom.Text = "";
        }
    }
}
