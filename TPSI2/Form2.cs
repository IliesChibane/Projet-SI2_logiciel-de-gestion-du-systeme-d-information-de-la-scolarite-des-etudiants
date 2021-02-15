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
    public partial class MenuPrincipale : Form
    {
        public MenuPrincipale()
        {
            InitializeComponent();
            InitSubMenu();
        }

        private void InitSubMenu()
        {
            EtatsSubPanel.Visible = false;
            panel3.Visible = false;
        }

        private void HideSubMenu()
        {
            if (EtatsSubPanel.Visible == true)
                EtatsSubPanel.Visible = false;
            if (panel3.Visible == true)
                panel3.Visible = false;
        }

        private void ShowSubMenu(Panel SubPanel)
        {
            if(SubPanel.Visible == false)
            {
                HideSubMenu();
                SubPanel.Visible = true;
            }
            else
            {
                SubPanel.Visible = false;
            }
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
            MainPanel.Controls.Add(child);
            MainPanel.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void MajButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel3);
        }

        private void EtatsButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(EtatsSubPanel);
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Authentifiation a = new Authentifiation();
            a.Show();
            this.Close();
        }

        private void EtudiantButton_Click(object sender, EventArgs e)
        {
            openChildForm(new FETUDIANT());
        }

        private void ModuleButton_Click(object sender, EventArgs e)
        {
            openChildForm(new FModule());
        }
    }
}
