
namespace TPSI2
{
    partial class FSuppM
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
            this.SuppB = new MaterialSkin.Controls.MaterialFlatButton();
            this.CM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Prof = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // Coeff
            // 
            this.Coeff.Depth = 0;
            this.Coeff.Hint = "";
            this.Coeff.Location = new System.Drawing.Point(401, 141);
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
            // 
            // Nom
            // 
            this.Nom.Depth = 0;
            this.Nom.Hint = "";
            this.Nom.Location = new System.Drawing.Point(34, 141);
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
            // 
            // AnnulerB
            // 
            this.AnnulerB.AutoSize = true;
            this.AnnulerB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AnnulerB.Depth = 0;
            this.AnnulerB.Location = new System.Drawing.Point(432, 304);
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
            this.RechercherB.Location = new System.Drawing.Point(109, 304);
            this.RechercherB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RechercherB.MouseState = MaterialSkin.MouseState.HOVER;
            this.RechercherB.Name = "RechercherB";
            this.RechercherB.Primary = false;
            this.RechercherB.Size = new System.Drawing.Size(98, 36);
            this.RechercherB.TabIndex = 28;
            this.RechercherB.Text = "Rechercher";
            this.RechercherB.UseVisualStyleBackColor = true;
            // 
            // SuppB
            // 
            this.SuppB.AutoSize = true;
            this.SuppB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SuppB.Depth = 0;
            this.SuppB.Location = new System.Drawing.Point(282, 304);
            this.SuppB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SuppB.MouseState = MaterialSkin.MouseState.HOVER;
            this.SuppB.Name = "SuppB";
            this.SuppB.Primary = false;
            this.SuppB.Size = new System.Drawing.Size(88, 36);
            this.SuppB.TabIndex = 27;
            this.SuppB.Text = "Supprimer";
            this.SuppB.UseVisualStyleBackColor = true;
            // 
            // CM
            // 
            this.CM.Depth = 0;
            this.CM.Hint = "";
            this.CM.Location = new System.Drawing.Point(213, 61);
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
            this.Prof.Location = new System.Drawing.Point(213, 224);
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
            // 
            // FSuppM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(655, 388);
            this.Controls.Add(this.Coeff);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.AnnulerB);
            this.Controls.Add(this.RechercherB);
            this.Controls.Add(this.SuppB);
            this.Controls.Add(this.CM);
            this.Controls.Add(this.Prof);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSuppM";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Coeff;
        private MaterialSkin.Controls.MaterialSingleLineTextField Nom;
        private MaterialSkin.Controls.MaterialFlatButton AnnulerB;
        private MaterialSkin.Controls.MaterialFlatButton RechercherB;
        private MaterialSkin.Controls.MaterialFlatButton SuppB;
        private MaterialSkin.Controls.MaterialSingleLineTextField CM;
        private MaterialSkin.Controls.MaterialSingleLineTextField Prof;
    }
}