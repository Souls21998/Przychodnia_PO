using System.Windows.Forms;

namespace Przychodnia_PO
{
    partial class Form_pacjent : Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.wiek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_wstecz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wstecz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_wstecz.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_wstecz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_wstecz.Location = new System.Drawing.Point(610, 279);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(200, 50);
            this.btn_wstecz.TabIndex = 1;
            this.btn_wstecz.Text = "Wstecz";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // listView_lista_pacjentow
            // 
            this.listView_lista_pacjentow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_lista_pacjentow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.imie,
            this.nazwisko,
            this.wiek,
            this.numer_telefonu});
            this.listView_lista_pacjentow.HideSelection = false;
            this.listView_lista_pacjentow.Location = new System.Drawing.Point(21, 60);
            this.listView_lista_pacjentow.Name = "listView_lista_pacjentow";
            this.listView_lista_pacjentow.Size = new System.Drawing.Size(555, 411);
            this.listView_lista_pacjentow.TabIndex = 2;
            this.listView_lista_pacjentow.UseCompatibleStateImageBehavior = false;
            this.listView_lista_pacjentow.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "PESEL";
            this.ID.Width = 100;
            // 
            // imie
            // 
            this.imie.Text = "Imie";
            this.imie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imie.Width = 100;
            // 
            // nazwisko
            // 
            this.nazwisko.Text = "Nazwisko";
            this.nazwisko.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nazwisko.Width = 100;
            // 
            // numer_telefonu
            // 
            this.numer_telefonu.DisplayIndex = 3;
            this.numer_telefonu.Text = "Numer telefonu";
            this.numer_telefonu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numer_telefonu.Width = 100;
            // 
            // btn_dodaj_pacjenta
            // 
            this.btn_dodaj_pacjenta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_dodaj_pacjenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dodaj_pacjenta.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_dodaj_pacjenta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_dodaj_pacjenta.Location = new System.Drawing.Point(610, 167);
            this.btn_dodaj_pacjenta.Name = "btn_dodaj_pacjenta";
            this.btn_dodaj_pacjenta.Size = new System.Drawing.Size(200, 50);
            this.btn_dodaj_pacjenta.TabIndex = 3;
            this.btn_dodaj_pacjenta.Text = "Dodaj pacjenta";
            this.btn_dodaj_pacjenta.UseVisualStyleBackColor = true;
            this.btn_dodaj_pacjenta.Click += new System.EventHandler(this.btn_dodaj_pacjenta_Click);
            // 
            // btn_usun_pacjenta
            // 
            this.btn_usun_pacjenta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_usun_pacjenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usun_pacjenta.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_usun_pacjenta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_usun_pacjenta.Location = new System.Drawing.Point(610, 223);
            this.btn_usun_pacjenta.Name = "btn_usun_pacjenta";
            this.btn_usun_pacjenta.Size = new System.Drawing.Size(200, 50);
            this.btn_usun_pacjenta.TabIndex = 4;
            this.btn_usun_pacjenta.Text = "Usuń pacjenta";
            this.btn_usun_pacjenta.UseVisualStyleBackColor = true;
            this.btn_usun_pacjenta.Click += new System.EventHandler(this.btn_usun_pacjenta_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(822, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista pacjentów";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wiek
            // 
            this.wiek.DisplayIndex = 4;
            this.wiek.Text = "Wiek";
            this.wiek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_pacjent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_usun_pacjenta);
            this.Controls.Add(this.btn_dodaj_pacjenta);
            this.Controls.Add(this.listView_lista_pacjentow);
            this.Controls.Add(this.btn_wstecz);
            this.MinimumSize = new System.Drawing.Size(840, 530);
            this.Name = "Form_pacjent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista pacjentów";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_pacjent_FormClosing);
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
        private Label label2;
        private ColumnHeader wiek;

        public new FormClosedEventHandler FormClosed { get; private set; }
    }
}