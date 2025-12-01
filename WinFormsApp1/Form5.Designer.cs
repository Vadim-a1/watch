namespace WinFormsApp1
{
    partial class Form5
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
            comboType = new ComboBox();
            txtName = new TextBox();
            listSquad = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnSort = new Button();
            numLevel = new NumericUpDown();
            btnRandom = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numLevel).BeginInit();
            SuspendLayout();
            // 
            // comboType
            // 
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(12, 12);
            comboType.Name = "comboType";
            comboType.Size = new Size(121, 23);
            comboType.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(120, 23);
            txtName.TabIndex = 1;
            // 
            // listSquad
            // 
            listSquad.FormattingEnabled = true;
            listSquad.ItemHeight = 15;
            listSquad.Location = new Point(12, 50);
            listSquad.Name = "listSquad";
            listSquad.Size = new Size(338, 214);
            listSquad.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(370, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(370, 50);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(370, 90);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 5;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // numLevel
            // 
            numLevel.Location = new Point(280, 12);
            numLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numLevel.Name = "numLevel";
            numLevel.Size = new Size(70, 23);
            numLevel.TabIndex = 7;
            numLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(370, 129);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(75, 23);
            btnRandom.TabIndex = 8;
            btnRandom.Text = "Random";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // button1
            // 
            button1.Location = new Point(370, 241);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(484, 281);
            Controls.Add(button1);
            Controls.Add(btnRandom);
            Controls.Add(numLevel);
            Controls.Add(btnSort);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(listSquad);
            Controls.Add(txtName);
            Controls.Add(comboType);
            Name = "Form5";
            Text = "Squad Manager";
            ((System.ComponentModel.ISupportInitialize)numLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox listSquad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.Button btnRandom;
        private Button button1;
    }
}