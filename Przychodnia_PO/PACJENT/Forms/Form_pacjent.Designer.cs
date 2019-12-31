using System.Windows.Forms;

namespace Przychodnia_PO
{
    partial class Form_pacjent : Forms
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
            this.btn_wstecz = new System.Windows.Forms.Button();
            this.listView_lista_pacjentow = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numer_telefonu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_dodaj_pacjenta = new System.Windows.Forms.Button();
            this.btn_usun_pacjenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Location = new System.Drawing.Point(27, 399);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(139, 30);
            this.btn_wstecz.TabIndex = 1;
            this.btn_wstecz.Text = "WSTECZ";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // listView_lista_pacjentow
            // 
            this.listView_lista_pacjentow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.imie,
            this.nazwisko,
            this.numer_telefonu});
            this.listView_lista_pacjentow.HideSelection = false;
            this.listView_lista_pacjentow.Location = new System.Drawing.Point(27, 25);
            this.listView_lista_pacjentow.Name = "listView_lista_pacjentow";
            this.listView_lista_pacjentow.Size = new System.Drawing.Size(430, 270);
            this.listView_lista_pacjentow.TabIndex = 2;
            this.listView_lista_pacjentow.UseCompatibleStateImageBehavior = false;
            this.listView_lista_pacjentow.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "PESEL";
            // 
            // imie
            // 
            this.imie.Text = "Imie";
            this.imie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nazwisko
            // 
            this.nazwisko.Text = "Nazwisko";
            this.nazwisko.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nazwisko.Width = 84;
            // 
            // numer_telefonu
            // 
            this.numer_telefonu.Text = "Numer telefonu";
            this.numer_telefonu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numer_telefonu.Width = 110;
            // 
            // btn_dodaj_pacjenta
            // 
            this.btn_dodaj_pacjenta.Location = new System.Drawing.Point(491, 25);
            this.btn_dodaj_pacjenta.Name = "btn_dodaj_pacjenta";
            this.btn_dodaj_pacjenta.Size = new System.Drawing.Size(127, 43);
            this.btn_dodaj_pacjenta.TabIndex = 3;
            this.btn_dodaj_pacjenta.Text = "Dodaj pacjenta";
            this.btn_dodaj_pacjenta.UseVisualStyleBackColor = true;
            this.btn_dodaj_pacjenta.Click += new System.EventHandler(this.btn_dodaj_pacjenta_Click);
            // 
            // btn_usun_pacjenta
            // 
            this.btn_usun_pacjenta.Location = new System.Drawing.Point(491, 74);
            this.btn_usun_pacjenta.Name = "btn_usun_pacjenta";
            this.btn_usun_pacjenta.Size = new System.Drawing.Size(127, 43);
            this.btn_usun_pacjenta.TabIndex = 4;
            this.btn_usun_pacjenta.Text = "Usun pacjenta";
            this.btn_usun_pacjenta.UseVisualStyleBackColor = true;
            this.btn_usun_pacjenta.Click += new System.EventHandler(this.btn_usun_pacjenta_Click);
            // 
            // Form_pacjent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_usun_pacjenta);
            this.Controls.Add(this.btn_dodaj_pacjenta);
            this.Controls.Add(this.listView_lista_pacjentow);
            this.Controls.Add(this.btn_wstecz);
            this.Name = "Form_pacjent";
            this.Text = "Form_pacjent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_pacjent_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_wstecz;
        private System.Windows.Forms.ListView listView_lista_pacjentow;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader imie;
        private System.Windows.Forms.ColumnHeader nazwisko;
        private System.Windows.Forms.ColumnHeader numer_telefonu;
        private System.Windows.Forms.Button btn_dodaj_pacjenta;
        private System.Windows.Forms.Button btn_usun_pacjenta;

        public new FormClosedEventHandler FormClosed { get; private set; }
    }
}