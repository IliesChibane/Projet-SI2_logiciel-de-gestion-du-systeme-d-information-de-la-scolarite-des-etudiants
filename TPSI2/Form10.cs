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
    public partial class FSuppM : Form
    {
        public FSuppM()
        {
            InitializeComponent();
            Nom.Enabled = false;
            Coeff.Enabled = false;
            Prof.Enabled = false;
            SuppB.Enabled = false;
        }

        private void CM_Click(object sender, EventArgs e)
        {
            if (CM.Text.Equals("Code Module"))
                CM.Text = "";
        }
    }
}
