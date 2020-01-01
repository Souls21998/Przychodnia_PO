namespace Przychodnia_PO
{
    partial class Form_zarzadzaj_przychodnia
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
            this.btn_przejdz_lekarz = new System.Windows.Forms.Button();
            this.btn_przejdz_pacjent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_wstecz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_przejdz_lekarz
            // 
            this.btn_przejdz_lekarz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_przejdz_lekarz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_przejdz_lekarz.FlatAppearance.BorderSize = 0;
            this.btn_przejdz_lekarz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_przejdz_lekarz.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_przejdz_lekarz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_przejdz_lekarz.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_przejdz_lekarz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_przejdz_lekarz.Location = new System.Drawing.Point(12, 118);
            this.btn_przejdz_lekarz.Name = "btn_przejdz_lekarz";
            this.btn_przejdz_lekarz.Size = new System.Drawing.Size(408, 35);
            this.btn_przejdz_lekarz.TabIndex = 3;
            this.btn_przejdz_lekarz.Text = "Lista Lekarzy";
            this.btn_przejdz_lekarz.UseVisualStyleBackColor = true;
            this.btn_przejdz_lekarz.Click += new System.EventHandler(this.btn_przejdz_lekarz_Click);
            // 
            // btn_przejdz_pacjent
            // 
            this.btn_przejdz_pacjent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_przejdz_pacjent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_przejdz_pacjent.FlatAppearance.BorderSize = 0;
            this.btn_przejdz_pacjent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_przejdz_pacjent.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_przejdz_pacjent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_przejdz_pacjent.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_przejdz_pacjent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_przejdz_pacjent.Location = new System.Drawing.Point(12, 159);
            this.btn_przejdz_pacjent.Name = "btn_przejdz_pacjent";
            this.btn_przejdz_pacjent.Size = new System.Drawing.Size(408, 35);
            this.btn_przejdz_pacjent.TabIndex = 2;
            this.btn_przejdz_pacjent.Text = "Lista Pacjentów";
            this.btn_przejdz_pacjent.UseVisualStyleBackColor = true;
            this.btn_przejdz_pacjent.Click += new System.EventHandler(this.btn_przejdz_pacjent_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wybierz listę którą chcesz edytować ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zarządzaj przychodnią";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_wstecz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wstecz.FlatAppearance.BorderSize = 0;
            this.btn_wstecz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_wstecz.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_wstecz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wstecz.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_wstecz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_wstecz.Location = new System.Drawing.Point(12, 326);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(408, 35);
            this.btn_wstecz.TabIndex = 6;
            this.btn_wstecz.Text = "Wstecz";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // Form_zarzadzaj_przychodnia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 373);
            this.Controls.Add(this.btn_wstecz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_przejdz_lekarz);
            this.Controls.Add(this.btn_przejdz_pacjent);
            this.MinimumSize = new System.Drawing.Size(450, 420);
            this.Name = "Form_zarzadzaj_przychodnia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarządzaj przychodnią";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_zarzadzaj_przychodnia_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_przejdz_lekarz;
        private System.Windows.Forms.Button btn_przejdz_pacjent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_wstecz;
    }
}