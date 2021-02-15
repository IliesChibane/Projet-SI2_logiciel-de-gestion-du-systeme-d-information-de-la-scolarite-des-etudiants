
namespace TPSI2
{
    partial class Authentifiation
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pseudo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MDP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.erreurCO = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // Pseudo
            // 
            this.Pseudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.Pseudo.Depth = 0;
            this.Pseudo.ForeColor = System.Drawing.Color.LightGray;
            this.Pseudo.Hint = "";
            this.Pseudo.Location = new System.Drawing.Point(38, 124);
            this.Pseudo.MouseState = MaterialSkin.MouseState.HOVER;
            this.Pseudo.Name = "Pseudo";
            this.Pseudo.PasswordChar = '\0';
            this.Pseudo.SelectedText = "";
            this.Pseudo.SelectionLength = 0;
            this.Pseudo.SelectionStart = 0;
            this.Pseudo.Size = new System.Drawing.Size(197, 23);
            this.Pseudo.TabIndex = 0;
            this.Pseudo.Text = "Nom Utilisateur";
            this.Pseudo.UseSystemPasswordChar = false;
            this.Pseudo.Click += new System.EventHandler(this.Pseudo_Click);
            // 
            // MDP
            // 
            this.MDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.MDP.Depth = 0;
            this.MDP.ForeColor = System.Drawing.Color.LightGray;
            this.MDP.Hint = "";
            this.MDP.Location = new System.Drawing.Point(38, 193);
            this.MDP.MouseState = MaterialSkin.MouseState.HOVER;
            this.MDP.Name = "MDP";
            this.MDP.PasswordChar = '\0';
            this.MDP.SelectedText = "";
            this.MDP.SelectionLength = 0;
            this.MDP.SelectionStart = 0;
            this.MDP.Size = new System.Drawing.Size(197, 23);
            this.MDP.TabIndex = 1;
            this.MDP.Text = "Mot De Passe";
            this.MDP.UseSystemPasswordChar = false;
            this.MDP.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.ForeColor = System.Drawing.Color.LightGray;
            this.ConnectButton.Location = new System.Drawing.Point(83, 276);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(114, 36);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connection";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // erreurCO
            // 
            this.erreurCO.AutoSize = true;
            this.erreurCO.Depth = 0;
            this.erreurCO.Font = new System.Drawing.Font("Roboto", 11F);
            this.erreurCO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.erreurCO.Location = new System.Drawing.Point(89, 333);
            this.erreurCO.MouseState = MaterialSkin.MouseState.HOVER;
            this.erreurCO.Name = "erreurCO";
            this.erreurCO.Size = new System.Drawing.Size(0, 19);
            this.erreurCO.TabIndex = 3;
            // 
            // Authentifiation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.erreurCO);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.MDP);
            this.Controls.Add(this.Pseudo);
            this.Name = "Authentifiation";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Pseudo;
        private MaterialSkin.Controls.MaterialSingleLineTextField MDP;
        private System.Windows.Forms.Button ConnectButton;
        private MaterialSkin.Controls.MaterialLabel erreurCO;
    }
}

