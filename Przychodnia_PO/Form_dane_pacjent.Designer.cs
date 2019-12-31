namespace Przychodnia_PO
{
    partial class Form_dane_pacjent
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
            this.label1 = new System.Windows.Forms.Label();
            this.tB_id_pacjent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_pacjent = new System.Windows.Forms.Label();
            this.listView_lista_wizyt = new System.Windows.Forms.ListView();
            this.DataWizyty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypPorady = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dolegliwosci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Choroba = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zalecenia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_wyswietl = new System.Windows.Forms.Button();
            this.btn_wstecz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj PESEL pacjenta";
            // 
            // tB_id_pacjent
            // 
            this.tB_id_pacjent.Location = new System.Drawing.Point(195, 20);
            this.tB_id_pacjent.Name = "tB_id_pacjent";
            this.tB_id_pacjent.Size = new System.Drawing.Size(258, 22);
            this.tB_id_pacjent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dane pacjenta";
            // 
            // label_pacjent
            // 
            this.label_pacjent.AutoSize = true;
            this.label_pacjent.Location = new System.Drawing.Point(181, 66);
            this.label_pacjent.Name = "label_pacjent";
            this.label_pacjent.Size = new System.Drawing.Size(100, 17);
            this.label_pacjent.TabIndex = 3;
            this.label_pacjent.Text = "Dane pacjenta";
            // 
            // listView_lista_wizyt
            // 
            this.listView_lista_wizyt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DataWizyty,
            this.TypPorady,
            this.Dolegliwosci,
            this.Choroba,
            this.Zalecenia});
            this.listView_lista_wizyt.HideSelection = false;
            this.listView_lista_wizyt.Location = new System.Drawing.Point(51, 118);
            this.listView_lista_wizyt.Name = "listView_lista_wizyt";
            this.listView_lista_wizyt.Size = new System.Drawing.Size(927, 270);
            this.listView_lista_wizyt.TabIndex = 4;
            this.listView_lista_wizyt.UseCompatibleStateImageBehavior = false;
            this.listView_lista_wizyt.View = System.Windows.Forms.View.Details;
            // 
            // DataWizyty
            // 
            this.DataWizyty.Text = "Data wizyty";
            this.DataWizyty.Width = 140;
            // 
            // TypPorady
            // 
            this.TypPorady.Text = "Typ porady";
            this.TypPorady.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TypPorady.Width = 250;
            // 
            // Dolegliwosci
            // 
            this.Dolegliwosci.Text = "Dolegliwości";
            this.Dolegliwosci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Dolegliwosci.Width = 168;
            // 
            // Choroba
            // 
            this.Choroba.Text = "Choroba";
            this.Choroba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Choroba.Width = 168;
            // 
            // Zalecenia
            // 
            this.Zalecenia.Text = "Zalecenia";
            this.Zalecenia.Width = 177;
            // 
            // btn_wyswietl
            // 
            this.btn_wyswietl.Location = new System.Drawing.Point(655, 20);
            this.btn_wyswietl.Name = "btn_wyswietl";
            this.btn_wyswietl.Size = new System.Drawing.Size(129, 45);
            this.btn_wyswietl.TabIndex = 5;
            this.btn_wyswietl.Text = "Wyświetl";
            this.btn_wyswietl.UseVisualStyleBackColor = true;
            this.btn_wyswietl.Click += new System.EventHandler(this.btn_wyswietl_Click);
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Location = new System.Drawing.Point(42, 445);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(129, 45);
            this.btn_wstecz.TabIndex = 6;
            this.btn_wstecz.Text = "Wstecz";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // Form_dane_pacjent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 502);
            this.Controls.Add(this.btn_wstecz);
            this.Controls.Add(this.btn_wyswietl);
            this.Controls.Add(this.listView_lista_wizyt);
            this.Controls.Add(this.label_pacjent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_id_pacjent);
            this.Controls.Add(this.label1);
            this.Name = "Form_dane_pacjent";
            this.Text = "Form_dane_pacjent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_id_pacjent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_pacjent;
        private System.Windows.Forms.ListView listView_lista_wizyt;
        private System.Windows.Forms.ColumnHeader DataWizyty;
        private System.Windows.Forms.ColumnHeader TypPorady;
        private System.Windows.Forms.ColumnHeader Dolegliwosci;
        private System.Windows.Forms.ColumnHeader Choroba;
        private System.Windows.Forms.ColumnHeader Zalecenia;
        private System.Windows.Forms.Button btn_wyswietl;
        private System.Windows.Forms.Button btn_wstecz;
    }
}