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
            this.dateTimePicker_data_wizyty = new System.Windows.Forms.DateTimePicker();
            this.tB_typ_porady = new System.Windows.Forms.TextBox();
            this.tB_dolegliwosci = new System.Windows.Forms.TextBox();
            this.tB_choroba = new System.Windows.Forms.TextBox();
            this.tB_zalecenia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_koniec_wizyty = new System.Windows.Forms.Button();
            this.btn_wstecz = new System.Windows.Forms.Button();
            this.label_pacjent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker_data_wizyty
            // 
            this.dateTimePicker_data_wizyty.Location = new System.Drawing.Point(308, 135);
            this.dateTimePicker_data_wizyty.Name = "dateTimePicker_data_wizyty";
            this.dateTimePicker_data_wizyty.Size = new System.Drawing.Size(260, 22);
            this.dateTimePicker_data_wizyty.TabIndex = 0;
            // 
            // tB_typ_porady
            // 
            this.tB_typ_porady.Location = new System.Drawing.Point(308, 163);
            this.tB_typ_porady.Name = "tB_typ_porady";
            this.tB_typ_porady.Size = new System.Drawing.Size(460, 22);
            this.tB_typ_porady.TabIndex = 1;
            // 
            // tB_dolegliwosci
            // 
            this.tB_dolegliwosci.Location = new System.Drawing.Point(308, 191);
            this.tB_dolegliwosci.Name = "tB_dolegliwosci";
            this.tB_dolegliwosci.Size = new System.Drawing.Size(460, 22);
            this.tB_dolegliwosci.TabIndex = 2;
            // 
            // tB_choroba
            // 
            this.tB_choroba.Location = new System.Drawing.Point(308, 219);
            this.tB_choroba.Name = "tB_choroba";
            this.tB_choroba.Size = new System.Drawing.Size(460, 22);
            this.tB_choroba.TabIndex = 3;
            // 
            // tB_zalecenia
            // 
            this.tB_zalecenia.Location = new System.Drawing.Point(308, 247);
            this.tB_zalecenia.Name = "tB_zalecenia";
            this.tB_zalecenia.Size = new System.Drawing.Size(460, 22);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data wizyty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Typ porady";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dolegliwości";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Choroba";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zalecenia";
            // 
            // btn_koniec_wizyty
            // 
            this.btn_koniec_wizyty.Location = new System.Drawing.Point(628, 309);
            this.btn_koniec_wizyty.Name = "btn_koniec_wizyty";
            this.btn_koniec_wizyty.Size = new System.Drawing.Size(140, 54);
            this.btn_koniec_wizyty.TabIndex = 11;
            this.btn_koniec_wizyty.Text = "Koniec wizyty";
            this.btn_koniec_wizyty.UseVisualStyleBackColor = true;
            this.btn_koniec_wizyty.Click += new System.EventHandler(this.btn_koniec_wizyty_Click);
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Location = new System.Drawing.Point(43, 309);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(124, 54);
            this.btn_wstecz.TabIndex = 12;
            this.btn_wstecz.Text = "Wstecz";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // label_pacjent
            // 
            this.label_pacjent.AutoSize = true;
            this.label_pacjent.Location = new System.Drawing.Point(52, 58);
            this.label_pacjent.Name = "label_pacjent";
            this.label_pacjent.Size = new System.Drawing.Size(38, 17);
            this.label_pacjent.TabIndex = 13;
            this.label_pacjent.Text = "label";
            // 
            // Form_wizyta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.label_pacjent);
            this.Controls.Add(this.btn_wstecz);
            this.Controls.Add(this.btn_koniec_wizyty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_zalecenia);
            this.Controls.Add(this.tB_choroba);
            this.Controls.Add(this.tB_dolegliwosci);
            this.Controls.Add(this.tB_typ_porady);
            this.Controls.Add(this.dateTimePicker_data_wizyty);
            this.Name = "Form_wizyta";
            this.Text = "Form_wizyta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_data_wizyty;
        private System.Windows.Forms.TextBox tB_typ_porady;
        private System.Windows.Forms.TextBox tB_dolegliwosci;
        private System.Windows.Forms.TextBox tB_choroba;
        private System.Windows.Forms.TextBox tB_zalecenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_koniec_wizyty;
        private System.Windows.Forms.Button btn_wstecz;
        private System.Windows.Forms.Label label_pacjent;
    }
}