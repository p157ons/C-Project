
namespace WinFormsApp3
{
    partial class Form3
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
            this.Dodaj_Pojazd = new System.Windows.Forms.Button();
            this.nr_rejestracyjny = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.rok_produkcji = new System.Windows.Forms.Label();
            this.rok_produkcji_box = new System.Windows.Forms.TextBox();
            this.model_box = new System.Windows.Forms.TextBox();
            this.nr_rejestracyjny_box = new System.Windows.Forms.TextBox();
            this.Powrót = new System.Windows.Forms.Button();
            this.mySqlConnection1 = new MySqlConnector.MySqlConnection();
            this.SuspendLayout();
            // 
            // Dodaj_Pojazd
            // 
            this.Dodaj_Pojazd.Location = new System.Drawing.Point(368, 121);
            this.Dodaj_Pojazd.Name = "Dodaj_Pojazd";
            this.Dodaj_Pojazd.Size = new System.Drawing.Size(141, 59);
            this.Dodaj_Pojazd.TabIndex = 0;
            this.Dodaj_Pojazd.Text = "Zapisz Pojazd";
            this.Dodaj_Pojazd.UseVisualStyleBackColor = true;
            this.Dodaj_Pojazd.Click += new System.EventHandler(this.Dodaj_Pojazd_Click);
            // 
            // nr_rejestracyjny
            // 
            this.nr_rejestracyjny.AutoSize = true;
            this.nr_rejestracyjny.Location = new System.Drawing.Point(117, 100);
            this.nr_rejestracyjny.Name = "nr_rejestracyjny";
            this.nr_rejestracyjny.Size = new System.Drawing.Size(118, 20);
            this.nr_rejestracyjny.TabIndex = 1;
            this.nr_rejestracyjny.Text = "Nr Rejestracyjny:";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(117, 160);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(55, 20);
            this.Model.TabIndex = 2;
            this.Model.Text = "Model:";
            // 
            // rok_produkcji
            // 
            this.rok_produkcji.AutoSize = true;
            this.rok_produkcji.Location = new System.Drawing.Point(117, 215);
            this.rok_produkcji.Name = "rok_produkcji";
            this.rok_produkcji.Size = new System.Drawing.Size(102, 20);
            this.rok_produkcji.TabIndex = 3;
            this.rok_produkcji.Text = "Rok Produkcji:";
            // 
            // rok_produkcji_box
            // 
            this.rok_produkcji_box.Location = new System.Drawing.Point(121, 254);
            this.rok_produkcji_box.Name = "rok_produkcji_box";
            this.rok_produkcji_box.Size = new System.Drawing.Size(188, 27);
            this.rok_produkcji_box.TabIndex = 4;
            this.rok_produkcji_box.Validating += new System.ComponentModel.CancelEventHandler(this.text_box_rokProdukcji_validation);
            // 
            // model_box
            // 
            this.model_box.Location = new System.Drawing.Point(121, 183);
            this.model_box.Name = "model_box";
            this.model_box.Size = new System.Drawing.Size(188, 27);
            this.model_box.TabIndex = 5;
            this.model_box.Validating += new System.ComponentModel.CancelEventHandler(this.text_box_model_validation);
            // 
            // nr_rejestracyjny_box
            // 
            this.nr_rejestracyjny_box.Location = new System.Drawing.Point(121, 123);
            this.nr_rejestracyjny_box.Name = "nr_rejestracyjny_box";
            this.nr_rejestracyjny_box.Size = new System.Drawing.Size(188, 27);
            this.nr_rejestracyjny_box.TabIndex = 6;
            this.nr_rejestracyjny_box.TextChanged += new System.EventHandler(this.nr_rejestracyjny_box_TextChanged);
            // 
            // Powrót
            // 
            this.Powrót.Location = new System.Drawing.Point(694, 409);
            this.Powrót.Name = "Powrót";
            this.Powrót.Size = new System.Drawing.Size(94, 29);
            this.Powrót.TabIndex = 7;
            this.Powrót.Text = "Wróć";
            this.Powrót.UseVisualStyleBackColor = true;
            this.Powrót.Click += new System.EventHandler(this.WrócDoForm2);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Powrót);
            this.Controls.Add(this.nr_rejestracyjny_box);
            this.Controls.Add(this.model_box);
            this.Controls.Add(this.rok_produkcji_box);
            this.Controls.Add(this.rok_produkcji);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.nr_rejestracyjny);
            this.Controls.Add(this.Dodaj_Pojazd);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dodaj_Pojazd;
        private System.Windows.Forms.Label nr_rejestracyjny;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label rok_produkcji;
        private System.Windows.Forms.TextBox rok_produkcji_box;
        private System.Windows.Forms.TextBox model_box;
        private System.Windows.Forms.TextBox nr_rejestracyjny_box;
        private System.Windows.Forms.Button Powrót;
        private MySqlConnector.MySqlConnection mySqlConnection1;
    }
}