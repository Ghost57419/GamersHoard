namespace SeniorDesignProject
{
    partial class gamePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gamePanel));
            this.gameInstance = new System.Windows.Forms.Panel();
            this.gameDetails = new System.Windows.Forms.Button();
            this.genre = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.gameArt = new System.Windows.Forms.PictureBox();
            this.gameInstance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameArt)).BeginInit();
            this.SuspendLayout();
            // 
            // gameInstance
            // 
            this.gameInstance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameInstance.Controls.Add(this.gameDetails);
            this.gameInstance.Controls.Add(this.genre);
            this.gameInstance.Controls.Add(this.title);
            this.gameInstance.Controls.Add(this.gameArt);
            this.gameInstance.Location = new System.Drawing.Point(12, 17);
            this.gameInstance.Margin = new System.Windows.Forms.Padding(6);
            this.gameInstance.Name = "gameInstance";
            this.gameInstance.Size = new System.Drawing.Size(204, 317);
            this.gameInstance.TabIndex = 5;
            // 
            // gameDetails
            // 
            this.gameDetails.Location = new System.Drawing.Point(6, 267);
            this.gameDetails.Margin = new System.Windows.Forms.Padding(6);
            this.gameDetails.Name = "gameDetails";
            this.gameDetails.Size = new System.Drawing.Size(192, 44);
            this.gameDetails.TabIndex = 3;
            this.gameDetails.Text = "View Details";
            this.gameDetails.UseVisualStyleBackColor = true;
            this.gameDetails.Click += new System.EventHandler(this.gameDetails01_Click);
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(8, 237);
            this.genre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(57, 25);
            this.genre.TabIndex = 2;
            this.genre.Text = "RPG";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(6, 204);
            this.title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(167, 25);
            this.title.TabIndex = 1;
            this.title.Text = "Deus Ex  (2000)";
            // 
            // gameArt
            // 
            this.gameArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameArt.Image = ((System.Drawing.Image)(resources.GetObject("gameArt.Image")));
            this.gameArt.Location = new System.Drawing.Point(0, 0);
            this.gameArt.Margin = new System.Windows.Forms.Padding(6);
            this.gameArt.Name = "gameArt";
            this.gameArt.Size = new System.Drawing.Size(204, 198);
            this.gameArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameArt.TabIndex = 0;
            this.gameArt.TabStop = false;
            // 
            // gamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gameInstance);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gamePanel";
            this.Size = new System.Drawing.Size(226, 352);
            this.gameInstance.ResumeLayout(false);
            this.gameInstance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameInstance;
        private System.Windows.Forms.Button gameDetails;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox gameArt;
    }
}
