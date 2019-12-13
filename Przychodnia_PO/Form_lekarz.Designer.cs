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
            this.btn_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Location = new System.Drawing.Point(42, 380);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(139, 30);
            this.btn_wstecz.TabIndex = 0;
            this.btn_wstecz.Text = "WSTECZ";
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
            this.listView_lista_lekarzy.Location = new System.Drawing.Point(24, 25);
            this.listView_lista_lekarzy.Name = "listView_lista_lekarzy";
            this.listView_lista_lekarzy.Size = new System.Drawing.Size(565, 237);
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
            this.nr_telefonu.Text = "nr telefonu";
            this.nr_telefonu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nr_telefonu.Width = 133;
            // 
            // specjalizacja
            // 
            this.specjalizacja.Text = "specjalizacja";
            this.specjalizacja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.specjalizacja.Width = 188;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(709, 141);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 2;
            this.btn_test.Text = "button1";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // Form_lekarz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.listView_lista_lekarzy);
            this.Controls.Add(this.btn_wstecz);
            this.Name = "Form_lekarz";
            this.Text = "Form_lekarz";
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
        private System.Windows.Forms.Button btn_test;
    }
}