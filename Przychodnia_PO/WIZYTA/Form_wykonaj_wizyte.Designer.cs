namespace Przychodnia_PO
{
    partial class Form_wykonaj_wizyte
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
            this.comboBox_wybierz_lekarza = new System.Windows.Forms.ComboBox();
            this.btn_wstecz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_wykonaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_wybierz_lekarza
            // 
            this.comboBox_wybierz_lekarza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_wybierz_lekarza.FormattingEnabled = true;
            this.comboBox_wybierz_lekarza.Location = new System.Drawing.Point(206, 73);
            this.comboBox_wybierz_lekarza.Name = "comboBox_wybierz_lekarza";
            this.comboBox_wybierz_lekarza.Size = new System.Drawing.Size(206, 24);
            this.comboBox_wybierz_lekarza.TabIndex = 0;
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wstecz.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_wstecz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_wstecz.Location = new System.Drawing.Point(26, 139);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(188, 44);
            this.btn_wstecz.TabIndex = 1;
            this.btn_wstecz.Text = "Wstecz";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wykonaj wizytę";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_wykonaj
            // 
            this.btn_wykonaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wykonaj.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_wykonaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_wykonaj.Location = new System.Drawing.Point(224, 139);
            this.btn_wykonaj.Name = "btn_wykonaj";
            this.btn_wykonaj.Size = new System.Drawing.Size(205, 44);
            this.btn_wykonaj.TabIndex = 3;
            this.btn_wykonaj.Text = "Wpuść kolejną osobę";
            this.btn_wykonaj.UseVisualStyleBackColor = true;
            this.btn_wykonaj.Click += new System.EventHandler(this.btn_wykonaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Podaj ID lekarza";
            // 
            // Form_wykonaj_wizyte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 204);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_wykonaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_wstecz);
            this.Controls.Add(this.comboBox_wybierz_lekarza);
            this.Name = "Form_wykonaj_wizyte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_wykonaj_wizyte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_wybierz_lekarza;
        private System.Windows.Forms.Button btn_wstecz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_wykonaj;
        private System.Windows.Forms.Label label2;
    }
}