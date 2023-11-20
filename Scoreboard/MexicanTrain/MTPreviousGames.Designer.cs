namespace MexicanTrain
{
    partial class MTPreviousGames
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
            this.gameDateComboBox = new System.Windows.Forms.ComboBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.gameDateLabel = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameDateComboBox
            // 
            this.gameDateComboBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gameDateComboBox.ForeColor = System.Drawing.Color.DarkRed;
            this.gameDateComboBox.FormattingEnabled = true;
            this.gameDateComboBox.Location = new System.Drawing.Point(80, 150);
            this.gameDateComboBox.Name = "gameDateComboBox";
            this.gameDateComboBox.Size = new System.Drawing.Size(225, 32);
            this.gameDateComboBox.TabIndex = 0;
            this.gameDateComboBox.Text = "Date List";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuButton.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.menuButton.Location = new System.Drawing.Point(1135, 25);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(100, 40);
            this.menuButton.TabIndex = 10;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            // 
            // gameDateLabel
            // 
            this.gameDateLabel.Location = new System.Drawing.Point(500, 150);
            this.gameDateLabel.Name = "gameDateLabel";
            this.gameDateLabel.Size = new System.Drawing.Size(500, 40);
            this.gameDateLabel.TabIndex = 11;
            this.gameDateLabel.Text = "Game Date: XX/XX/XXXX";
            this.gameDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winnerLabel
            // 
            this.winnerLabel.Location = new System.Drawing.Point(625, 250);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(250, 40);
            this.winnerLabel.TabIndex = 14;
            this.winnerLabel.Text = "Winner: ";
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MTPreviousGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.gameDateLabel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.gameDateComboBox);
            this.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MTPreviousGames";
            this.Text = "MT Previous Games";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox gameDateComboBox;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label gameDateLabel;
        private System.Windows.Forms.Label winnerLabel;
    }
}