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
    public partial class FModule : Form
    {
        public FModule()
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
            ToolModulePanel.Controls.Add(child);
            ToolModulePanel.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void AjoutBouton_Click(object sender, EventArgs e)
        {
            openChildForm(new FAjoutM());
        }

        private void ModifierB_Click(object sender, EventArgs e)
        {
            openChildForm(new FModifM());
        }

        private void SuppM_Click(object sender, EventArgs e)
        {
            openChildForm(new FSuppM());
        }
    }
}
