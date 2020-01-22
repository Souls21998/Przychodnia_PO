namespace Przychodnia_PO
{
    partial class Form_usun_lekarza
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
            this.btn_wstecz = new System.Windows.Forms.Button();
            this.btn_usun = new System.Windows.Forms.Button();
            this.tB_id_lekarz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 48);
            this.label2.TabIndex = 18;
            this.label2.Text = "Usuń lekarza";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wstecz.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_wstecz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_wstecz.Location = new System.Drawing.Point(83, 176);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(160, 35);
            this.btn_wstecz.TabIndex = 17;
            this.btn_wstecz.Text = "Wstecz";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // btn_usun
            // 
            this.btn_usun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usun.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_usun.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_usun.Location = new System.Drawing.Point(262, 176);
            this.btn_usun.Name = "btn_usun";
            this.btn_usun.Size = new System.Drawing.Size(160, 35);
            this.btn_usun.TabIndex = 16;
            this.btn_usun.Text = "Usuń";
            this.btn_usun.UseVisualStyleBackColor = true;
            this.btn_usun.Click += new System.EventHandler(this.btn_usun_Click);
            // 
            // tB_id_lekarz
            // 
            this.tB_id_lekarz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_id_lekarz.Location = new System.Drawing.Point(83, 102);
            this.tB_id_lekarz.Name = "tB_id_lekarz";
            this.tB_id_lekarz.Size = new System.Drawing.Size(339, 22);
            this.tB_id_lekarz.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Podaj ID lekarza, którego chcesz usunąć.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_usun_lekarza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 223);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_wstecz);
            this.Controls.Add(this.btn_usun);
            this.Controls.Add(this.tB_id_lekarz);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(520, 270);
            this.Name = "Form_usun_lekarza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuń lekarza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_usun_lekarza_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_wstecz;
        private System.Windows.Forms.Button btn_usun;
        private System.Windows.Forms.TextBox tB_id_lekarz;
        private System.Windows.Forms.Label label1;
    }
}