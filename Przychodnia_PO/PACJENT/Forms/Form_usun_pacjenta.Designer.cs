namespace Przychodnia_PO
{
    partial class Form_usun_pacjenta
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
            this.btn_usun = new System.Windows.Forms.Button();
            this.btn_wstecz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj PESEL pacjenta, którego chcesz usunąć.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tB_id_pacjent
            // 
            this.tB_id_pacjent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_id_pacjent.Location = new System.Drawing.Point(83, 91);
            this.tB_id_pacjent.Name = "tB_id_pacjent";
            this.tB_id_pacjent.Size = new System.Drawing.Size(339, 22);
            this.tB_id_pacjent.TabIndex = 1;
            // 
            // btn_usun
            // 
            this.btn_usun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usun.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_usun.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_usun.Location = new System.Drawing.Point(262, 165);
            this.btn_usun.Name = "btn_usun";
            this.btn_usun.Size = new System.Drawing.Size(160, 35);
            this.btn_usun.TabIndex = 2;
            this.btn_usun.Text = "Usuń";
            this.btn_usun.UseVisualStyleBackColor = true;
            this.btn_usun.Click += new System.EventHandler(this.btn_usun_Click);
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wstecz.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_wstecz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_wstecz.Location = new System.Drawing.Point(83, 165);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(160, 35);
            this.btn_wstecz.TabIndex = 3;
            this.btn_wstecz.Text = "Wstecz";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 48);
            this.label2.TabIndex = 13;
            this.label2.Text = "Usuń pacjenta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_usun_pacjenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 223);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_wstecz);
            this.Controls.Add(this.btn_usun);
            this.Controls.Add(this.tB_id_pacjent);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(520, 270);
            this.Name = "Form_usun_pacjenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuń pacjenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_id_pacjent;
        private System.Windows.Forms.Button btn_usun;
        private System.Windows.Forms.Button btn_wstecz;
        private System.Windows.Forms.Label label2;
    }
}