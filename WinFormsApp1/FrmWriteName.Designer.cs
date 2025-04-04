namespace PresentationLayer
{
    partial class FrmWriteName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWriteName));
            lblName = new Label();
            txtName = new TextBox();
            lblHighestScore = new Label();
            lblCurrentScore = new Label();
            btnNewGame = new Button();
            lblThanks = new Label();
            btnLeader = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(297, 152);
            lblName.Name = "lblName";
            lblName.Size = new Size(205, 36);
            lblName.TabIndex = 0;
            lblName.Text = "Enter your name";
            // 
            // txtName
            // 
            txtName.Location = new Point(326, 191);
            txtName.Name = "txtName";
            txtName.Size = new Size(147, 27);
            txtName.TabIndex = 1;
            // 
            // lblHighestScore
            // 
            lblHighestScore.BackColor = Color.Transparent;
            lblHighestScore.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            lblHighestScore.Location = new Point(546, 148);
            lblHighestScore.Name = "lblHighestScore";
            lblHighestScore.Size = new Size(231, 107);
            lblHighestScore.TabIndex = 6;
            lblHighestScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentScore
            // 
            lblCurrentScore.BackColor = Color.Transparent;
            lblCurrentScore.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            lblCurrentScore.Location = new Point(12, 146);
            lblCurrentScore.Name = "lblCurrentScore";
            lblCurrentScore.Size = new Size(231, 110);
            lblCurrentScore.TabIndex = 7;
            lblCurrentScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Maiandra GD", 13.8F, FontStyle.Bold);
            btnNewGame.Location = new Point(185, 345);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(179, 62);
            btnNewGame.TabIndex = 22;
            btnNewGame.Text = "Play Again";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // lblThanks
            // 
            lblThanks.AutoSize = true;
            lblThanks.BackColor = Color.Transparent;
            lblThanks.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThanks.Location = new Point(201, 34);
            lblThanks.Name = "lblThanks";
            lblThanks.Size = new Size(398, 59);
            lblThanks.TabIndex = 23;
            lblThanks.Text = "Thanks For Playing!";
            // 
            // btnLeader
            // 
            btnLeader.Font = new Font("Maiandra GD", 13.8F, FontStyle.Bold);
            btnLeader.Location = new Point(437, 345);
            btnLeader.Name = "btnLeader";
            btnLeader.Size = new Size(172, 62);
            btnLeader.TabIndex = 25;
            btnLeader.Text = "Leader Board";
            btnLeader.UseVisualStyleBackColor = true;
            btnLeader.Click += btnLeader_Click;
            // 
            // FrmWriteName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnLeader);
            Controls.Add(lblThanks);
            Controls.Add(btnNewGame);
            Controls.Add(lblCurrentScore);
            Controls.Add(lblHighestScore);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "FrmWriteName";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Scores";
            Load += FrmWriteName_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblHighestScore;
        private Label lblCurrentScore;
        private Button btnNewGame;
        private Label lblThanks;
        private Button btnLeader;
    }
}