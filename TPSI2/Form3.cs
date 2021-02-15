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
    public partial class FETUDIANT : Form
    {
        public FETUDIANT()
        {
            InitializeComponent();
        }

        private Form ActiveForm = null;
        private void openChildForm(Form child)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            ToolPanelEtudiant.Controls.Add(child);
            ToolPanelEtudiant.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void AjoutBouton_Click(object sender, EventArgs e)
        {
            openChildForm(new FAjout());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FModif());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FSupp());
        }
    }
}
