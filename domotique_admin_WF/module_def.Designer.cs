namespace domotique_admin_WF
{
    partial class module_def
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
            this.module__list_def = new System.Windows.Forms.DataGridView();
            this.Supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.module__list_def)).BeginInit();
            this.SuspendLayout();
            // 
            // module__list_def
            // 
            this.module__list_def.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.module__list_def.Location = new System.Drawing.Point(12, 12);
            this.module__list_def.Name = "module__list_def";
            this.module__list_def.Size = new System.Drawing.Size(653, 212);
            this.module__list_def.TabIndex = 0;
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(590, 230);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Supprimer.TabIndex = 1;
            this.Supprimer.Text = "Appliquer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // module_def
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 265);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.module__list_def);
            this.Name = "module_def";
            this.Text = "module_def";
            this.Load += new System.EventHandler(this.module_def_Load);
            ((System.ComponentModel.ISupportInitialize)(this.module__list_def)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView module__list_def;
        private System.Windows.Forms.Button Supprimer;
    }
}