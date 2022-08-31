
namespace WinFormsApp3
{
    partial class Form2
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
            this.Modyfikuj_Pojazd = new System.Windows.Forms.Button();
            this.Nowy_Pojazd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(232, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz co dalej:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Modyfikuj_Pojazd
            // 
            this.Modyfikuj_Pojazd.Location = new System.Drawing.Point(461, 277);
            this.Modyfikuj_Pojazd.Name = "Modyfikuj_Pojazd";
            this.Modyfikuj_Pojazd.Size = new System.Drawing.Size(206, 47);
            this.Modyfikuj_Pojazd.TabIndex = 2;
            this.Modyfikuj_Pojazd.Text = "Zmodyfikuj Obecne Dane";
            this.Modyfikuj_Pojazd.UseVisualStyleBackColor = true;
            this.Modyfikuj_Pojazd.Click += new System.EventHandler(this.ZmodyfikujObecneDane);
            // 
            // Nowy_Pojazd
            // 
            this.Nowy_Pojazd.Location = new System.Drawing.Point(112, 277);
            this.Nowy_Pojazd.Name = "Nowy_Pojazd";
            this.Nowy_Pojazd.Size = new System.Drawing.Size(206, 47);
            this.Nowy_Pojazd.TabIndex = 3;
            this.Nowy_Pojazd.Text = "Utwórz Nowy Pojazd";
            this.Nowy_Pojazd.UseVisualStyleBackColor = true;
            this.Nowy_Pojazd.Click += new System.EventHandler(this.Nowy_Pojazd_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nowy_Pojazd);
            this.Controls.Add(this.Modyfikuj_Pojazd);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Modyfikuj_Pojazd;
        private System.Windows.Forms.Button Nowy_Pojazd;
    }
}