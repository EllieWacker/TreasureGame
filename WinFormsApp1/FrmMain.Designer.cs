namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btnTreasure2 = new Button();
            closedChests = new ImageList(components);
            btnTreasure7 = new Button();
            btnTreasure6 = new Button();
            btnTreasure5 = new Button();
            btnTreasure3 = new Button();
            btnTreasure1 = new Button();
            btnTreasure4 = new Button();
            gemList = new ImageList(components);
            messageText = new Label();
            openChest1 = new PictureBox();
            openChest2 = new PictureBox();
            openChest3 = new PictureBox();
            openChest4 = new PictureBox();
            openChest5 = new PictureBox();
            openChest6 = new PictureBox();
            openChest7 = new PictureBox();
            btnContinue = new Button();
            btnQuit = new Button();
            roundNumber = new Label();
            currentScoreText = new Label();
            ((System.ComponentModel.ISupportInitialize)openChest1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openChest2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openChest3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openChest4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openChest5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openChest6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openChest7).BeginInit();
            SuspendLayout();
            // 
            // btnTreasure2
            // 
            btnTreasure2.ImageIndex = 0;
            btnTreasure2.ImageList = closedChests;
            btnTreasure2.Location = new Point(228, 115);
            btnTreasure2.Name = "btnTreasure2";
            btnTreasure2.Size = new Size(110, 100);
            btnTreasure2.TabIndex = 0;
            btnTreasure2.UseVisualStyleBackColor = true;
            btnTreasure2.Click += click_treasure2;
            // 
            // closedChests
            // 
            closedChests.ColorDepth = ColorDepth.Depth32Bit;
            closedChests.ImageStream = (ImageListStreamer)resources.GetObject("closedChests.ImageStream");
            closedChests.TransparentColor = Color.Transparent;
            closedChests.Images.SetKeyName(0, "treasure_chest.jpeg");
            closedChests.Images.SetKeyName(1, "treasure_chest.jpeg");
            closedChests.Images.SetKeyName(2, "treasure_chest.jpeg");
            closedChests.Images.SetKeyName(3, "treasure_chest.jpeg");
            closedChests.Images.SetKeyName(4, "treasure_chest.jpeg");
            closedChests.Images.SetKeyName(5, "treasure_chest.jpeg");
            closedChests.Images.SetKeyName(6, "treasure_chest.jpeg");
            // 
            // btnTreasure7
            // 
            btnTreasure7.ImageIndex = 0;
            btnTreasure7.ImageList = closedChests;
            btnTreasure7.Location = new Point(545, 262);
            btnTreasure7.Name = "btnTreasure7";
            btnTreasure7.Size = new Size(110, 100);
            btnTreasure7.TabIndex = 1;
            btnTreasure7.UseVisualStyleBackColor = true;
            btnTreasure7.Click += click_treasure7;
            // 
            // btnTreasure6
            // 
            btnTreasure6.ImageIndex = 0;
            btnTreasure6.ImageList = closedChests;
            btnTreasure6.Location = new Point(346, 278);
            btnTreasure6.Name = "btnTreasure6";
            btnTreasure6.Size = new Size(110, 100);
            btnTreasure6.TabIndex = 2;
            btnTreasure6.UseVisualStyleBackColor = true;
            btnTreasure6.Click += click_treasure6;
            // 
            // btnTreasure5
            // 
            btnTreasure5.ImageIndex = 0;
            btnTreasure5.ImageList = closedChests;
            btnTreasure5.Location = new Point(142, 262);
            btnTreasure5.Name = "btnTreasure5";
            btnTreasure5.Size = new Size(110, 100);
            btnTreasure5.TabIndex = 3;
            btnTreasure5.UseVisualStyleBackColor = true;
            btnTreasure5.Click += click_treasure5;
            // 
            // btnTreasure3
            // 
            btnTreasure3.ImageIndex = 0;
            btnTreasure3.ImageList = closedChests;
            btnTreasure3.Location = new Point(456, 117);
            btnTreasure3.Name = "btnTreasure3";
            btnTreasure3.Size = new Size(110, 100);
            btnTreasure3.TabIndex = 4;
            btnTreasure3.UseVisualStyleBackColor = true;
            btnTreasure3.Click += click_treasure3;
            // 
            // btnTreasure1
            // 
            btnTreasure1.ImageIndex = 0;
            btnTreasure1.ImageList = closedChests;
            btnTreasure1.Location = new Point(35, 139);
            btnTreasure1.Name = "btnTreasure1";
            btnTreasure1.Size = new Size(110, 100);
            btnTreasure1.TabIndex = 5;
            btnTreasure1.UseVisualStyleBackColor = true;
            btnTreasure1.Click += click_treasure1;
            // 
            // btnTreasure4
            // 
            btnTreasure4.ImageIndex = 0;
            btnTreasure4.ImageList = closedChests;
            btnTreasure4.Location = new Point(639, 137);
            btnTreasure4.Name = "btnTreasure4";
            btnTreasure4.Size = new Size(110, 100);
            btnTreasure4.TabIndex = 6;
            btnTreasure4.UseVisualStyleBackColor = true;
            btnTreasure4.Click += click_treasure4;
            // 
            // gemList
            // 
            gemList.ColorDepth = ColorDepth.Depth32Bit;
            gemList.ImageStream = (ImageListStreamer)resources.GetObject("gemList.ImageStream");
            gemList.TransparentColor = Color.Transparent;
            gemList.Images.SetKeyName(0, "open_chest_gem.jpeg");
            gemList.Images.SetKeyName(1, "empty_open.jpeg");
            gemList.Images.SetKeyName(2, "empty_open.jpeg");
            gemList.Images.SetKeyName(3, "empty_open.jpeg");
            gemList.Images.SetKeyName(4, "empty_open.jpeg");
            gemList.Images.SetKeyName(5, "empty_open.jpeg");
            gemList.Images.SetKeyName(6, "empty_open.jpeg");
            // 
            // messageText
            // 
            messageText.BackColor = Color.Transparent;
            messageText.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageText.Location = new Point(159, 18);
            messageText.Name = "messageText";
            messageText.Size = new Size(479, 84);
            messageText.TabIndex = 7;
            messageText.Text = "Guess which chest holds the treasure!";
            messageText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openChest1
            // 
            openChest1.Location = new Point(35, 141);
            openChest1.Name = "openChest1";
            openChest1.Size = new Size(110, 98);
            openChest1.SizeMode = PictureBoxSizeMode.Zoom;
            openChest1.TabIndex = 8;
            openChest1.TabStop = false;
            openChest1.Visible = false;
            // 
            // openChest2
            // 
            openChest2.Location = new Point(228, 117);
            openChest2.Name = "openChest2";
            openChest2.Size = new Size(110, 100);
            openChest2.SizeMode = PictureBoxSizeMode.Zoom;
            openChest2.TabIndex = 9;
            openChest2.TabStop = false;
            openChest2.Visible = false;
            // 
            // openChest3
            // 
            openChest3.Location = new Point(456, 117);
            openChest3.Name = "openChest3";
            openChest3.Size = new Size(110, 100);
            openChest3.SizeMode = PictureBoxSizeMode.Zoom;
            openChest3.TabIndex = 10;
            openChest3.TabStop = false;
            openChest3.Visible = false;
            // 
            // openChest4
            // 
            openChest4.Location = new Point(639, 135);
            openChest4.Name = "openChest4";
            openChest4.Size = new Size(110, 102);
            openChest4.SizeMode = PictureBoxSizeMode.Zoom;
            openChest4.TabIndex = 11;
            openChest4.TabStop = false;
            openChest4.Visible = false;
            // 
            // openChest5
            // 
            openChest5.Location = new Point(142, 262);
            openChest5.Name = "openChest5";
            openChest5.Size = new Size(110, 100);
            openChest5.SizeMode = PictureBoxSizeMode.Zoom;
            openChest5.TabIndex = 12;
            openChest5.TabStop = false;
            openChest5.Visible = false;
            // 
            // openChest6
            // 
            openChest6.Location = new Point(345, 278);
            openChest6.Name = "openChest6";
            openChest6.Size = new Size(110, 100);
            openChest6.SizeMode = PictureBoxSizeMode.Zoom;
            openChest6.TabIndex = 13;
            openChest6.TabStop = false;
            openChest6.Visible = false;
            // 
            // openChest7
            // 
            openChest7.Location = new Point(545, 262);
            openChest7.Name = "openChest7";
            openChest7.Size = new Size(110, 100);
            openChest7.SizeMode = PictureBoxSizeMode.Zoom;
            openChest7.TabIndex = 14;
            openChest7.TabStop = false;
            openChest7.Visible = false;
            openChest7.Click += click_treasure7;
            // 
            // btnContinue
            // 
            btnContinue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinue.Location = new Point(36, 63);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(109, 39);
            btnContinue.TabIndex = 15;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Visible = false;
            btnContinue.Click += continue_click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(649, 63);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(104, 39);
            btnQuit.TabIndex = 16;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Visible = false;
            btnQuit.Click += quit_click;
            // 
            // roundNumber
            // 
            roundNumber.BackColor = Color.Transparent;
            roundNumber.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            roundNumber.ForeColor = SystemColors.ActiveCaptionText;
            roundNumber.Location = new Point(12, 377);
            roundNumber.Name = "roundNumber";
            roundNumber.Size = new Size(178, 41);
            roundNumber.TabIndex = 17;
            roundNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // currentScoreText
            // 
            currentScoreText.BackColor = Color.Transparent;
            currentScoreText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            currentScoreText.ForeColor = SystemColors.ActiveCaptionText;
            currentScoreText.Location = new Point(610, 377);
            currentScoreText.Name = "currentScoreText";
            currentScoreText.Size = new Size(178, 41);
            currentScoreText.TabIndex = 18;
            currentScoreText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(currentScoreText);
            Controls.Add(roundNumber);
            Controls.Add(btnQuit);
            Controls.Add(btnContinue);
            Controls.Add(openChest7);
            Controls.Add(openChest6);
            Controls.Add(openChest5);
            Controls.Add(openChest4);
            Controls.Add(openChest3);
            Controls.Add(openChest2);
            Controls.Add(openChest1);
            Controls.Add(messageText);
            Controls.Add(btnTreasure4);
            Controls.Add(btnTreasure1);
            Controls.Add(btnTreasure3);
            Controls.Add(btnTreasure5);
            Controls.Add(btnTreasure6);
            Controls.Add(btnTreasure7);
            Controls.Add(btnTreasure2);
            DoubleBuffered = true;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pick a Chest!";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)openChest1).EndInit();
            ((System.ComponentModel.ISupportInitialize)openChest2).EndInit();
            ((System.ComponentModel.ISupportInitialize)openChest3).EndInit();
            ((System.ComponentModel.ISupportInitialize)openChest4).EndInit();
            ((System.ComponentModel.ISupportInitialize)openChest5).EndInit();
            ((System.ComponentModel.ISupportInitialize)openChest6).EndInit();
            ((System.ComponentModel.ISupportInitialize)openChest7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTreasure2;
        private Button btnTreasure7;
        private Button btnTreasure6;
        private Button btnTreasure5;
        private Button btnTreasure3;
        private Button btnTreasure1;
        private Button btnTreasure4;
        private ImageList gemList;
        private ImageList closedChests;
        private Label messageText;
        private PictureBox openChest1;
        private PictureBox openChest2;
        private PictureBox openChest3;
        private PictureBox openChest4;
        private PictureBox openChest5;
        private PictureBox openChest6;
        private PictureBox openChest7;
        private Button btnContinue;
        private Button btnQuit;
        private Label roundNumber;
        private Label currentScoreText;
    }
}
