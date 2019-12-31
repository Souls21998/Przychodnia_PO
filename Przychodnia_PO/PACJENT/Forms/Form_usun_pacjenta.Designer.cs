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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj PESEL pacjenta, którego chcesz usunąć.";
            // 
            // tB_id_pacjent
            // 
            this.tB_id_pacjent.Location = new System.Drawing.Point(54, 67);
            this.tB_id_pacjent.Name = "tB_id_pacjent";
            this.tB_id_pacjent.Size = new System.Drawing.Size(305, 22);
            this.tB_id_pacjent.TabIndex = 1;
            // 
            // btn_usun
            // 
            this.btn_usun.Location = new System.Drawing.Point(261, 113);
            this.btn_usun.Name = "btn_usun";
            this.btn_usun.Size = new System.Drawing.Size(98, 23);
            this.btn_usun.TabIndex = 2;
            this.btn_usun.Text = "Usuń";
            this.btn_usun.UseVisualStyleBackColor = true;
            this.btn_usun.Click += new System.EventHandler(this.btn_usun_Click);
            // 
            // btn_wstecz
            // 
            this.btn_wstecz.Location = new System.Drawing.Point(54, 113);
            this.btn_wstecz.Name = "btn_wstecz";
            this.btn_wstecz.Size = new System.Drawing.Size(75, 23);
            this.btn_wstecz.TabIndex = 3;
            this.btn_wstecz.Text = "Wstecz";
            this.btn_wstecz.UseVisualStyleBackColor = true;
            this.btn_wstecz.Click += new System.EventHandler(this.btn_wstecz_Click);
            // 
            // Form_usun_pacjenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 186);
            this.Controls.Add(this.btn_wstecz);
            this.Controls.Add(this.btn_usun);
            this.Controls.Add(this.tB_id_pacjent);
            this.Controls.Add(this.label1);
            this.Name = "Form_usun_pacjenta";
            this.Text = "Form_usun_pacjenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_id_pacjent;
        private System.Windows.Forms.Button btn_usun;
        private System.Windows.Forms.Button btn_wstecz;
    }
}