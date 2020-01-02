namespace Przychodnia_PO
{
    partial class Form_dodaj_wizyte
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
            this.label1 = new System.Windows.Forms.Label();
            this.tB_id_pacjenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_wstecz = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.comboBox_wybierz_lekarza = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dodaj wizytę";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Podaj PESEL pacjenta";
            // 
            // tB_id_pacjenta
            // 
            this.tB_id_pacjenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_id_pacjenta.Location = new System.Drawing.Point(201, 78);
            this.tB_id_pacjenta.Name = "tB_id_pacjenta";
            this.tB_id_pacjenta.Size = new System.Drawing.Size(219, 22);
            this.tB_id_pacjenta.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Podaj ID lekarza";
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wstecz.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_wstecz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_wstecz.Location = new System.Drawing.Point(54, 202);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(160, 35);
            this.btn_wstecz.TabIndex = 14;
            this.btn_wstecz.Text = "Wstecz";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dodaj.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_dodaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_dodaj.Location = new System.Drawing.Point(220, 202);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(160, 35);
            this.btn_dodaj.TabIndex = 13;
            this.btn_dodaj.Text = "Dodaj wizytę";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // comboBox_wybierz_lekarza
            // 
            this.comboBox_wybierz_lekarza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_wybierz_lekarza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_wybierz_lekarza.FormattingEnabled = true;
            this.comboBox_wybierz_lekarza.Location = new System.Drawing.Point(201, 112);
            this.comboBox_wybierz_lekarza.Name = "comboBox_wybierz_lekarza";
            this.comboBox_wybierz_lekarza.Size = new System.Drawing.Size(219, 24);
            this.comboBox_wybierz_lekarza.TabIndex = 15;
            // 
            // Form_dodaj_wizyte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.comboBox_wybierz_lekarza);
            this.Controls.Add(this.btn_wstecz);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_id_pacjenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "Form_dodaj_wizyte";
            this.Text = "Dodaj wizyte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_id_pacjenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_wstecz;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.ComboBox comboBox_wybierz_lekarza;
    }
}