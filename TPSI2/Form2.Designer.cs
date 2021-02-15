
namespace TPSI2
{
    partial class MenuPrincipale
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
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.Quitter = new System.Windows.Forms.Button();
            this.EtatsSubPanel = new System.Windows.Forms.Panel();
            this.BDNButton = new System.Windows.Forms.Button();
            this.LEButton = new System.Windows.Forms.Button();
            this.CDSButton = new System.Windows.Forms.Button();
            this.EtatsButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExamenButton = new System.Windows.Forms.Button();
            this.ModuleButton = new System.Windows.Forms.Button();
            this.EtudiantButton = new System.Windows.Forms.Button();
            this.MajButton = new System.Windows.Forms.Button();
            this.ProfilPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel.SuspendLayout();
            this.EtatsSubPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.AutoScroll = true;
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(17)))));
            this.ButtonPanel.Controls.Add(this.Quitter);
            this.ButtonPanel.Controls.Add(this.EtatsSubPanel);
            this.ButtonPanel.Controls.Add(this.EtatsButton);
            this.ButtonPanel.Controls.Add(this.panel3);
            this.ButtonPanel.Controls.Add(this.MajButton);
            this.ButtonPanel.Controls.Add(this.ProfilPanel);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(161, 450);
            this.ButtonPanel.TabIndex = 0;
            // 
            // Quitter
            // 
            this.Quitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Quitter.FlatAppearance.BorderSize = 0;
            this.Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quitter.ForeColor = System.Drawing.Color.LightGray;
            this.Quitter.Location = new System.Drawing.Point(0, 359);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(161, 40);
            this.Quitter.TabIndex = 7;
            this.Quitter.Text = "  Quitter";
            this.Quitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // EtatsSubPanel
            // 
            this.EtatsSubPanel.BackColor = System.Drawing.Color.Silver;
            this.EtatsSubPanel.Controls.Add(this.BDNButton);
            this.EtatsSubPanel.Controls.Add(this.LEButton);
            this.EtatsSubPanel.Controls.Add(this.CDSButton);
            this.EtatsSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EtatsSubPanel.Location = new System.Drawing.Point(0, 270);
            this.EtatsSubPanel.Name = "EtatsSubPanel";
            this.EtatsSubPanel.Size = new System.Drawing.Size(161, 89);
            this.EtatsSubPanel.TabIndex = 6;
            // 
            // BDNButton
            // 
            this.BDNButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.BDNButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BDNButton.FlatAppearance.BorderSize = 0;
            this.BDNButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDNButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDNButton.ForeColor = System.Drawing.Color.LightGray;
            this.BDNButton.Location = new System.Drawing.Point(0, 60);
            this.BDNButton.Name = "BDNButton";
            this.BDNButton.Size = new System.Drawing.Size(161, 30);
            this.BDNButton.TabIndex = 9;
            this.BDNButton.Text = "   Bulletin de note";
            this.BDNButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BDNButton.UseVisualStyleBackColor = false;
            // 
            // LEButton
            // 
            this.LEButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.LEButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEButton.FlatAppearance.BorderSize = 0;
            this.LEButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LEButton.ForeColor = System.Drawing.Color.LightGray;
            this.LEButton.Location = new System.Drawing.Point(0, 30);
            this.LEButton.Name = "LEButton";
            this.LEButton.Size = new System.Drawing.Size(161, 30);
            this.LEButton.TabIndex = 8;
            this.LEButton.Text = "   Liste Etduiant";
            this.LEButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LEButton.UseVisualStyleBackColor = false;
            // 
            // CDSButton
            // 
            this.CDSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.CDSButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CDSButton.FlatAppearance.BorderSize = 0;
            this.CDSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CDSButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CDSButton.ForeColor = System.Drawing.Color.LightGray;
            this.CDSButton.Location = new System.Drawing.Point(0, 0);
            this.CDSButton.Name = "CDSButton";
            this.CDSButton.Size = new System.Drawing.Size(161, 30);
            this.CDSButton.TabIndex = 7;
            this.CDSButton.Text = "   Certifcat de scolarite";
            this.CDSButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CDSButton.UseVisualStyleBackColor = false;
            // 
            // EtatsButton
            // 
            this.EtatsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EtatsButton.FlatAppearance.BorderSize = 0;
            this.EtatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EtatsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EtatsButton.ForeColor = System.Drawing.Color.LightGray;
            this.EtatsButton.Location = new System.Drawing.Point(0, 230);
            this.EtatsButton.Name = "EtatsButton";
            this.EtatsButton.Size = new System.Drawing.Size(161, 40);
            this.EtatsButton.TabIndex = 5;
            this.EtatsButton.Text = "  Etats";
            this.EtatsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EtatsButton.UseVisualStyleBackColor = true;
            this.EtatsButton.Click += new System.EventHandler(this.EtatsButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.ExamenButton);
            this.panel3.Controls.Add(this.ModuleButton);
            this.panel3.Controls.Add(this.EtudiantButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 90);
            this.panel3.TabIndex = 2;
            // 
            // ExamenButton
            // 
            this.ExamenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ExamenButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExamenButton.FlatAppearance.BorderSize = 0;
            this.ExamenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExamenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExamenButton.ForeColor = System.Drawing.Color.LightGray;
            this.ExamenButton.Location = new System.Drawing.Point(0, 60);
            this.ExamenButton.Name = "ExamenButton";
            this.ExamenButton.Size = new System.Drawing.Size(161, 30);
            this.ExamenButton.TabIndex = 2;
            this.ExamenButton.Text = "   Examen";
            this.ExamenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExamenButton.UseVisualStyleBackColor = false;
            // 
            // ModuleButton
            // 
            this.ModuleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ModuleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ModuleButton.FlatAppearance.BorderSize = 0;
            this.ModuleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModuleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModuleButton.ForeColor = System.Drawing.Color.LightGray;
            this.ModuleButton.Location = new System.Drawing.Point(0, 30);
            this.ModuleButton.Name = "ModuleButton";
            this.ModuleButton.Size = new System.Drawing.Size(161, 30);
            this.ModuleButton.TabIndex = 1;
            this.ModuleButton.Text = "   Module";
            this.ModuleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModuleButton.UseVisualStyleBackColor = false;
            this.ModuleButton.Click += new System.EventHandler(this.ModuleButton_Click);
            // 
            // EtudiantButton
            // 
            this.EtudiantButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.EtudiantButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EtudiantButton.FlatAppearance.BorderSize = 0;
            this.EtudiantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EtudiantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EtudiantButton.ForeColor = System.Drawing.Color.LightGray;
            this.EtudiantButton.Location = new System.Drawing.Point(0, 0);
            this.EtudiantButton.Name = "EtudiantButton";
            this.EtudiantButton.Size = new System.Drawing.Size(161, 30);
            this.EtudiantButton.TabIndex = 0;
            this.EtudiantButton.Text = "   Etudiant";
            this.EtudiantButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EtudiantButton.UseVisualStyleBackColor = false;
            this.EtudiantButton.Click += new System.EventHandler(this.EtudiantButton_Click);
            // 
            // MajButton
            // 
            this.MajButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MajButton.FlatAppearance.BorderSize = 0;
            this.MajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MajButton.ForeColor = System.Drawing.Color.LightGray;
            this.MajButton.Location = new System.Drawing.Point(0, 100);
            this.MajButton.Name = "MajButton";
            this.MajButton.Size = new System.Drawing.Size(161, 40);
            this.MajButton.TabIndex = 1;
            this.MajButton.Text = "  Mise a jour";
            this.MajButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MajButton.UseVisualStyleBackColor = true;
            this.MajButton.Click += new System.EventHandler(this.MajButton_Click);
            // 
            // ProfilPanel
            // 
            this.ProfilPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfilPanel.Location = new System.Drawing.Point(0, 0);
            this.ProfilPanel.Name = "ProfilPanel";
            this.ProfilPanel.Size = new System.Drawing.Size(161, 100);
            this.ProfilPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(161, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(655, 450);
            this.MainPanel.TabIndex = 1;
            // 
            // MenuPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ButtonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(816, 450);
            this.Name = "MenuPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ButtonPanel.ResumeLayout(false);
            this.EtatsSubPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ExamenButton;
        private System.Windows.Forms.Button ModuleButton;
        private System.Windows.Forms.Button EtudiantButton;
        private System.Windows.Forms.Button MajButton;
        private System.Windows.Forms.Panel ProfilPanel;
        private System.Windows.Forms.Button EtatsButton;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Panel EtatsSubPanel;
        private System.Windows.Forms.Button BDNButton;
        private System.Windows.Forms.Button LEButton;
        private System.Windows.Forms.Button CDSButton;
        private System.Windows.Forms.Panel MainPanel;
    }
}