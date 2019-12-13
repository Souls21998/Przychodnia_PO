namespace Przychodnia_PO
{
    partial class Form_menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_przejdz_pacjent = new System.Windows.Forms.Button();
            this.btn_przejdz_lekarz = new System.Windows.Forms.Button();
            this.btn_zamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_przejdz_pacjent
            // 
            this.btn_przejdz_pacjent.Location = new System.Drawing.Point(158, 72);
            this.btn_przejdz_pacjent.Name = "btn_przejdz_pacjent";
            this.btn_przejdz_pacjent.Size = new System.Drawing.Size(191, 64);
            this.btn_przejdz_pacjent.TabIndex = 0;
            this.btn_przejdz_pacjent.Text = "PACJENT";
            this.btn_przejdz_pacjent.UseVisualStyleBackColor = true;
            this.btn_przejdz_pacjent.Click += new System.EventHandler(this.btn_przejdz_pacjent_Click);
            // 
            // btn_przejdz_lekarz
            // 
            this.btn_przejdz_lekarz.Location = new System.Drawing.Point(158, 142);
            this.btn_przejdz_lekarz.Name = "btn_przejdz_lekarz";
            this.btn_przejdz_lekarz.Size = new System.Drawing.Size(191, 64);
            this.btn_przejdz_lekarz.TabIndex = 1;
            this.btn_przejdz_lekarz.Text = "LEKARZ";
            this.btn_przejdz_lekarz.UseVisualStyleBackColor = true;
            this.btn_przejdz_lekarz.Click += new System.EventHandler(this.btn_przejdz_lekarz_Click);
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Location = new System.Drawing.Point(158, 238);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.Size = new System.Drawing.Size(191, 64);
            this.btn_zamknij.TabIndex = 2;
            this.btn_zamknij.Text = "ZAMKNIJ";
            this.btn_zamknij.UseVisualStyleBackColor = true;
            this.btn_zamknij.Click += new System.EventHandler(this.btn_zamknij_Click);
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 450);
            this.Controls.Add(this.btn_zamknij);
            this.Controls.Add(this.btn_przejdz_lekarz);
            this.Controls.Add(this.btn_przejdz_pacjent);
            this.Name = "Form_menu";
            this.Text = "Form_menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_przejdz_pacjent;
        private System.Windows.Forms.Button btn_przejdz_lekarz;
        private System.Windows.Forms.Button btn_zamknij;
    }
}

