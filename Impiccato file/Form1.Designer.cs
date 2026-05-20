namespace Impiccato_file
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// 
        ///
        /// 
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
            label1 = new Label();
            label2 = new Label();
            sport = new Button();
            animali = new Button();
            film = new Button();
            label3 = new Label();
            button31 = new Button();
            button32 = new Button();
            Bottonefacile = new Button();
            button33 = new Button();
            button34 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(273, 9);
            label1.Name = "label1";
            label1.Size = new Size(463, 54);
            label1.TabIndex = 2;
            label1.Text = "GIOCO DELL' IMPICCATO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 92);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 27;
            label2.Text = "Scegli la categoria:";
            label2.Click += label2_Click;
            // 
            // sport
            // 
            sport.Location = new Point(133, 137);
            sport.Name = "sport";
            sport.Size = new Size(75, 23);
            sport.TabIndex = 29;
            sport.Text = "Sport";
            sport.UseVisualStyleBackColor = true;
            sport.Click += button28_Click;
            // 
            // animali
            // 
            animali.Location = new Point(133, 179);
            animali.Name = "animali";
            animali.Size = new Size(75, 23);
            animali.TabIndex = 30;
            animali.Text = "Animali";
            animali.UseVisualStyleBackColor = true;
            animali.Click += button29_Click;
            // 
            // film
            // 
            film.Location = new Point(133, 226);
            film.Name = "film";
            film.Size = new Size(75, 23);
            film.TabIndex = 31;
            film.Text = "Film";
            film.UseVisualStyleBackColor = true;
            film.Click += button30_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(723, 92);
            label3.Name = "label3";
            label3.Size = new Size(157, 30);
            label3.TabIndex = 32;
            label3.Text = "Inserisci lettera:";
            // 
            // button31
            // 
            button31.Location = new Point(704, 133);
            button31.Name = "button31";
            button31.Size = new Size(194, 31);
            button31.TabIndex = 33;
            button31.UseVisualStyleBackColor = true;
            button31.Click += button31_Click;
            // 
            // button32
            // 
            button32.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button32.Location = new Point(723, 179);
            button32.Name = "button32";
            button32.Size = new Size(157, 40);
            button32.TabIndex = 34;
            button32.Text = "Genera la parola";
            button32.UseVisualStyleBackColor = true;
            button32.Click += button32_Click;
            // 
            // Bottonefacile
            // 
            Bottonefacile.Location = new Point(133, 137);
            Bottonefacile.Name = "Bottonefacile";
            Bottonefacile.Size = new Size(75, 23);
            Bottonefacile.TabIndex = 35;
            Bottonefacile.Text = "Facile";
            Bottonefacile.UseVisualStyleBackColor = true;
            Bottonefacile.Click += button27_Click;
            // 
            // button33
            // 
            button33.Location = new Point(133, 179);
            button33.Name = "button33";
            button33.Size = new Size(75, 23);
            button33.TabIndex = 36;
            button33.Text = "Medio";
            button33.UseVisualStyleBackColor = true;
            button33.Click += button33_Click;
            // 
            // button34
            // 
            button34.Location = new Point(133, 226);
            button34.Name = "button34";
            button34.Size = new Size(75, 23);
            button34.TabIndex = 37;
            button34.Text = "Difficile";
            button34.UseVisualStyleBackColor = true;
            button34.Click += button34_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(426, 319);
            label4.Name = "label4";
            label4.Size = new Size(0, 65);
            label4.TabIndex = 38;
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 450);
            Controls.Add(label4);
            Controls.Add(button32);
            Controls.Add(button31);
            Controls.Add(label3);
            Controls.Add(film);
            Controls.Add(animali);
            Controls.Add(sport);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Bottonefacile);
            Controls.Add(button33);
            Controls.Add(button34);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button sport;
        private Button animali;
        private Button film;
        private Label label3;
        private Button button31;
        private Button button32;
        private Button Bottonefacile;
        private Button button33;
        private Button button34;
        private Label label4;
    }
}
