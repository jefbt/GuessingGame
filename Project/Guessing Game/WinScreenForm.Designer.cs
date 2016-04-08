namespace Guessing_Game
{
    partial class WinScreenForm
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
            this.messageContainerPanel = new System.Windows.Forms.Panel();
            this.winLabel = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.messageContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageContainerPanel
            // 
            this.messageContainerPanel.BackColor = System.Drawing.Color.White;
            this.messageContainerPanel.Controls.Add(this.winLabel);
            this.messageContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.messageContainerPanel.Name = "messageContainerPanel";
            this.messageContainerPanel.Size = new System.Drawing.Size(142, 64);
            this.messageContainerPanel.TabIndex = 0;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Location = new System.Drawing.Point(12, 23);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(61, 13);
            this.winLabel.TabIndex = 0;
            this.winLabel.Text = "I win again!";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(55, 71);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // WinScreenForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonOK;
            this.ClientSize = new System.Drawing.Size(142, 106);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.messageContainerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game";
            this.messageContainerPanel.ResumeLayout(false);
            this.messageContainerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel messageContainerPanel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Button buttonOK;
    }
}