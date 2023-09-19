namespace calcolatore
{
    partial class CALCULATOR
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRisultato = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblRisultato
            // 
            this.lblRisultato.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRisultato.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRisultato.Location = new System.Drawing.Point(0, 42);
            this.lblRisultato.Margin = new System.Windows.Forms.Padding(0);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(320, 66);
            this.lblRisultato.TabIndex = 0;
            this.lblRisultato.Text = "0";
            this.lblRisultato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(320, 42);
            this.panelTop.TabIndex = 1;
            // 
            // CALCULATOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 477);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CALCULATOR";
            this.Text = "CALCULATOR";
            this.Load += new System.EventHandler(this.CALCULATOR_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.Panel panelTop;
    }
}

