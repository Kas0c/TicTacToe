namespace TicTacToe
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
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            RestartButton = new Button();
            labelPlayer = new Label();
            labelMove = new Label();
            labelScore = new Label();
            labelO = new Label();
            labelX = new Label();
            scoreO = new Label();
            scoreX = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // b1
            // 
            b1.FlatAppearance.BorderSize = 0;
            b1.FlatStyle = FlatStyle.Flat;
            b1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            b1.Location = new Point(12, 12);
            b1.Name = "b1";
            b1.Size = new Size(120, 120);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = true;
            b1.Click += Mark;
            // 
            // b2
            // 
            b2.FlatAppearance.BorderSize = 0;
            b2.FlatStyle = FlatStyle.Flat;
            b2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            b2.Location = new Point(138, 12);
            b2.Name = "b2";
            b2.Size = new Size(120, 120);
            b2.TabIndex = 1;
            b2.UseVisualStyleBackColor = true;
            b2.Click += Mark;
            // 
            // b3
            // 
            b3.FlatAppearance.BorderSize = 0;
            b3.FlatStyle = FlatStyle.Flat;
            b3.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            b3.Location = new Point(264, 12);
            b3.Name = "b3";
            b3.Size = new Size(120, 120);
            b3.TabIndex = 2;
            b3.UseVisualStyleBackColor = true;
            b3.Click += Mark;
            // 
            // b4
            // 
            b4.FlatAppearance.BorderSize = 0;
            b4.FlatStyle = FlatStyle.Flat;
            b4.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            b4.Location = new Point(12, 138);
            b4.Name = "b4";
            b4.Size = new Size(120, 120);
            b4.TabIndex = 3;
            b4.UseVisualStyleBackColor = true;
            b4.Click += Mark;
            // 
            // b5
            // 
            b5.FlatAppearance.BorderSize = 0;
            b5.FlatStyle = FlatStyle.Flat;
            b5.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            b5.Location = new Point(138, 138);
            b5.Name = "b5";
            b5.Size = new Size(120, 120);
            b5.TabIndex = 4;
            b5.UseVisualStyleBackColor = true;
            b5.Click += Mark;
            // 
            // b6
            // 
            b6.FlatAppearance.BorderSize = 0;
            b6.FlatStyle = FlatStyle.Flat;
            b6.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            b6.Location = new Point(264, 138);
            b6.Name = "b6";
            b6.Size = new Size(120, 120);
            b6.TabIndex = 5;
            b6.UseVisualStyleBackColor = true;
            b6.Click += Mark;
            // 
            // b7
            // 
            b7.FlatAppearance.BorderSize = 0;
            b7.FlatStyle = FlatStyle.Flat;
            b7.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            b7.Location = new Point(12, 264);
            b7.Name = "b7";
            b7.Size = new Size(120, 120);
            b7.TabIndex = 6;
            b7.UseVisualStyleBackColor = true;
            b7.Click += Mark;
            // 
            // b8
            // 
            b8.FlatAppearance.BorderSize = 0;
            b8.FlatStyle = FlatStyle.Flat;
            b8.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            b8.Location = new Point(138, 264);
            b8.Name = "b8";
            b8.Size = new Size(120, 120);
            b8.TabIndex = 7;
            b8.UseVisualStyleBackColor = true;
            b8.Click += Mark;
            // 
            // b9
            // 
            b9.FlatAppearance.BorderSize = 0;
            b9.FlatStyle = FlatStyle.Flat;
            b9.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            b9.Location = new Point(264, 264);
            b9.Name = "b9";
            b9.Size = new Size(120, 120);
            b9.TabIndex = 8;
            b9.UseVisualStyleBackColor = true;
            b9.Click += Mark;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.WindowText;
            pictureBox1.Location = new Point(121, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 372);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.WindowText;
            pictureBox2.Location = new Point(246, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 372);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.WindowText;
            pictureBox3.Location = new Point(12, 252);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(372, 25);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.WindowText;
            pictureBox4.Location = new Point(12, 124);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(372, 25);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // RestartButton
            // 
            RestartButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            RestartButton.Location = new Point(480, 377);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(168, 46);
            RestartButton.TabIndex = 13;
            RestartButton.Text = "Restart";
            RestartButton.UseVisualStyleBackColor = true;
            RestartButton.Click += RestartButton_Click;
            // 
            // labelPlayer
            // 
            labelPlayer.AutoSize = true;
            labelPlayer.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlayer.Location = new Point(480, 38);
            labelPlayer.Name = "labelPlayer";
            labelPlayer.Size = new Size(127, 54);
            labelPlayer.TabIndex = 9;
            labelPlayer.Text = "Ruch:";
            // 
            // labelMove
            // 
            labelMove.AutoSize = true;
            labelMove.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelMove.Location = new Point(613, 38);
            labelMove.Name = "labelMove";
            labelMove.Size = new Size(53, 54);
            labelMove.TabIndex = 14;
            labelMove.Text = "O";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelScore.Location = new Point(497, 107);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(142, 54);
            labelScore.TabIndex = 15;
            labelScore.Text = "Wynik";
            // 
            // labelO
            // 
            labelO.AutoSize = true;
            labelO.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelO.Location = new Point(438, 171);
            labelO.Name = "labelO";
            labelO.Size = new Size(64, 54);
            labelO.TabIndex = 16;
            labelO.Text = "O:";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelX.Location = new Point(588, 171);
            labelX.Name = "labelX";
            labelX.Size = new Size(60, 54);
            labelX.TabIndex = 17;
            labelX.Text = "X:";
            // 
            // scoreO
            // 
            scoreO.AutoSize = true;
            scoreO.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            scoreO.Location = new Point(497, 171);
            scoreO.Name = "scoreO";
            scoreO.Size = new Size(45, 54);
            scoreO.TabIndex = 18;
            scoreO.Text = "0";
            // 
            // scoreX
            // 
            scoreX.AutoSize = true;
            scoreX.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            scoreX.Location = new Point(637, 171);
            scoreX.Name = "scoreX";
            scoreX.Size = new Size(45, 54);
            scoreX.TabIndex = 19;
            scoreX.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 435);
            Controls.Add(scoreX);
            Controls.Add(scoreO);
            Controls.Add(labelX);
            Controls.Add(labelO);
            Controls.Add(labelScore);
            Controls.Add(labelMove);
            Controls.Add(labelPlayer);
            Controls.Add(RestartButton);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button RestartButton;
        private Label labelPlayer;
        private Label labelMove;
        private Label labelScore;
        private Label labelO;
        private Label labelX;
        private Label scoreO;
        private Label scoreX;
    }
}