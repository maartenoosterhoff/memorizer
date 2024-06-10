namespace Mocca.Memorizer
{
    partial class FrmMain
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
            btnLoadDataFile = new Button();
            btnStartStop = new Button();
            btnQuestion = new Button();
            btnAnswer1 = new Button();
            btnAnswer2 = new Button();
            btnAnswer3 = new Button();
            btnAnswer4 = new Button();
            lblTotalAnswers = new Label();
            lblCorrectAnswers = new Label();
            lblIncorrectAnswers = new Label();
            txtTotalAnswers = new TextBox();
            txtCorrectAnswers = new TextBox();
            txtIncorrectAnswers = new TextBox();
            lblResultaat = new Label();
            SuspendLayout();
            // 
            // btnLoadDataFile
            // 
            btnLoadDataFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLoadDataFile.Location = new Point(12, 12);
            btnLoadDataFile.Name = "btnLoadDataFile";
            btnLoadDataFile.Size = new Size(790, 49);
            btnLoadDataFile.TabIndex = 0;
            btnLoadDataFile.Text = "Load data file";
            btnLoadDataFile.UseVisualStyleBackColor = true;
            btnLoadDataFile.Click += btnLoadDataFile_Click;
            // 
            // btnStartStop
            // 
            btnStartStop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStartStop.Location = new Point(12, 67);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(790, 49);
            btnStartStop.TabIndex = 1;
            btnStartStop.Text = "Start";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // btnQuestion
            // 
            btnQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuestion.Location = new Point(12, 154);
            btnQuestion.Name = "btnQuestion";
            btnQuestion.Size = new Size(350, 49);
            btnQuestion.TabIndex = 2;
            btnQuestion.Text = "button1";
            btnQuestion.UseVisualStyleBackColor = true;
            // 
            // btnAnswer1
            // 
            btnAnswer1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAnswer1.Location = new Point(450, 154);
            btnAnswer1.Name = "btnAnswer1";
            btnAnswer1.Size = new Size(350, 49);
            btnAnswer1.TabIndex = 3;
            btnAnswer1.Text = "button2";
            btnAnswer1.UseVisualStyleBackColor = true;
            btnAnswer1.Click += btnAnswer1_Click;
            // 
            // btnAnswer2
            // 
            btnAnswer2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAnswer2.Location = new Point(450, 209);
            btnAnswer2.Name = "btnAnswer2";
            btnAnswer2.Size = new Size(352, 49);
            btnAnswer2.TabIndex = 4;
            btnAnswer2.Text = "button3";
            btnAnswer2.UseVisualStyleBackColor = true;
            btnAnswer2.Click += btnAnswer2_Click;
            // 
            // btnAnswer3
            // 
            btnAnswer3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAnswer3.Location = new Point(450, 264);
            btnAnswer3.Name = "btnAnswer3";
            btnAnswer3.Size = new Size(352, 49);
            btnAnswer3.TabIndex = 5;
            btnAnswer3.Text = "button4";
            btnAnswer3.UseVisualStyleBackColor = true;
            btnAnswer3.Click += btnAnswer3_Click;
            // 
            // btnAnswer4
            // 
            btnAnswer4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAnswer4.Location = new Point(450, 319);
            btnAnswer4.Name = "btnAnswer4";
            btnAnswer4.Size = new Size(352, 49);
            btnAnswer4.TabIndex = 6;
            btnAnswer4.Text = "button5";
            btnAnswer4.UseVisualStyleBackColor = true;
            btnAnswer4.Click += btnAnswer4_Click;
            // 
            // lblTotalAnswers
            // 
            lblTotalAnswers.AutoSize = true;
            lblTotalAnswers.Location = new Point(12, 226);
            lblTotalAnswers.Name = "lblTotalAnswers";
            lblTotalAnswers.Size = new Size(109, 15);
            lblTotalAnswers.TabIndex = 7;
            lblTotalAnswers.Text = "Total answers given";
            // 
            // lblCorrectAnswers
            // 
            lblCorrectAnswers.AutoSize = true;
            lblCorrectAnswers.Location = new Point(12, 281);
            lblCorrectAnswers.Name = "lblCorrectAnswers";
            lblCorrectAnswers.Size = new Size(123, 15);
            lblCorrectAnswers.TabIndex = 8;
            lblCorrectAnswers.Text = "Correct answers given";
            // 
            // lblIncorrectAnswers
            // 
            lblIncorrectAnswers.AutoSize = true;
            lblIncorrectAnswers.Location = new Point(12, 308);
            lblIncorrectAnswers.Name = "lblIncorrectAnswers";
            lblIncorrectAnswers.Size = new Size(131, 15);
            lblIncorrectAnswers.TabIndex = 9;
            lblIncorrectAnswers.Text = "Incorrect answers given";
            // 
            // txtTotalAnswers
            // 
            txtTotalAnswers.Location = new Point(180, 223);
            txtTotalAnswers.Name = "txtTotalAnswers";
            txtTotalAnswers.Size = new Size(100, 23);
            txtTotalAnswers.TabIndex = 10;
            // 
            // txtCorrectAnswers
            // 
            txtCorrectAnswers.Location = new Point(180, 278);
            txtCorrectAnswers.Name = "txtCorrectAnswers";
            txtCorrectAnswers.Size = new Size(100, 23);
            txtCorrectAnswers.TabIndex = 11;
            // 
            // txtIncorrectAnswers
            // 
            txtIncorrectAnswers.Location = new Point(180, 305);
            txtIncorrectAnswers.Name = "txtIncorrectAnswers";
            txtIncorrectAnswers.Size = new Size(100, 23);
            txtIncorrectAnswers.TabIndex = 12;
            // 
            // lblResultaat
            // 
            lblResultaat.AutoSize = true;
            lblResultaat.Location = new Point(12, 353);
            lblResultaat.Name = "lblResultaat";
            lblResultaat.Size = new Size(38, 15);
            lblResultaat.TabIndex = 13;
            lblResultaat.Text = "label1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 387);
            Controls.Add(lblResultaat);
            Controls.Add(txtIncorrectAnswers);
            Controls.Add(txtCorrectAnswers);
            Controls.Add(txtTotalAnswers);
            Controls.Add(lblIncorrectAnswers);
            Controls.Add(lblCorrectAnswers);
            Controls.Add(lblTotalAnswers);
            Controls.Add(btnAnswer4);
            Controls.Add(btnAnswer3);
            Controls.Add(btnAnswer2);
            Controls.Add(btnAnswer1);
            Controls.Add(btnQuestion);
            Controls.Add(btnStartStop);
            Controls.Add(btnLoadDataFile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memorizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadDataFile;
        private Button btnStartStop;
        private Button btnQuestion;
        private Button btnAnswer1;
        private Button btnAnswer2;
        private Button btnAnswer3;
        private Button btnAnswer4;
        private Label lblTotalAnswers;
        private Label lblCorrectAnswers;
        private Label lblIncorrectAnswers;
        private TextBox txtTotalAnswers;
        private TextBox txtCorrectAnswers;
        private TextBox txtIncorrectAnswers;
        private Label lblResultaat;
    }
}
