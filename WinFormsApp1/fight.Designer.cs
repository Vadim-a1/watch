namespace WinFormsApp1
{
    partial class fight
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            progressBarHealth = new ProgressBar();
            progressBarMy = new ProgressBar();
            buttonDamage = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.b1f297f29906a5d297d4a2135baec857;
            pictureBox2.Location = new Point(31, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 211);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.pngtree_black_and_white_ghost_artwork_png_image_13664775;
            pictureBox1.Location = new Point(536, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // progressBarHealth
            // 
            progressBarHealth.Location = new Point(604, 375);
            progressBarHealth.Name = "progressBarHealth";
            progressBarHealth.Size = new Size(100, 23);
            progressBarHealth.TabIndex = 11;
            // 
            // progressBarMy
            // 
            progressBarMy.Location = new Point(87, 375);
            progressBarMy.Name = "progressBarMy";
            progressBarMy.Size = new Size(100, 23);
            progressBarMy.TabIndex = 12;
            // 
            // buttonDamage
            // 
            buttonDamage.Location = new Point(363, 304);
            buttonDamage.Name = "buttonDamage";
            buttonDamage.Size = new Size(75, 23);
            buttonDamage.TabIndex = 13;
            buttonDamage.Text = "button1";
            buttonDamage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.IndianRed;
            textBox1.Location = new Point(338, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 39);
            textBox1.TabIndex = 14;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // fight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._7aa9a61ba94e18cecf823ec06bd4823a;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(buttonDamage);
            Controls.Add(progressBarMy);
            Controls.Add(progressBarHealth);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "fight";
            Text = "Form5";
            Load += fight_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ProgressBar progressBarHealth;
        private ProgressBar progressBarMy;
        private Button buttonDamage;
        private TextBox textBox1;
    }
}