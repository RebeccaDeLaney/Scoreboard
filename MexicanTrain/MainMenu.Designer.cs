namespace MexicanTrain
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.newGameButton = new System.Windows.Forms.Button();
            this.previousGamesButton = new System.Windows.Forms.Button();
            this.playersButton = new System.Windows.Forms.Button();
            this.mexicanTrainLabel = new System.Windows.Forms.Label();
            this.connectionTestForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.newGameButton.Location = new System.Drawing.Point(540, 250);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(250, 50);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // previousGamesButton
            // 
            this.previousGamesButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.previousGamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousGamesButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousGamesButton.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.previousGamesButton.Location = new System.Drawing.Point(540, 320);
            this.previousGamesButton.Margin = new System.Windows.Forms.Padding(2);
            this.previousGamesButton.Name = "previousGamesButton";
            this.previousGamesButton.Size = new System.Drawing.Size(250, 50);
            this.previousGamesButton.TabIndex = 1;
            this.previousGamesButton.Text = "Previous Games";
            this.previousGamesButton.UseVisualStyleBackColor = false;
            this.previousGamesButton.Click += new System.EventHandler(this.previousGamesButton_Click);
            // 
            // playersButton
            // 
            this.playersButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.playersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playersButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersButton.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.playersButton.Location = new System.Drawing.Point(540, 400);
            this.playersButton.Margin = new System.Windows.Forms.Padding(2);
            this.playersButton.Name = "playersButton";
            this.playersButton.Size = new System.Drawing.Size(250, 50);
            this.playersButton.TabIndex = 2;
            this.playersButton.Text = "Players";
            this.playersButton.UseVisualStyleBackColor = false;
            this.playersButton.Click += new System.EventHandler(this.playersButton_Click);
            // 
            // mexicanTrainLabel
            // 
            this.mexicanTrainLabel.Image = ((System.Drawing.Image)(resources.GetObject("mexicanTrainLabel.Image")));
            this.mexicanTrainLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mexicanTrainLabel.Location = new System.Drawing.Point(296, 144);
            this.mexicanTrainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mexicanTrainLabel.Name = "mexicanTrainLabel";
            this.mexicanTrainLabel.Size = new System.Drawing.Size(744, 74);
            this.mexicanTrainLabel.TabIndex = 4;
            this.mexicanTrainLabel.Text = " ";
            // 
            // connectionTestForm
            // 
            this.connectionTestForm.BackColor = System.Drawing.Color.DarkSlateGray;
            this.connectionTestForm.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.connectionTestForm.FlatAppearance.BorderSize = 5;
            this.connectionTestForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.connectionTestForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.connectionTestForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectionTestForm.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionTestForm.ForeColor = System.Drawing.Color.Silver;
            this.connectionTestForm.Location = new System.Drawing.Point(1100, 630);
            this.connectionTestForm.Margin = new System.Windows.Forms.Padding(0);
            this.connectionTestForm.Name = "connectionTestForm";
            this.connectionTestForm.Size = new System.Drawing.Size(150, 40);
            this.connectionTestForm.TabIndex = 5;
            this.connectionTestForm.Text = "Test Connection";
            this.connectionTestForm.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.connectionTestForm.UseVisualStyleBackColor = false;
            this.connectionTestForm.Click += new System.EventHandler(this.connectionTestForm_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.connectionTestForm);
            this.Controls.Add(this.mexicanTrainLabel);
            this.Controls.Add(this.playersButton);
            this.Controls.Add(this.previousGamesButton);
            this.Controls.Add(this.newGameButton);
            this.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "Scoreboard Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button previousGamesButton;
        private System.Windows.Forms.Button playersButton;
        private System.Windows.Forms.Label mexicanTrainLabel;
        private System.Windows.Forms.Button connectionTestForm;
    }
}

