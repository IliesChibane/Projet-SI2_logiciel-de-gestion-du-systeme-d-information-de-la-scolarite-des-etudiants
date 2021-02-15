
namespace TPSI2
{
    partial class FAjoutM
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
            this.AnnulerB = new MaterialSkin.Controls.MaterialFlatButton();
            this.RechercherB = new MaterialSkin.Controls.MaterialFlatButton();
            this.AjoutB = new MaterialSkin.Controls.MaterialFlatButton();
            this.CM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Prof = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Coeff = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Nom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // AnnulerB
            // 
            this.AnnulerB.AutoSize = true;
            this.AnnulerB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AnnulerB.Depth = 0;
            this.AnnulerB.Location = new System.Drawing.Point(434, 318);
            this.AnnulerB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AnnulerB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnnulerB.Name = "AnnulerB";
            this.AnnulerB.Primary = false;
            this.AnnulerB.Size = new System.Drawing.Size(73, 36);
            this.AnnulerB.TabIndex = 22;
            this.AnnulerB.Text = "Annuler";
            this.AnnulerB.UseVisualStyleBackColor = true;
            // 
            // RechercherB
            // 
            this.RechercherB.AutoSize = true;
            this.RechercherB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RechercherB.Depth = 0;
            this.RechercherB.Location = new System.Drawing.Point(111, 318);
            this.RechercherB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RechercherB.MouseState = MaterialSkin.MouseState.HOVER;
            this.RechercherB.Name = "RechercherB";
            this.RechercherB.Primary = false;
            this.RechercherB.Size = new System.Drawing.Size(98, 36);
            this.RechercherB.TabIndex = 21;
            this.RechercherB.Text = "Rechercher";
            this.RechercherB.UseVisualStyleBackColor = true;
            // 
            // AjoutB
            // 
            this.AjoutB.AutoSize = true;
            this.AjoutB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AjoutB.Depth = 0;
            this.AjoutB.Location = new System.Drawing.Point(284, 318);
            this.AjoutB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AjoutB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AjoutB.Name = "AjoutB";
            this.AjoutB.Primary = false;
            this.AjoutB.Size = new System.Drawing.Size(72, 36);
            this.AjoutB.TabIndex = 20;
            this.AjoutB.Text = "Ajouter";
            this.AjoutB.UseVisualStyleBackColor = true;
            // 
            // CM
            // 
            this.CM.Depth = 0;
            this.CM.Hint = "";
            this.CM.Location = new System.Drawing.Point(215, 75);
            this.CM.MouseState = MaterialSkin.MouseState.HOVER;
            this.CM.Name = "CM";
            this.CM.PasswordChar = '\0';
            this.CM.SelectedText = "";
            this.CM.SelectionLength = 0;
            this.CM.SelectionStart = 0;
            this.CM.Size = new System.Drawing.Size(205, 23);
            this.CM.TabIndex = 19;
            this.CM.Text = "Code Module";
            this.CM.UseSystemPasswordChar = false;
            this.CM.Click += new System.EventHandler(this.CM_Click);
            // 
            // Prof
            // 
            this.Prof.Depth = 0;
            this.Prof.Hint = "";
            this.Prof.Location = new System.Drawing.Point(215, 238);
            this.Prof.MouseState = MaterialSkin.MouseState.HOVER;
            this.Prof.Name = "Prof";
            this.Prof.PasswordChar = '\0';
            this.Prof.SelectedText = "";
            this.Prof.SelectionLength = 0;
            this.Prof.SelectionStart = 0;
            this.Prof.Size = new System.Drawing.Size(205, 23);
            this.Prof.TabIndex = 18;
            this.Prof.Text = "Enseignant";
            this.Prof.UseSystemPasswordChar = false;
            this.Prof.Click += new System.EventHandler(this.Prof_Click);
            // 
            // Coeff
            // 
            this.Coeff.Depth = 0;
            this.Coeff.Hint = "";
            this.Coeff.Location = new System.Drawing.Point(403, 155);
            this.Coeff.MouseState = MaterialSkin.MouseState.HOVER;
            this.Coeff.Name = "Coeff";
            this.Coeff.PasswordChar = '\0';
            this.Coeff.SelectedText = "";
            this.Coeff.SelectionLength = 0;
            this.Coeff.SelectionStart = 0;
            this.Coeff.Size = new System.Drawing.Size(205, 23);
            this.Coeff.TabIndex = 24;
            this.Coeff.Text = "Coefficient";
            this.Coeff.UseSystemPasswordChar = false;
            this.Coeff.Click += new System.EventHandler(this.Coeff_Click);
            // 
            // Nom
            // 
            this.Nom.Depth = 0;
            this.Nom.Hint = "";
            this.Nom.Location = new System.Drawing.Point(36, 155);
            this.Nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.Nom.Name = "Nom";
            this.Nom.PasswordChar = '\0';
            this.Nom.SelectedText = "";
            this.Nom.SelectionLength = 0;
            this.Nom.SelectionStart = 0;
            this.Nom.Size = new System.Drawing.Size(205, 23);
            this.Nom.TabIndex = 23;
            this.Nom.Text = "Nom Module";
            this.Nom.UseSystemPasswordChar = false;
            this.Nom.Click += new System.EventHandler(this.Nom_Click);
            // 
            // FAjoutM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(655, 388);
            this.Controls.Add(this.Coeff);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.AnnulerB);
            this.Controls.Add(this.RechercherB);
            this.Controls.Add(this.AjoutB);
            this.Controls.Add(this.CM);
            this.Controls.Add(this.Prof);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAjoutM";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton AnnulerB;
        private MaterialSkin.Controls.MaterialFlatButton RechercherB;
        private MaterialSkin.Controls.MaterialFlatButton AjoutB;
        private MaterialSkin.Controls.MaterialSingleLineTextField CM;
        private MaterialSkin.Controls.MaterialSingleLineTextField Prof;
        private MaterialSkin.Controls.MaterialSingleLineTextField Coeff;
        private MaterialSkin.Controls.MaterialSingleLineTextField Nom;
    }
}