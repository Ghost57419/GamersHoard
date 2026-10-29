namespace SeniorDesignProject
{
    partial class GameSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSearch));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gameName = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.lastImg = new System.Windows.Forms.Button();
            this.nextImg = new System.Windows.Forms.Button();
            this.gameImg = new System.Windows.Forms.PictureBox();
            this.Descr = new System.Windows.Forms.Label();
            this.gameArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameArt)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Enabled = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gameName);
            this.splitContainer1.Panel1.Controls.Add(this.backButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lastImg);
            this.splitContainer1.Panel2.Controls.Add(this.nextImg);
            this.splitContainer1.Panel2.Controls.Add(this.gameImg);
            this.splitContainer1.Panel2.Controls.Add(this.Descr);
            this.splitContainer1.Panel2.Controls.Add(this.gameArt);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1600, 865);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.Location = new System.Drawing.Point(590, 33);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(285, 76);
            this.gameName.TabIndex = 1;
            this.gameName.Text = "Deus Ex";
            this.gameName.Click += new System.EventHandler(this.label1_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(28, 22);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(142, 82);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastImg
            // 
            this.lastImg.Location = new System.Drawing.Point(548, 161);
            this.lastImg.Name = "lastImg";
            this.lastImg.Size = new System.Drawing.Size(94, 161);
            this.lastImg.TabIndex = 4;
            this.lastImg.Text = "Last Image";
            this.lastImg.UseVisualStyleBackColor = true;
            // 
            // nextImg
            // 
            this.nextImg.Location = new System.Drawing.Point(1423, 161);
            this.nextImg.Name = "nextImg";
            this.nextImg.Size = new System.Drawing.Size(94, 161);
            this.nextImg.TabIndex = 3;
            this.nextImg.Text = "Next Image";
            this.nextImg.UseVisualStyleBackColor = true;
            this.nextImg.Click += new System.EventHandler(this.button2_Click);
            // 
            // gameImg
            // 
            this.gameImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameImg.Image = ((System.Drawing.Image)(resources.GetObject("gameImg.Image")));
            this.gameImg.Location = new System.Drawing.Point(698, 56);
            this.gameImg.Name = "gameImg";
            this.gameImg.Size = new System.Drawing.Size(640, 360);
            this.gameImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameImg.TabIndex = 2;
            this.gameImg.TabStop = false;
            // 
            // Descr
            // 
            this.Descr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Descr.Location = new System.Drawing.Point(520, 460);
            this.Descr.Name = "Descr";
            this.Descr.Size = new System.Drawing.Size(998, 210);
            this.Descr.TabIndex = 1;
            this.Descr.Text = "This game is real real fun I had a great time playing it. This is the description" +
    " for Deus Ex (2000)";
            this.Descr.Click += new System.EventHandler(this.label2_Click);
            // 
            // gameArt
            // 
            this.gameArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameArt.Image = ((System.Drawing.Image)(resources.GetObject("gameArt.Image")));
            this.gameArt.Location = new System.Drawing.Point(38, 40);
            this.gameArt.Name = "gameArt";
            this.gameArt.Size = new System.Drawing.Size(438, 630);
            this.gameArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameArt.TabIndex = 0;
            this.gameArt.TabStop = false;
            // 
            // GameSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GameSearch";
            this.Size = new System.Drawing.Size(1600, 865);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox gameArt;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label Descr;
        private System.Windows.Forms.PictureBox gameImg;
        private System.Windows.Forms.Button nextImg;
        private System.Windows.Forms.Button lastImg;
    }
}