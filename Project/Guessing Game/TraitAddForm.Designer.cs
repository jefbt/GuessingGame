namespace Guessing_Game
{
    partial class TraitAddForm
    {
        private const string QUESTION_FIRST_PART = "A _________ but a ";
        private const string QUESTION_SECOND_PART = " does not (Fill it with an animal trait, like 'lives in water').";

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

        private void ChangeText()
        {
            labelQuestion.Text = QUESTION_FIRST_PART + PlayerData.lastAnimal + QUESTION_SECOND_PART;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.traitName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(374, 57);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(12, 9);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(383, 13);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.Text = "A _________ but a shark does not (Fill it with an animal trait, like \'lives in wa" +
    "ter\').";
            // 
            // traitName
            // 
            this.traitName.Location = new System.Drawing.Point(15, 25);
            this.traitName.Name = "traitName";
            this.traitName.Size = new System.Drawing.Size(434, 20);
            this.traitName.TabIndex = 3;
            // 
            // TraitAddForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 92);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.traitName);
            this.MaximizeBox = false;
            this.Name = "TraitAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox traitName;
    }
}