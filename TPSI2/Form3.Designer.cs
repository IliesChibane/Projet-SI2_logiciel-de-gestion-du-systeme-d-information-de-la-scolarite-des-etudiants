
namespace TPSI2
{
    partial class FETUDIANT
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
            this.EtudiantTools = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.AjoutBouton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.ToolPanelEtudiant = new System.Windows.Forms.Panel();
            this.EtudiantTools.SuspendLayout();
            this.ToolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EtudiantTools
            // 
            this.EtudiantTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.EtudiantTools.Controls.Add(this.button2);
            this.EtudiantTools.Controls.Add(this.AjoutBouton);
            this.EtudiantTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.EtudiantTools.Location = new System.Drawing.Point(0, 0);
            this.EtudiantTools.Name = "EtudiantTools";
            this.EtudiantTools.Size = new System.Drawing.Size(655, 62);
            this.EtudiantTools.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(437, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "Depart";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AjoutBouton
            // 
            this.AjoutBouton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.AjoutBouton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AjoutBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjoutBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AjoutBouton.ForeColor = System.Drawing.Color.LightGray;
            this.AjoutBouton.Location = new System.Drawing.Point(0, 0);
            this.AjoutBouton.Name = "AjoutBouton";
            this.AjoutBouton.Size = new System.Drawing.Size(218, 62);
            this.AjoutBouton.TabIndex = 1;
            this.AjoutBouton.Text = "Inscription";
            this.AjoutBouton.UseVisualStyleBackColor = false;
            this.AjoutBouton.Click += new System.EventHandler(this.AjoutBouton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(218, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Changement Section/Groupe";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ToolPanel
            // 
            this.ToolPanel.Controls.Add(this.ToolPanelEtudiant);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolPanel.Location = new System.Drawing.Point(0, 62);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(655, 388);
            this.ToolPanel.TabIndex = 3;
            // 
            // ToolPanelEtudiant
            // 
            this.ToolPanelEtudiant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolPanelEtudiant.Location = new System.Drawing.Point(0, 0);
            this.ToolPanelEtudiant.Name = "ToolPanelEtudiant";
            this.ToolPanelEtudiant.Size = new System.Drawing.Size(655, 388);
            this.ToolPanelEtudiant.TabIndex = 0;
            // 
            // FETUDIANT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.ToolPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EtudiantTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FETUDIANT";
            this.Text = "Form3";
            this.EtudiantTools.ResumeLayout(false);
            this.ToolPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EtudiantTools;
        private System.Windows.Forms.Button AjoutBouton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Panel ToolPanelEtudiant;
    }
}