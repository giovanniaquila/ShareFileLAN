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
            this.CheckBoxVisibilità = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(621, 146);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckBoxVisibilità
            // 
            this.CheckBoxVisibilità.AutoSize = true;
            this.CheckBoxVisibilità.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxVisibilità.Location = new System.Drawing.Point(869, 82);
            this.CheckBoxVisibilità.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxVisibilità.Name = "CheckBoxVisibilità";
            this.CheckBoxVisibilità.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBoxVisibilità.Size = new System.Drawing.Size(306, 35);
            this.CheckBoxVisibilità.TabIndex = 1;
            this.CheckBoxVisibilità.Text = "Visibile agli altri utenti";
            this.CheckBoxVisibilità.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CheckBoxVisibilità.UseVisualStyleBackColor = true;
            this.CheckBoxVisibilità.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 506);
            this.Controls.Add(this.CheckBoxVisibilità);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "ShareFileLAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CheckBoxVisibilità;
    }
}

