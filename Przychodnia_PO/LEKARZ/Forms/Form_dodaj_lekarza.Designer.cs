namespace Przychodnia_PO
{
    partial class Form_dodaj_lekarza
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_wstecz = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.label_nr_telefonu = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_nazwisko = new System.Windows.Forms.Label();
            this.lb_imie = new System.Windows.Forms.Label();
            this.tB_nr_telefonu = new System.Windows.Forms.TextBox();
            this.tB_id = new System.Windows.Forms.TextBox();
            this.tB_nazwisko = new System.Windows.Forms.TextBox();
            this.tB_imie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_wiek = new System.Windows.Forms.TextBox();
            this.comboBox_specjalizacja = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 48);
            this.label2.TabIndex = 25;
            this.label2.Text = "Dodaj nowego lekarza";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wstecz.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_wstecz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_wstecz.Location = new System.Drawing.Point(76, 267);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(160, 35);
            this.btn_wstecz.TabIndex = 24;
            this.btn_wstecz.Text = "Wstecz";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dodaj.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_dodaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_dodaj.Location = new System.Drawing.Point(242, 267);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(160, 35);
            this.btn_dodaj.TabIndex = 23;
            this.btn_dodaj.Text = "Dodaj lekarza";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // label_nr_telefonu
            // 
            this.label_nr_telefonu.AutoSize = true;
            this.label_nr_telefonu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_nr_telefonu.Location = new System.Drawing.Point(72, 173);
            this.label_nr_telefonu.Name = "label_nr_telefonu";
            this.label_nr_telefonu.Size = new System.Drawing.Size(124, 19);
            this.label_nr_telefonu.TabIndex = 22;
            this.label_nr_telefonu.Text = "Numer telefonu";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.lb_id.Location = new System.Drawing.Point(72, 59);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(27, 19);
            this.lb_id.TabIndex = 20;
            this.lb_id.Text = "ID";
            // 
            // lb_nazwisko
            // 
            this.lb_nazwisko.AutoSize = true;
            this.lb_nazwisko.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.lb_nazwisko.Location = new System.Drawing.Point(72, 115);
            this.lb_nazwisko.Name = "lb_nazwisko";
            this.lb_nazwisko.Size = new System.Drawing.Size(79, 19);
            this.lb_nazwisko.TabIndex = 19;
            this.lb_nazwisko.Text = "Nazwisko";
            // 
            // lb_imie
            // 
            this.lb_imie.AutoSize = true;
            this.lb_imie.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_imie.Location = new System.Drawing.Point(72, 87);
            this.lb_imie.Name = "lb_imie";
            this.lb_imie.Size = new System.Drawing.Size(43, 19);
            this.lb_imie.TabIndex = 18;
            this.lb_imie.Text = "Imię";
            // 
            // tB_nr_telefonu
            // 
            this.tB_nr_telefonu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_nr_telefonu.Location = new System.Drawing.Point(213, 170);
            this.tB_nr_telefonu.Name = "tB_nr_telefonu";
            this.tB_nr_telefonu.Size = new System.Drawing.Size(200, 22);
            this.tB_nr_telefonu.TabIndex = 17;
            // 
            // tB_id
            // 
            this.tB_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_id.Location = new System.Drawing.Point(213, 58);
            this.tB_id.Name = "tB_id";
            this.tB_id.Size = new System.Drawing.Size(200, 22);
            this.tB_id.TabIndex = 15;
            // 
            // tB_nazwisko
            // 
            this.tB_nazwisko.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_nazwisko.Location = new System.Drawing.Point(213, 114);
            this.tB_nazwisko.Name = "tB_nazwisko";
            this.tB_nazwisko.Size = new System.Drawing.Size(200, 22);
            this.tB_nazwisko.TabIndex = 14;
            // 
            // tB_imie
            // 
            this.tB_imie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_imie.Location = new System.Drawing.Point(213, 86);
            this.tB_imie.Name = "tB_imie";
            this.tB_imie.Size = new System.Drawing.Size(200, 22);
            this.tB_imie.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(72, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Specjalizacja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(72, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Wiek";
            // 
            // tB_wiek
            // 
            this.tB_wiek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_wiek.Location = new System.Drawing.Point(213, 142);
            this.tB_wiek.Name = "tB_wiek";
            this.tB_wiek.Size = new System.Drawing.Size(200, 22);
            this.tB_wiek.TabIndex = 28;
            // 
            // comboBox_specjalizacja
            // 
            this.comboBox_specjalizacja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_specjalizacja.FormattingEnabled = true;
            this.comboBox_specjalizacja.Location = new System.Drawing.Point(213, 203);
            this.comboBox_specjalizacja.Name = "comboBox_specjalizacja";
            this.comboBox_specjalizacja.Size = new System.Drawing.Size(200, 24);
            this.comboBox_specjalizacja.TabIndex = 30;
            // 
            // Form_dodaj_lekarza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 313);
            this.Controls.Add(this.comboBox_specjalizacja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_wiek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_wstecz);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.label_nr_telefonu);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_nazwisko);
            this.Controls.Add(this.lb_imie);
            this.Controls.Add(this.tB_nr_telefonu);
            this.Controls.Add(this.tB_id);
            this.Controls.Add(this.tB_nazwisko);
            this.Controls.Add(this.tB_imie);
            this.MinimumSize = new System.Drawing.Size(490, 360);
            this.Name = "Form_dodaj_lekarza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj nowego lekarza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_dodaj_lekarza_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_wstecz;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Label label_nr_telefonu;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_nazwisko;
        private System.Windows.Forms.Label lb_imie;
        private System.Windows.Forms.TextBox tB_nr_telefonu;
        private System.Windows.Forms.TextBox tB_id;
        private System.Windows.Forms.TextBox tB_nazwisko;
        private System.Windows.Forms.TextBox tB_imie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_wiek;
        private System.Windows.Forms.ComboBox comboBox_specjalizacja;
    }
}