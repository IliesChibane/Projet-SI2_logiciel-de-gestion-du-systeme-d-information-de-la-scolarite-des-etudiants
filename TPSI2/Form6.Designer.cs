
namespace TPSI2
{
    partial class FSupp
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
            this.Nom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AnnulerB = new MaterialSkin.Controls.MaterialFlatButton();
            this.RechercherB = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuprimB = new MaterialSkin.Controls.MaterialFlatButton();
            this.Matricule = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Groupe = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Section = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Prenom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.Depth = 0;
            this.Nom.Hint = "";
            this.Nom.Location = new System.Drawing.Point(60, 119);
            this.Nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.Nom.Name = "Nom";
            this.Nom.PasswordChar = '\0';
            this.Nom.SelectedText = "";
            this.Nom.SelectionLength = 0;
            this.Nom.SelectionStart = 0;
            this.Nom.Size = new System.Drawing.Size(205, 23);
            this.Nom.TabIndex = 22;
            this.Nom.Text = "Nom Etudiant";
            this.Nom.UseSystemPasswordChar = false;
            // 
            // AnnulerB
            // 
            this.AnnulerB.AutoSize = true;
            this.AnnulerB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AnnulerB.Depth = 0;
            this.AnnulerB.Location = new System.Drawing.Point(427, 319);
            this.AnnulerB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AnnulerB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnnulerB.Name = "AnnulerB";
            this.AnnulerB.Primary = false;
            this.AnnulerB.Size = new System.Drawing.Size(73, 36);
            this.AnnulerB.TabIndex = 21;
            this.AnnulerB.Text = "Annuler";
            this.AnnulerB.UseVisualStyleBackColor = true;
            // 
            // RechercherB
            // 
            this.RechercherB.AutoSize = true;
            this.RechercherB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RechercherB.Depth = 0;
            this.RechercherB.Location = new System.Drawing.Point(104, 319);
            this.RechercherB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RechercherB.MouseState = MaterialSkin.MouseState.HOVER;
            this.RechercherB.Name = "RechercherB";
            this.RechercherB.Primary = false;
            this.RechercherB.Size = new System.Drawing.Size(98, 36);
            this.RechercherB.TabIndex = 20;
            this.RechercherB.Text = "Rechercher";
            this.RechercherB.UseVisualStyleBackColor = true;
            // 
            // SuprimB
            // 
            this.SuprimB.AutoSize = true;
            this.SuprimB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SuprimB.Depth = 0;
            this.SuprimB.Location = new System.Drawing.Point(279, 319);
            this.SuprimB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SuprimB.MouseState = MaterialSkin.MouseState.HOVER;
            this.SuprimB.Name = "SuprimB";
            this.SuprimB.Primary = false;
            this.SuprimB.Size = new System.Drawing.Size(88, 36);
            this.SuprimB.TabIndex = 19;
            this.SuprimB.Text = "Supprimer";
            this.SuprimB.UseVisualStyleBackColor = true;
            // 
            // Matricule
            // 
            this.Matricule.Depth = 0;
            this.Matricule.Hint = "";
            this.Matricule.Location = new System.Drawing.Point(224, 50);
            this.Matricule.MouseState = MaterialSkin.MouseState.HOVER;
            this.Matricule.Name = "Matricule";
            this.Matricule.PasswordChar = '\0';
            this.Matricule.SelectedText = "";
            this.Matricule.SelectionLength = 0;
            this.Matricule.SelectionStart = 0;
            this.Matricule.Size = new System.Drawing.Size(205, 23);
            this.Matricule.TabIndex = 18;
            this.Matricule.Text = "Matricule";
            this.Matricule.UseSystemPasswordChar = false;
            this.Matricule.Click += new System.EventHandler(this.Matricule_Click);
            // 
            // Groupe
            // 
            this.Groupe.Depth = 0;
            this.Groupe.Hint = "";
            this.Groupe.Location = new System.Drawing.Point(382, 244);
            this.Groupe.MouseState = MaterialSkin.MouseState.HOVER;
            this.Groupe.Name = "Groupe";
            this.Groupe.PasswordChar = '\0';
            this.Groupe.SelectedText = "";
            this.Groupe.SelectionLength = 0;
            this.Groupe.SelectionStart = 0;
            this.Groupe.Size = new System.Drawing.Size(205, 23);
            this.Groupe.TabIndex = 17;
            this.Groupe.Text = "Groupe";
            this.Groupe.UseSystemPasswordChar = false;
            // 
            // Section
            // 
            this.Section.Depth = 0;
            this.Section.Hint = "";
            this.Section.Location = new System.Drawing.Point(60, 244);
            this.Section.MouseState = MaterialSkin.MouseState.HOVER;
            this.Section.Name = "Section";
            this.Section.PasswordChar = '\0';
            this.Section.SelectedText = "";
            this.Section.SelectionLength = 0;
            this.Section.SelectionStart = 0;
            this.Section.Size = new System.Drawing.Size(205, 23);
            this.Section.TabIndex = 16;
            this.Section.Text = "Section";
            this.Section.UseSystemPasswordChar = false;
            // 
            // Prenom
            // 
            this.Prenom.Depth = 0;
            this.Prenom.Hint = "";
            this.Prenom.Location = new System.Drawing.Point(382, 119);
            this.Prenom.MouseState = MaterialSkin.MouseState.HOVER;
            this.Prenom.Name = "Prenom";
            this.Prenom.PasswordChar = '\0';
            this.Prenom.SelectedText = "";
            this.Prenom.SelectionLength = 0;
            this.Prenom.SelectionStart = 0;
            this.Prenom.Size = new System.Drawing.Size(205, 23);
            this.Prenom.TabIndex = 15;
            this.Prenom.Text = "Prenom Etudiant";
            this.Prenom.UseSystemPasswordChar = false;
            // 
            // FSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(655, 388);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.AnnulerB);
            this.Controls.Add(this.RechercherB);
            this.Controls.Add(this.SuprimB);
            this.Controls.Add(this.Matricule);
            this.Controls.Add(this.Groupe);
            this.Controls.Add(this.Section);
            this.Controls.Add(this.Prenom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSupp";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Nom;
        private MaterialSkin.Controls.MaterialFlatButton AnnulerB;
        private MaterialSkin.Controls.MaterialFlatButton RechercherB;
        private MaterialSkin.Controls.MaterialFlatButton SuprimB;
        private MaterialSkin.Controls.MaterialSingleLineTextField Matricule;
        private MaterialSkin.Controls.MaterialSingleLineTextField Groupe;
        private MaterialSkin.Controls.MaterialSingleLineTextField Section;
        private MaterialSkin.Controls.MaterialSingleLineTextField Prenom;
    }
}