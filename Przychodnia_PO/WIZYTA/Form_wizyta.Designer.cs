namespace Przychodnia_PO
{
    partial class Form_wizyta
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
            this.tB_typ_porady = new System.Windows.Forms.TextBox();
            this.tB_dolegliwosci = new System.Windows.Forms.TextBox();
            this.tB_choroba = new System.Windows.Forms.TextBox();
            this.tB_zalecenia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_koniec_wizyty = new System.Windows.Forms.Button();
            this.btn_wstecz = new System.Windows.Forms.Button();
            this.label_pacjent = new System.Windows.Forms.Label();
            this.listView_lista_wizyt = new System.Windows.Forms.ListView();
            this.DataWizyty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypPorady = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dolegliwosci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Choroba = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zalecenia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tB_typ_porady
            // 
            this.tB_typ_porady.Location = new System.Drawing.Point(260, 108);
            this.tB_typ_porady.Name = "tB_typ_porady";
            this.tB_typ_porady.Size = new System.Drawing.Size(511, 22);
            this.tB_typ_porady.TabIndex = 1;
            // 
            // tB_dolegliwosci
            // 
            this.tB_dolegliwosci.Location = new System.Drawing.Point(260, 145);
            this.tB_dolegliwosci.Name = "tB_dolegliwosci";
            this.tB_dolegliwosci.Size = new System.Drawing.Size(511, 22);
            this.tB_dolegliwosci.TabIndex = 2;
            // 
            // tB_choroba
            // 
            this.tB_choroba.Location = new System.Drawing.Point(260, 182);
            this.tB_choroba.Name = "tB_choroba";
            this.tB_choroba.Size = new System.Drawing.Size(511, 22);
            this.tB_choroba.TabIndex = 3;
            // 
            // tB_zalecenia
            // 
            this.tB_zalecenia.Location = new System.Drawing.Point(260, 219);
            this.tB_zalecenia.Name = "tB_zalecenia";
            this.tB_zalecenia.Size = new System.Drawing.Size(511, 22);
            this.tB_zalecenia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(-8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wizyta pacjenta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(76, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Typ porady";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(76, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dolegliwości";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(76, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Choroba";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(77, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zalecenia";
            // 
            // btn_koniec_wizyty
            // 
            this.btn_koniec_wizyty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_koniec_wizyty.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_koniec_wizyty.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_koniec_wizyty.Location = new System.Drawing.Point(631, 567);
            this.btn_koniec_wizyty.Name = "btn_koniec_wizyty";
            this.btn_koniec_wizyty.Size = new System.Drawing.Size(140, 54);
            this.btn_koniec_wizyty.TabIndex = 11;
            this.btn_koniec_wizyty.Text = "Koniec wizyty";
            this.btn_koniec_wizyty.UseVisualStyleBackColor = true;
            this.btn_koniec_wizyty.Click += new System.EventHandler(this.btn_koniec_wizyty_Click);
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wstecz.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_wstecz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_wstecz.Location = new System.Drawing.Point(81, 554);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(124, 54);
            this.btn_wstecz.TabIndex = 12;
            this.btn_wstecz.Text = "Wstecz";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // label_pacjent
            // 
            this.label_pacjent.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_pacjent.Location = new System.Drawing.Point(12, 58);
            this.label_pacjent.Name = "label_pacjent";
            this.label_pacjent.Size = new System.Drawing.Size(776, 37);
            this.label_pacjent.TabIndex = 13;
            this.label_pacjent.Text = "Dane pacjenta";
            this.label_pacjent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listView_lista_wizyt
            // 
            this.listView_lista_wizyt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_lista_wizyt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DataWizyty,
            this.TypPorady,
            this.Dolegliwosci,
            this.Choroba,
            this.Zalecenia});
            this.listView_lista_wizyt.HideSelection = false;
            this.listView_lista_wizyt.Location = new System.Drawing.Point(80, 288);
            this.listView_lista_wizyt.Name = "listView_lista_wizyt";
            this.listView_lista_wizyt.Size = new System.Drawing.Size(691, 238);
            this.listView_lista_wizyt.TabIndex = 14;
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
            this.TypPorady.Width = 236;
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
            this.Choroba.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Choroba.Width = 168;
            // 
            // Zalecenia
            // 
            this.Zalecenia.Text = "Zalecenia";
            this.Zalecenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Zalecenia.Width = 177;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(-3, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(804, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Karta pacjenta";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_wizyta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 645);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView_lista_wizyt);
            this.Controls.Add(this.label_pacjent);
            this.Controls.Add(this.btn_wstecz);
            this.Controls.Add(this.btn_koniec_wizyty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_zalecenia);
            this.Controls.Add(this.tB_choroba);
            this.Controls.Add(this.tB_dolegliwosci);
            this.Controls.Add(this.tB_typ_porady);
            this.Name = "Form_wizyta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_wizyta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tB_typ_porady;
        private System.Windows.Forms.TextBox tB_dolegliwosci;
        private System.Windows.Forms.TextBox tB_choroba;
        private System.Windows.Forms.TextBox tB_zalecenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_koniec_wizyty;
        private System.Windows.Forms.Button btn_wstecz;
        private System.Windows.Forms.Label label_pacjent;
        private System.Windows.Forms.ListView listView_lista_wizyt;
        private System.Windows.Forms.ColumnHeader DataWizyty;
        private System.Windows.Forms.ColumnHeader TypPorady;
        private System.Windows.Forms.ColumnHeader Dolegliwosci;
        private System.Windows.Forms.ColumnHeader Choroba;
        private System.Windows.Forms.ColumnHeader Zalecenia;
        private System.Windows.Forms.Label label7;
    }
}