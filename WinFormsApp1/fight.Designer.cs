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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.b1f297f29906a5d297d4a2135baec857;
            pictureBox2.Location = new Point(81, 158);
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
            pictureBox1.Location = new Point(634, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // progressBarHealth
            // 
            progressBarHealth.Location = new Point(692, 375);
            progressBarHealth.Name = "progressBarHealth";
            progressBarHealth.Size = new Size(100, 23);
            progressBarHealth.TabIndex = 11;
            // 
            // progressBarMy
            // 
            progressBarMy.Location = new Point(133, 375);
            progressBarMy.Name = "progressBarMy";
            progressBarMy.Size = new Size(100, 23);
            progressBarMy.TabIndex = 12;
            // 
            // buttonDamage
            // 
            buttonDamage.Location = new Point(433, 313);
            buttonDamage.Name = "buttonDamage";
            buttonDamage.Size = new Size(95, 38);
            buttonDamage.TabIndex = 13;
            buttonDamage.Text = "ATTACK";
            buttonDamage.UseVisualStyleBackColor = true;
            buttonDamage.Click += buttonDamage_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(272, 197);
            label1.Name = "label1";
            label1.Size = new Size(0, 86);
            label1.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.DarkGray;
            button1.Location = new Point(625, 29);
            button1.Name = "button1";
            button1.Size = new Size(224, 49);
            button1.TabIndex = 16;
            button1.Text = "Обновить\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.DarkGray;
            button2.Location = new Point(12, 29);
            button2.Name = "button2";
            button2.Size = new Size(350, 49);
            button2.TabIndex = 17;
            button2.Text = "Выход\r\n\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // fight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._7aa9a61ba94e18cecf823ec06bd4823a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(918, 510);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(buttonDamage);
            Controls.Add(progressBarMy);
            Controls.Add(progressBarHealth);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "fight";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "S";
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
        private Label label1;
        private Button button1;
        private Button button2;
    }
}