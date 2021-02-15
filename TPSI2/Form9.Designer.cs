
namespace TPSI2
{
    partial class FModifM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Coeff = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Nom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AnnulerB = new MaterialSkin.Controls.MaterialFlatButton();
            this.RechercherB = new MaterialSkin.Controls.MaterialFlatButton();
            this.ModifB = new MaterialSkin.Controls.MaterialFlatButton();
            this.CM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Prof = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // Coeff
            // 
            this.Coeff.Depth = 0;
            this.Coeff.Hint = "";
            this.Coeff.Location = new System.Drawing.Point(400, 136);
            this.Coeff.MouseState = MaterialSkin.MouseState.HOVER;
            this.Coeff.Name = "Coeff";
            this.Coeff.PasswordChar = '\0';
            this.Coeff.SelectedText = "";
            this.Coeff.SelectionLength = 0;
            this.Coeff.SelectionStart = 0;
            this.Coeff.Size = new System.Drawing.Size(205, 23);
            this.Coeff.TabIndex = 31;
            this.Coeff.Text = "Coefficient";
            this.Coeff.UseSystemPasswordChar = false;
            this.Coeff.Click += new System.EventHandler(this.Coeff_Click);
            // 
            // Nom
            // 
            this.Nom.Depth = 0;
            this.Nom.Hint = "";
            this.Nom.Location = new System.Drawing.Point(33, 136);
            this.Nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.Nom.Name = "Nom";
            this.Nom.PasswordChar = '\0';
            this.Nom.SelectedText = "";
            this.Nom.SelectionLength = 0;
            this.Nom.SelectionStart = 0;
            this.Nom.Size = new System.Drawing.Size(205, 23);
            this.Nom.TabIndex = 30;
            this.Nom.Text = "Nom Module";
            this.Nom.UseSystemPasswordChar = false;
            this.Nom.Click += new System.EventHandler(this.Nom_Click);
            // 
            // AnnulerB
            // 
            this.AnnulerB.AutoSize = true;
            this.AnnulerB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AnnulerB.Depth = 0;
            this.AnnulerB.Location = new System.Drawing.Point(431, 299);
            this.AnnulerB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AnnulerB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnnulerB.Name = "AnnulerB";
            this.AnnulerB.Primary = false;
            this.AnnulerB.Size = new System.Drawing.Size(73, 36);
            this.AnnulerB.TabIndex = 29;
            this.AnnulerB.Text = "Annuler";
            this.AnnulerB.UseVisualStyleBackColor = true;
            // 
            // RechercherB
            // 
            this.RechercherB.AutoSize = true;
            this.RechercherB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RechercherB.Depth = 0;
            this.RechercherB.Location = new System.Drawing.Point(108, 299);
            this.RechercherB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RechercherB.MouseState = MaterialSkin.MouseState.HOVER;
            this.RechercherB.Name = "RechercherB";
            this.RechercherB.Primary = false;
            this.RechercherB.Size = new System.Drawing.Size(98, 36);
            this.RechercherB.TabIndex = 28;
            this.RechercherB.Text = "Rechercher";
            this.RechercherB.UseVisualStyleBackColor = true;
            // 
            // ModifB
            // 
            this.ModifB.AutoSize = true;
            this.ModifB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModifB.Depth = 0;
            this.ModifB.Location = new System.Drawing.Point(281, 299);
            this.ModifB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ModifB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModifB.Name = "ModifB";
            this.ModifB.Primary = false;
            this.ModifB.Size = new System.Drawing.Size(74, 36);
            this.ModifB.TabIndex = 27;
            this.ModifB.Text = "Modifier";
            this.ModifB.UseVisualStyleBackColor = true;
            // 
            // CM
            // 
            this.CM.Depth = 0;
            this.CM.Hint = "";
            this.CM.Location = new System.Drawing.Point(212, 56);
            this.CM.MouseState = MaterialSkin.MouseState.HOVER;
            this.CM.Name = "CM";
            this.CM.PasswordChar = '\0';
            this.CM.SelectedText = "";
            this.CM.SelectionLength = 0;
            this.CM.SelectionStart = 0;
            this.CM.Size = new System.Drawing.Size(205, 23);
            this.CM.TabIndex = 26;
            this.CM.Text = "Code Module";
            this.CM.UseSystemPasswordChar = false;
            this.CM.Click += new System.EventHandler(this.CM_Click);
            // 
            // Prof
            // 
            this.Prof.Depth = 0;
            this.Prof.Hint = "";
            this.Prof.Location = new System.Drawing.Point(212, 219);
            this.Prof.MouseState = MaterialSkin.MouseState.HOVER;
            this.Prof.Name = "Prof";
            this.Prof.PasswordChar = '\0';
            this.Prof.SelectedText = "";
            this.Prof.SelectionLength = 0;
            this.Prof.SelectionStart = 0;
            this.Prof.Size = new System.Drawing.Size(205, 23);
            this.Prof.TabIndex = 25;
            this.Prof.Text = "Enseignant";
            this.Prof.UseSystemPasswordChar = false;
            this.Prof.Click += new System.EventHandler(this.Prof_Click);
            // 
            // FModifM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(655, 388);
            this.Controls.Add(this.Coeff);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.AnnulerB);
            this.Controls.Add(this.RechercherB);
            this.Controls.Add(this.ModifB);
            this.Controls.Add(this.CM);
            this.Controls.Add(this.Prof);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FModifM";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Coeff;
        private MaterialSkin.Controls.MaterialSingleLineTextField Nom;
        private MaterialSkin.Controls.MaterialFlatButton AnnulerB;
        private MaterialSkin.Controls.MaterialFlatButton RechercherB;
        private MaterialSkin.Controls.MaterialFlatButton ModifB;
        private MaterialSkin.Controls.MaterialSingleLineTextField CM;
        private MaterialSkin.Controls.MaterialSingleLineTextField Prof;
    }
}