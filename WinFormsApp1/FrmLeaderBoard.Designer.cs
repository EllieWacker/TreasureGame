namespace PresentationLayer
{
    partial class FrmLeaderBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLeaderBoard));
            datPlayerList = new DataGridView();
            lblLeaderBoard = new Label();
            lblGameOver = new Label();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)datPlayerList).BeginInit();
            SuspendLayout();
            // 
            // datPlayerList
            // 
            datPlayerList.AllowUserToAddRows = false;
            datPlayerList.AllowUserToDeleteRows = false;
            datPlayerList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datPlayerList.BackgroundColor = Color.MediumPurple;
            datPlayerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datPlayerList.Location = new Point(54, 154);
            datPlayerList.Margin = new Padding(3, 4, 3, 4);
            datPlayerList.MultiSelect = false;
            datPlayerList.Name = "datPlayerList";
            datPlayerList.ReadOnly = true;
            datPlayerList.RowHeadersWidth = 51;
            datPlayerList.ScrollBars = ScrollBars.Vertical;
            datPlayerList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datPlayerList.Size = new Size(693, 283);
            datPlayerList.TabIndex = 5;
            // 
            // lblLeaderBoard
            // 
            lblLeaderBoard.BackColor = Color.Transparent;
            lblLeaderBoard.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeaderBoard.ForeColor = SystemColors.ButtonFace;
            lblLeaderBoard.Location = new Point(272, 106);
            lblLeaderBoard.Name = "lblLeaderBoard";
            lblLeaderBoard.Size = new Size(257, 44);
            lblLeaderBoard.TabIndex = 25;
            lblLeaderBoard.Text = "Leader Board";
            lblLeaderBoard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGameOver
            // 
            lblGameOver.BackColor = Color.Transparent;
            lblGameOver.Font = new Font("Haettenschweiler", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameOver.ForeColor = SystemColors.ButtonHighlight;
            lblGameOver.Location = new Point(279, 9);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(242, 77);
            lblGameOver.TabIndex = 26;
            lblGameOver.Text = "Game Over";
            lblGameOver.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(25, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(103, 36);
            btnReturn.TabIndex = 27;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // FrmLeaderBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(lblGameOver);
            Controls.Add(lblLeaderBoard);
            Controls.Add(datPlayerList);
            Name = "FrmLeaderBoard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Leader Board";
            Load += FrmLeaderBoard_Load;
            ((System.ComponentModel.ISupportInitialize)datPlayerList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datPlayerList;
        private Label lblLeaderBoard;
        private Label lblGameOver;
        private Button btnReturn;
    }
}