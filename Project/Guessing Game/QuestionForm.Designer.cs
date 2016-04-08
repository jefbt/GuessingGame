using System;

namespace Guessing_Game
{
    partial class QuestionForm
    {
        /// <summary>
        /// Minimum form width, enough to show both buttons.
        /// </summary>
        private const int MIN_WITDH = 200;
        
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

        /// <summary>
        /// Adjusts the new text and the size of the form.
        /// </summary>
        private void AdjustForm()
        {
            ShowCurrentQuestion();

            int width = questionLabel.Size.Width + 60;
            if (width < MIN_WITDH)
            {
                width = MIN_WITDH;
            }

            this.Size = new System.Drawing.Size(width, this.Size.Height);
        }

        /// <summary>
        /// Change the label text to show the current description
        /// </summary>
        private void ShowCurrentQuestion()
        {
            questionLabel.Text = PlayerData.CurrentDescription();
        }

        /// <summary>
        /// Answer the current question, and makes the question selector go down in the question tree. Open the next form, add animal or end the game.
        /// </summary>
        /// <param name="yes">true if the question was answered yes, false otherwise</param>
        private void AnswerCurrentQuestion(bool yes)
        {
            PlayerData.AnswerQuestion(yes);

            if (PlayerData.CurrentQuestion() != null)
            {
                AdjustForm();
                if (PlayerData.CurrentQuestionType() == Question.Type.Animal)
                {
                    PlayerData.lastAnimal = PlayerData.CurrentQuestion().GetDescription();
                }
            }
            else
            {
                if (yes)
                {
                    WinScreenForm winScreenForm = new WinScreenForm();
                    winScreenForm.Show();
                    this.Hide();
                }
                else
                {
                    AnimalAddForm animalAddForm = new AnimalAddForm();
                    animalAddForm.Show();
                    this.Hide();
                }
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.questionContainerPanel = new System.Windows.Forms.Panel();
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonYes
            // 
            this.buttonYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonYes.Location = new System.Drawing.Point(266, 73);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(75, 23);
            this.buttonYes.TabIndex = 0;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonNo.Location = new System.Drawing.Point(347, 73);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 1;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // questionContainerPanel
            // 
            this.questionContainerPanel.AutoSize = true;
            this.questionContainerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.questionContainerPanel.BackColor = System.Drawing.Color.White;
            this.questionContainerPanel.Controls.Add(this.questionLabel);
            this.questionContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.questionContainerPanel.Name = "questionContainerPanel";
            this.questionContainerPanel.Size = new System.Drawing.Size(434, 58);
            this.questionContainerPanel.TabIndex = 3;
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(12, 23);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(395, 13);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Amor amor amor amor amor amor compaixão aceitação compaixão aceitação amor";
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 108);
            this.ControlBox = false;
            this.Controls.Add(this.questionContainerPanel);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game";
            this.questionContainerPanel.ResumeLayout(false);
            this.questionContainerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Panel questionContainerPanel;
        private System.Windows.Forms.Label questionLabel;
    }
}