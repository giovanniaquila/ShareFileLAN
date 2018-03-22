namespace ShareFileLAN
{
    partial class Form1
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

            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxVisibilità = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 635);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(466, 117);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            this.checkBoxVisibilità.AutoSize = true;
            this.checkBoxVisibilità.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVisibilità.Location = new System.Drawing.Point(1064, 66);
            this.checkBoxVisibilità.Name = "checkBoxVisibilità";
            this.checkBoxVisibilità.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxVisibilità.Size = new System.Drawing.Size(222, 29);
            this.checkBoxVisibilità.TabIndex = 1;
            this.checkBoxVisibilità.Text = "Visibile agli altri utenti";
            this.checkBoxVisibilità.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxVisibilità.UseVisualStyleBackColor = true;
            this.checkBoxVisibilità.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1328, 799);
            this.Controls.Add(this.checkBoxVisibilità);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "ShareFileLAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxVisibilità;
    }
}

