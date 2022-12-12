namespace Speech
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtText = new System.Windows.Forms.TextBox();
            this.BtnActivate = new System.Windows.Forms.Button();
            this.BtnDeactivate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtText
            // 
            this.TxtText.Location = new System.Drawing.Point(12, 71);
            this.TxtText.Name = "TxtText";
            this.TxtText.Size = new System.Drawing.Size(458, 22);
            this.TxtText.TabIndex = 0;
            // 
            // BtnActivate
            // 
            this.BtnActivate.Location = new System.Drawing.Point(13, 100);
            this.BtnActivate.Name = "BtnActivate";
            this.BtnActivate.Size = new System.Drawing.Size(75, 23);
            this.BtnActivate.TabIndex = 1;
            this.BtnActivate.Text = "Activate";
            this.BtnActivate.UseVisualStyleBackColor = true;
            this.BtnActivate.Click += new System.EventHandler(this.BtnActivate_Click);
            // 
            // BtnDeactivate
            // 
            this.BtnDeactivate.Location = new System.Drawing.Point(388, 100);
            this.BtnDeactivate.Name = "BtnDeactivate";
            this.BtnDeactivate.Size = new System.Drawing.Size(82, 23);
            this.BtnDeactivate.TabIndex = 2;
            this.BtnDeactivate.Text = "Deactivate";
            this.BtnDeactivate.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.BtnDeactivate);
            this.Controls.Add(this.BtnActivate);
            this.Controls.Add(this.TxtText);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtText;
        private System.Windows.Forms.Button BtnActivate;
        private System.Windows.Forms.Button BtnDeactivate;
    }
}

