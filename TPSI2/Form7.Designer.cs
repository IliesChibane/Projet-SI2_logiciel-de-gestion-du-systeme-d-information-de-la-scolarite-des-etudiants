
namespace TPSI2
{
    partial class FModule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuppM = new System.Windows.Forms.Button();
            this.ModifierB = new System.Windows.Forms.Button();
            this.AjoutBouton = new System.Windows.Forms.Button();
            this.ToolModulePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SuppM);
            this.panel1.Controls.Add(this.ModifierB);
            this.panel1.Controls.Add(this.AjoutBouton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 62);
            this.panel1.TabIndex = 0;
            // 
            // SuppM
            // 
            this.SuppM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SuppM.Dock = System.Windows.Forms.DockStyle.Right;
            this.SuppM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuppM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuppM.ForeColor = System.Drawing.Color.LightGray;
            this.SuppM.Location = new System.Drawing.Point(437, 0);
            this.SuppM.Name = "SuppM";
            this.SuppM.Size = new System.Drawing.Size(218, 62);
            this.SuppM.TabIndex = 6;
            this.SuppM.Text = "Supprimer Module";
            this.SuppM.UseVisualStyleBackColor = false;
            this.SuppM.Click += new System.EventHandler(this.SuppM_Click);
            // 
            // ModifierB
            // 
            this.ModifierB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ModifierB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifierB.ForeColor = System.Drawing.Color.LightGray;
            this.ModifierB.Location = new System.Drawing.Point(218, 0);
            this.ModifierB.Name = "ModifierB";
            this.ModifierB.Size = new System.Drawing.Size(218, 62);
            this.ModifierB.TabIndex = 5;
            this.ModifierB.Text = "Changement Section/Groupe";
            this.ModifierB.UseVisualStyleBackColor = false;
            this.ModifierB.Click += new System.EventHandler(this.ModifierB_Click);
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
            this.AjoutBouton.TabIndex = 4;
            this.AjoutBouton.Text = "Nouveau Module";
            this.AjoutBouton.UseVisualStyleBackColor = false;
            this.AjoutBouton.Click += new System.EventHandler(this.AjoutBouton_Click);
            // 
            // ToolModulePanel
            // 
            this.ToolModulePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolModulePanel.Location = new System.Drawing.Point(0, 62);
            this.ToolModulePanel.Name = "ToolModulePanel";
            this.ToolModulePanel.Size = new System.Drawing.Size(655, 388);
            this.ToolModulePanel.TabIndex = 1;
            // 
            // FModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.ToolModulePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FModule";
            this.Text = "Form7";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SuppM;
        private System.Windows.Forms.Button ModifierB;
        private System.Windows.Forms.Button AjoutBouton;
        private System.Windows.Forms.Panel ToolModulePanel;
    }
}