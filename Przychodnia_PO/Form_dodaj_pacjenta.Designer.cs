namespace Przychodnia_PO
{
    partial class Form_dodaj_pacjenta
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
            this.tB_imie = new System.Windows.Forms.TextBox();
            this.tB_nazwisko = new System.Windows.Forms.TextBox();
            this.tB_id = new System.Windows.Forms.TextBox();
            this.tB_wiek = new System.Windows.Forms.TextBox();
            this.tB_nr_telefonu = new System.Windows.Forms.TextBox();
            this.lb_imie = new System.Windows.Forms.Label();
            this.lb_nazwisko = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_wiek = new System.Windows.Forms.Label();
            this.label_nr_telefonu = new System.Windows.Forms.Label();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_wstecz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_imie
            // 
            this.tB_imie.Location = new System.Drawing.Point(200, 40);
            this.tB_imie.Name = "tB_imie";
            this.tB_imie.Size = new System.Drawing.Size(100, 22);
            this.tB_imie.TabIndex = 0;
            // 
            // tB_nazwisko
            // 
            this.tB_nazwisko.Location = new System.Drawing.Point(200, 90);
            this.tB_nazwisko.Name = "tB_nazwisko";
            this.tB_nazwisko.Size = new System.Drawing.Size(100, 22);
            this.tB_nazwisko.TabIndex = 1;
            // 
            // tB_id
            // 
            this.tB_id.Location = new System.Drawing.Point(200, 135);
            this.tB_id.Name = "tB_id";
            this.tB_id.Size = new System.Drawing.Size(100, 22);
            this.tB_id.TabIndex = 2;
            // 
            // tB_wiek
            // 
            this.tB_wiek.Location = new System.Drawing.Point(200, 185);
            this.tB_wiek.Name = "tB_wiek";
            this.tB_wiek.Size = new System.Drawing.Size(100, 22);
            this.tB_wiek.TabIndex = 3;
            // 
            // tB_nr_telefonu
            // 
            this.tB_nr_telefonu.Location = new System.Drawing.Point(200, 235);
            this.tB_nr_telefonu.Name = "tB_nr_telefonu";
            this.tB_nr_telefonu.Size = new System.Drawing.Size(100, 22);
            this.tB_nr_telefonu.TabIndex = 4;
            // 
            // lb_imie
            // 
            this.lb_imie.AutoSize = true;
            this.lb_imie.Location = new System.Drawing.Point(60, 40);
            this.lb_imie.Name = "lb_imie";
            this.lb_imie.Size = new System.Drawing.Size(33, 17);
            this.lb_imie.TabIndex = 5;
            this.lb_imie.Text = "Imię";
            // 
            // lb_nazwisko
            // 
            this.lb_nazwisko.AutoSize = true;
            this.lb_nazwisko.Location = new System.Drawing.Point(60, 90);
            this.lb_nazwisko.Name = "lb_nazwisko";
            this.lb_nazwisko.Size = new System.Drawing.Size(67, 17);
            this.lb_nazwisko.TabIndex = 6;
            this.lb_nazwisko.Text = "Nazwisko";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(60, 140);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(21, 17);
            this.lb_id.TabIndex = 7;
            this.lb_id.Text = "ID";
            // 
            // lb_wiek
            // 
            this.lb_wiek.AutoSize = true;
            this.lb_wiek.Location = new System.Drawing.Point(60, 190);
            this.lb_wiek.Name = "lb_wiek";
            this.lb_wiek.Size = new System.Drawing.Size(39, 17);
            this.lb_wiek.TabIndex = 8;
            this.lb_wiek.Text = "Wiek";
            // 
            // label_nr_telefonu
            // 
            this.label_nr_telefonu.AutoSize = true;
            this.label_nr_telefonu.Location = new System.Drawing.Point(60, 240);
            this.label_nr_telefonu.Name = "label_nr_telefonu";
            this.label_nr_telefonu.Size = new System.Drawing.Size(105, 17);
            this.label_nr_telefonu.TabIndex = 9;
            this.label_nr_telefonu.Text = "Numer telefonu";
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(200, 288);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(134, 23);
            this.btn_dodaj.TabIndex = 10;
            this.btn_dodaj.Text = "Dodaj pacjenta";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Location = new System.Drawing.Point(63, 287);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(75, 23);
            this.btn_wstecz.TabIndex = 11;
            this.btn_wstecz.Text = "WSTECZ";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // Form_dodaj_pacjenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 346);
            this.Controls.Add(this.btn_wstecz);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.label_nr_telefonu);
            this.Controls.Add(this.lb_wiek);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_nazwisko);
            this.Controls.Add(this.lb_imie);
            this.Controls.Add(this.tB_nr_telefonu);
            this.Controls.Add(this.tB_wiek);
            this.Controls.Add(this.tB_id);
            this.Controls.Add(this.tB_nazwisko);
            this.Controls.Add(this.tB_imie);
            this.Name = "Form_dodaj_pacjenta";
            this.Text = "Form_dodaj_pacjenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_imie;
        private System.Windows.Forms.TextBox tB_nazwisko;
        private System.Windows.Forms.TextBox tB_id;
        private System.Windows.Forms.TextBox tB_wiek;
        private System.Windows.Forms.TextBox tB_nr_telefonu;
        private System.Windows.Forms.Label lb_imie;
        private System.Windows.Forms.Label lb_nazwisko;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_wiek;
        private System.Windows.Forms.Label label_nr_telefonu;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_wstecz;
    }
}