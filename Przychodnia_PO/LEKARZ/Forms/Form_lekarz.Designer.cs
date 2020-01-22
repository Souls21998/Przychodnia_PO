namespace Przychodnia_PO
{
    partial class Form_lekarz
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
            this.listView_lista_lekarzy = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nr_telefonu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.specjalizacja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_usun_lekarza = new System.Windows.Forms.Button();
            this.btn_dodaj_lekarza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wstecz.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_wstecz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_wstecz.Location = new System.Drawing.Point(610, 274);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(200, 50);
            this.btn_wstecz.TabIndex = 0;
            this.btn_wstecz.Text = "Wstecz";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // listView_lista_lekarzy
            // 
            this.listView_lista_lekarzy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.imie,
            this.nazwisko,
            this.nr_telefonu,
            this.specjalizacja});
            this.listView_lista_lekarzy.HideSelection = false;
            this.listView_lista_lekarzy.Location = new System.Drawing.Point(12, 60);
            this.listView_lista_lekarzy.Name = "listView_lista_lekarzy";
            this.listView_lista_lekarzy.Size = new System.Drawing.Size(571, 411);
            this.listView_lista_lekarzy.TabIndex = 1;
            this.listView_lista_lekarzy.UseCompatibleStateImageBehavior = false;
            this.listView_lista_lekarzy.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // imie
            // 
            this.imie.Text = "Imię";
            this.imie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imie.Width = 86;
            // 
            // nazwisko
            // 
            this.nazwisko.Text = "Nazwisko";
            this.nazwisko.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nazwisko.Width = 93;
            // 
            // nr_telefonu
            // 
            this.nr_telefonu.Text = "Nr telefonu";
            this.nr_telefonu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nr_telefonu.Width = 133;
            // 
            // specjalizacja
            // 
            this.specjalizacja.Text = "Specjalizacja";
            this.specjalizacja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.specjalizacja.Width = 100;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(822, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lista lekarzy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_usun_lekarza
            // 
            this.btn_usun_lekarza.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_usun_lekarza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usun_lekarza.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_usun_lekarza.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_usun_lekarza.Location = new System.Drawing.Point(610, 218);
            this.btn_usun_lekarza.Name = "btn_usun_lekarza";
            this.btn_usun_lekarza.Size = new System.Drawing.Size(200, 50);
            this.btn_usun_lekarza.TabIndex = 10;
            this.btn_usun_lekarza.Text = "Usuń lekarza";
            this.btn_usun_lekarza.UseVisualStyleBackColor = true;
            this.btn_usun_lekarza.Click += new System.EventHandler(this.btn_usun_lekarza_Click);
            // 
            // btn_dodaj_lekarza
            // 
            this.btn_dodaj_lekarza.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_dodaj_lekarza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dodaj_lekarza.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_dodaj_lekarza.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_dodaj_lekarza.Location = new System.Drawing.Point(610, 162);
            this.btn_dodaj_lekarza.Name = "btn_dodaj_lekarza";
            this.btn_dodaj_lekarza.Size = new System.Drawing.Size(200, 50);
            this.btn_dodaj_lekarza.TabIndex = 9;
            this.btn_dodaj_lekarza.Text = "Dodaj lekarza";
            this.btn_dodaj_lekarza.UseVisualStyleBackColor = true;
            this.btn_dodaj_lekarza.Click += new System.EventHandler(this.btn_dodaj_lekarza_Click);
            // 
            // Form_lekarz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 483);
            this.Controls.Add(this.btn_usun_lekarza);
            this.Controls.Add(this.btn_dodaj_lekarza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView_lista_lekarzy);
            this.Controls.Add(this.btn_wstecz);
            this.MinimumSize = new System.Drawing.Size(840, 530);
            this.Name = "Form_lekarz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista lekarzy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_lekarz_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_wstecz;
        private System.Windows.Forms.ListView listView_lista_lekarzy;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader imie;
        private System.Windows.Forms.ColumnHeader nazwisko;
        private System.Windows.Forms.ColumnHeader nr_telefonu;
        private System.Windows.Forms.ColumnHeader specjalizacja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_usun_lekarza;
        private System.Windows.Forms.Button btn_dodaj_lekarza;
    }
}