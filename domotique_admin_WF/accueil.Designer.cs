namespace domotique_admin_WF
{
    partial class accueil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLesModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLesTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLesUnitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesEmplacementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definirLesModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modesToolStripMenuItem,
            this.gererLesModulesToolStripMenuItem,
            this.sensorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modesToolStripMenuItem
            // 
            this.modesToolStripMenuItem.Name = "modesToolStripMenuItem";
            this.modesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.modesToolStripMenuItem.Text = "modules logs";
            this.modesToolStripMenuItem.Click += new System.EventHandler(this.modesToolStripMenuItem_Click);
            // 
            // gererLesModulesToolStripMenuItem
            // 
            this.gererLesModulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definirLesModulesToolStripMenuItem,
            this.lesEmplacementsToolStripMenuItem});
            this.gererLesModulesToolStripMenuItem.Name = "gererLesModulesToolStripMenuItem";
            this.gererLesModulesToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.gererLesModulesToolStripMenuItem.Text = "Gerrer les modules";
            // 
            // sensorToolStripMenuItem
            // 
            this.sensorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererLesTypesToolStripMenuItem,
            this.gererLesUnitésToolStripMenuItem});
            this.sensorToolStripMenuItem.Name = "sensorToolStripMenuItem";
            this.sensorToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.sensorToolStripMenuItem.Text = "Gerer les sondes";
            // 
            // gererLesTypesToolStripMenuItem
            // 
            this.gererLesTypesToolStripMenuItem.Name = "gererLesTypesToolStripMenuItem";
            this.gererLesTypesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.gererLesTypesToolStripMenuItem.Text = "gerer les types";
            // 
            // gererLesUnitésToolStripMenuItem
            // 
            this.gererLesUnitésToolStripMenuItem.Name = "gererLesUnitésToolStripMenuItem";
            this.gererLesUnitésToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.gererLesUnitésToolStripMenuItem.Text = "gerer les unités";
            // 
            // lesEmplacementsToolStripMenuItem
            // 
            this.lesEmplacementsToolStripMenuItem.Name = "lesEmplacementsToolStripMenuItem";
            this.lesEmplacementsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.lesEmplacementsToolStripMenuItem.Text = "Les emplacements";
            // 
            // definirLesModulesToolStripMenuItem
            // 
            this.definirLesModulesToolStripMenuItem.Name = "definirLesModulesToolStripMenuItem";
            this.definirLesModulesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.definirLesModulesToolStripMenuItem.Text = "Definir les modules";
            this.definirLesModulesToolStripMenuItem.Click += new System.EventHandler(this.definirLesModulesToolStripMenuItem_Click);
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 597);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "accueil";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLesModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLesTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLesUnitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definirLesModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesEmplacementsToolStripMenuItem;
    }
}

