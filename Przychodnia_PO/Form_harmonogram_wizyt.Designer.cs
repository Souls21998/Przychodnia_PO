namespace Przychodnia_PO
{
    partial class Form_harmonogram_wizyt
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_wybierz_lekarza = new System.Windows.Forms.ComboBox();
            this.label_dane_lekarza = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_kolejka_do_lekarza = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numer_telefonu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_wstecz = new System.Windows.Forms.Button();
            this.btn_dodaj_wizytę = new System.Windows.Forms.Button();
            this.btn_wykonaj_wizyte = new System.Windows.Forms.Button();
            this.lekarzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lekarzBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lekarzBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarzBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(812, 70);
            this.label2.TabIndex = 7;
            this.label2.Text = "Harmonogram wizyt";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_wybierz_lekarza
            // 
            this.comboBox_wybierz_lekarza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_wybierz_lekarza.FormattingEnabled = true;
            this.comboBox_wybierz_lekarza.Location = new System.Drawing.Point(16, 101);
            this.comboBox_wybierz_lekarza.Name = "comboBox_wybierz_lekarza";
            this.comboBox_wybierz_lekarza.Size = new System.Drawing.Size(169, 24);
            this.comboBox_wybierz_lekarza.TabIndex = 8;
            this.comboBox_wybierz_lekarza.SelectedIndexChanged += new System.EventHandler(this.comboBox_wybierz_lekarza_SelectedIndexChanged);
            // 
            // label_dane_lekarza
            // 
            this.label_dane_lekarza.AutoSize = true;
            this.label_dane_lekarza.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dane_lekarza.Location = new System.Drawing.Point(223, 70);
            this.label_dane_lekarza.Name = "label_dane_lekarza";
            this.label_dane_lekarza.Size = new System.Drawing.Size(103, 19);
            this.label_dane_lekarza.TabIndex = 9;
            this.label_dane_lekarza.Text = "Dane lekarza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wybierz lekarza z listy";
            // 
            // listView_kolejka_do_lekarza
            // 
            this.listView_kolejka_do_lekarza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_kolejka_do_lekarza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.numer_telefonu});
            this.listView_kolejka_do_lekarza.HideSelection = false;
            this.listView_kolejka_do_lekarza.Location = new System.Drawing.Point(16, 131);
            this.listView_kolejka_do_lekarza.Name = "listView_kolejka_do_lekarza";
            this.listView_kolejka_do_lekarza.Size = new System.Drawing.Size(545, 340);
            this.listView_kolejka_do_lekarza.TabIndex = 12;
            this.listView_kolejka_do_lekarza.UseCompatibleStateImageBehavior = false;
            this.listView_kolejka_do_lekarza.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PESEL";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Imie";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nazwisko";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // numer_telefonu
            // 
            this.numer_telefonu.Text = "Numer telefonu";
            this.numer_telefonu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numer_telefonu.Width = 120;
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wstecz.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_wstecz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_wstecz.Location = new System.Drawing.Point(583, 288);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(200, 50);
            this.btn_wstecz.TabIndex = 13;
            this.btn_wstecz.Text = "Wstecz";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // btn_dodaj_wizytę
            // 
            this.btn_dodaj_wizytę.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dodaj_wizytę.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_dodaj_wizytę.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_dodaj_wizytę.Location = new System.Drawing.Point(583, 176);
            this.btn_dodaj_wizytę.Name = "btn_dodaj_wizytę";
            this.btn_dodaj_wizytę.Size = new System.Drawing.Size(200, 50);
            this.btn_dodaj_wizytę.TabIndex = 14;
            this.btn_dodaj_wizytę.Text = "Dodaj wizytę";
            this.btn_dodaj_wizytę.UseVisualStyleBackColor = true;
            this.btn_dodaj_wizytę.Click += new System.EventHandler(this.btn_dodaj_wizytę_Click);
            // 
            // btn_wykonaj_wizyte
            // 
            this.btn_wykonaj_wizyte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wykonaj_wizyte.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_wykonaj_wizyte.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_wykonaj_wizyte.Location = new System.Drawing.Point(583, 232);
            this.btn_wykonaj_wizyte.Name = "btn_wykonaj_wizyte";
            this.btn_wykonaj_wizyte.Size = new System.Drawing.Size(200, 50);
            this.btn_wykonaj_wizyte.TabIndex = 15;
            this.btn_wykonaj_wizyte.Text = "Wykonaj wizytę";
            this.btn_wykonaj_wizyte.UseVisualStyleBackColor = true;
            this.btn_wykonaj_wizyte.Click += new System.EventHandler(this.btn_wykonaj_wizyte_Click);
            // 
            // lekarzBindingSource
            // 
            this.lekarzBindingSource.DataSource = typeof(Przychodnia_PO.Lekarz);
            // 
            // lekarzBindingSource1
            // 
            this.lekarzBindingSource1.DataSource = typeof(Przychodnia_PO.Lekarz);
            // 
            // Form_harmonogram_wizyt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 483);
            this.Controls.Add(this.btn_wykonaj_wizyte);
            this.Controls.Add(this.btn_dodaj_wizytę);
            this.Controls.Add(this.btn_wstecz);
            this.Controls.Add(this.listView_kolejka_do_lekarza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_dane_lekarza);
            this.Controls.Add(this.comboBox_wybierz_lekarza);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(830, 530);
            this.Name = "Form_harmonogram_wizyt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harmonogram wizyt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_umów_wizytę_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.lekarzBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarzBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource lekarzBindingSource;
        private System.Windows.Forms.ComboBox comboBox_wybierz_lekarza;
        private System.Windows.Forms.Label label_dane_lekarza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource lekarzBindingSource1;
        private System.Windows.Forms.ListView listView_kolejka_do_lekarza;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader numer_telefonu;
        private System.Windows.Forms.Button btn_wstecz;
        private System.Windows.Forms.Button btn_dodaj_wizytę;
        private System.Windows.Forms.Button btn_wykonaj_wizyte;
    }
}