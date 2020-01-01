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
            this.btn_zamknij = new System.Windows.Forms.Button();
            this.btn_dane_pacjentow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_przejdz_autorzy = new System.Windows.Forms.Button();
            this.btn_przejdz_zarzadzaj_przychodnia = new System.Windows.Forms.Button();
            this.btn_run_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_zamknij.FlatAppearance.BorderSize = 0;
            this.btn_zamknij.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_zamknij.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_zamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zamknij.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_zamknij.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_zamknij.Location = new System.Drawing.Point(12, 268);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.Size = new System.Drawing.Size(558, 44);
            this.btn_zamknij.TabIndex = 2;
            this.btn_zamknij.Text = "Zamknij";
            this.btn_zamknij.UseVisualStyleBackColor = true;
            this.btn_zamknij.Click += new System.EventHandler(this.btn_zamknij_Click);
            // 
            // btn_dane_pacjentow
            // 
            this.btn_dane_pacjentow.Location = new System.Drawing.Point(161, 462);
            this.btn_dane_pacjentow.Name = "btn_dane_pacjentow";
            this.btn_dane_pacjentow.Size = new System.Drawing.Size(152, 25);
            this.btn_dane_pacjentow.TabIndex = 3;
            this.btn_dane_pacjentow.Text = "DANE PACJENTOW";
            this.btn_dane_pacjentow.UseVisualStyleBackColor = true;
            this.btn_dane_pacjentow.Click += new System.EventHandler(this.btn_dane_pacjentow_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("MV Boli", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chorzy Doktorzy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(0, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(582, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "- PRZYCHODNIA -";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_przejdz_autorzy
            // 
            this.btn_przejdz_autorzy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_przejdz_autorzy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_przejdz_autorzy.FlatAppearance.BorderSize = 0;
            this.btn_przejdz_autorzy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_przejdz_autorzy.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_przejdz_autorzy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_przejdz_autorzy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_przejdz_autorzy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_przejdz_autorzy.Location = new System.Drawing.Point(12, 218);
            this.btn_przejdz_autorzy.Name = "btn_przejdz_autorzy";
            this.btn_przejdz_autorzy.Size = new System.Drawing.Size(558, 44);
            this.btn_przejdz_autorzy.TabIndex = 6;
            this.btn_przejdz_autorzy.Text = "Autorzy";
            this.btn_przejdz_autorzy.UseVisualStyleBackColor = true;
            this.btn_przejdz_autorzy.Click += new System.EventHandler(this.btn_przejdz_autorzy_Click);
            // 
            // btn_przejdz_zarzadzaj_przychodnia
            // 
            this.btn_przejdz_zarzadzaj_przychodnia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_przejdz_zarzadzaj_przychodnia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_przejdz_zarzadzaj_przychodnia.FlatAppearance.BorderSize = 0;
            this.btn_przejdz_zarzadzaj_przychodnia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_przejdz_zarzadzaj_przychodnia.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_przejdz_zarzadzaj_przychodnia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_przejdz_zarzadzaj_przychodnia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_przejdz_zarzadzaj_przychodnia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_przejdz_zarzadzaj_przychodnia.Location = new System.Drawing.Point(12, 168);
            this.btn_przejdz_zarzadzaj_przychodnia.Name = "btn_przejdz_zarzadzaj_przychodnia";
            this.btn_przejdz_zarzadzaj_przychodnia.Size = new System.Drawing.Size(558, 44);
            this.btn_przejdz_zarzadzaj_przychodnia.TabIndex = 8;
            this.btn_przejdz_zarzadzaj_przychodnia.Text = "Zarządzaj przychodnią";
            this.btn_przejdz_zarzadzaj_przychodnia.UseVisualStyleBackColor = true;
            this.btn_przejdz_zarzadzaj_przychodnia.Click += new System.EventHandler(this.btn_przejdz_zarzadzaj_przychodnia_Click);
            // 
            // btn_run_test
            // 
            this.btn_run_test.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_run_test.FlatAppearance.BorderSize = 0;
            this.btn_run_test.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_run_test.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_run_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_run_test.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_run_test.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_run_test.Location = new System.Drawing.Point(6, 118);
            this.btn_run_test.Name = "btn_run_test";
            this.btn_run_test.Size = new System.Drawing.Size(558, 44);
            this.btn_run_test.TabIndex = 9;
            this.btn_run_test.Text = "!! Załaduj testowe dane !!";
            this.btn_run_test.UseVisualStyleBackColor = true;
            this.btn_run_test.Click += new System.EventHandler(this.btn_run_test_Click);
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.btn_run_test);
            this.Controls.Add(this.btn_przejdz_zarzadzaj_przychodnia);
            this.Controls.Add(this.btn_przejdz_autorzy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dane_pacjentow);
            this.Controls.Add(this.btn_zamknij);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRZYCHODNIA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_zamknij;
        private System.Windows.Forms.Button btn_dane_pacjentow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_przejdz_autorzy;
        private System.Windows.Forms.Button btn_przejdz_zarzadzaj_przychodnia;
        private System.Windows.Forms.Button btn_run_test;
    }
}

