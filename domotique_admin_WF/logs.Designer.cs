namespace domotique_admin_WF
{
    partial class logs
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
            this.module_log = new System.Windows.Forms.DataGridView();
            this.ligne_supp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.module_log)).BeginInit();
            this.SuspendLayout();
            // 
            // module_log
            // 
            this.module_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.module_log.Location = new System.Drawing.Point(12, 12);
            this.module_log.Name = "module_log";
            this.module_log.Size = new System.Drawing.Size(962, 399);
            this.module_log.TabIndex = 0;
            // 
            // ligne_supp
            // 
            this.ligne_supp.Location = new System.Drawing.Point(873, 428);
            this.ligne_supp.Name = "ligne_supp";
            this.ligne_supp.Size = new System.Drawing.Size(101, 23);
            this.ligne_supp.TabIndex = 1;
            this.ligne_supp.Text = "Supprimer ligne";
            this.ligne_supp.UseVisualStyleBackColor = true;
            this.ligne_supp.Click += new System.EventHandler(this.ligne_supp_Click);
            // 
            // logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 463);
            this.Controls.Add(this.ligne_supp);
            this.Controls.Add(this.module_log);
            this.Name = "logs";
            this.Text = "Modules";
            this.Load += new System.EventHandler(this.modules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.module_log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView module_log;
        private System.Windows.Forms.Button ligne_supp;
    }
}