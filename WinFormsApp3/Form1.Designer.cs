
namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Kierowcy = new System.Windows.Forms.Button();
            this.Naczepy1 = new System.Windows.Forms.Button();
            this.Ciezarowki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Napis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kierowcy
            // 
            this.Kierowcy.Location = new System.Drawing.Point(411, 44);
            this.Kierowcy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kierowcy.Name = "Kierowcy";
            this.Kierowcy.Size = new System.Drawing.Size(175, 75);
            this.Kierowcy.TabIndex = 0;
            this.Kierowcy.Text = "Kierowcy";
            this.Kierowcy.UseVisualStyleBackColor = true;
            this.Kierowcy.Click += new System.EventHandler(this.Kierowcy_Click);
            // 
            // Naczepy1
            // 
            this.Naczepy1.Location = new System.Drawing.Point(221, 44);
            this.Naczepy1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Naczepy1.Name = "Naczepy1";
            this.Naczepy1.Size = new System.Drawing.Size(175, 75);
            this.Naczepy1.TabIndex = 1;
            this.Naczepy1.Text = "Naczepy";
            this.Naczepy1.UseVisualStyleBackColor = true;
            this.Naczepy1.Click += new System.EventHandler(this.Naczepy_Click);
            // 
            // Ciezarowki
            // 
            this.Ciezarowki.Location = new System.Drawing.Point(29, 44);
            this.Ciezarowki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ciezarowki.Name = "Ciezarowki";
            this.Ciezarowki.Size = new System.Drawing.Size(175, 75);
            this.Ciezarowki.TabIndex = 2;
            this.Ciezarowki.Text = "Ciężarówki";
            this.Ciezarowki.UseVisualStyleBackColor = true;
            this.Ciezarowki.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 155);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Napis
            // 
            this.Napis.AutoSize = true;
            this.Napis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Napis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Napis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Napis.Location = new System.Drawing.Point(115, 9);
            this.Napis.Name = "Napis";
            this.Napis.Size = new System.Drawing.Size(229, 17);
            this.Napis.TabIndex = 4;
            this.Napis.Text = "Wybierz Co chcesz czytać / modyfikować:";
            this.Napis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Napis.Click += new System.EventHandler(this.Napis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 338);
            this.Controls.Add(this.Napis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ciezarowki);
            this.Controls.Add(this.Naczepy1);
            this.Controls.Add(this.Kierowcy);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kierowcy;
        private System.Windows.Forms.Button Naczepy1;
        private System.Windows.Forms.Button Ciezarowki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Napis;
    }
}

