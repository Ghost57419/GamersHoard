namespace SeniorDesignProject
{
    partial class GamePanel
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
            this.GameInstance01 = new System.Windows.Forms.Panel();
            this.gameDetails01 = new System.Windows.Forms.Button();
            this.Genre01 = new System.Windows.Forms.Label();
            this.Title01 = new System.Windows.Forms.Label();
            this.gameArt01 = new System.Windows.Forms.PictureBox();
            this.GameInstance01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameArt01)).BeginInit();
            this.SuspendLayout();
            // 
            // GameInstance01
            // 
            this.GameInstance01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameInstance01.Controls.Add(this.gameDetails01);
            this.GameInstance01.Controls.Add(this.Genre01);
            this.GameInstance01.Controls.Add(this.Title01);
            this.GameInstance01.Controls.Add(this.gameArt01);
            this.GameInstance01.Location = new System.Drawing.Point(11, 17);
            this.GameInstance01.Margin = new System.Windows.Forms.Padding(6);
            this.GameInstance01.Name = "GameInstance01";
            this.GameInstance01.Size = new System.Drawing.Size(204, 317);
            this.GameInstance01.TabIndex = 5;
            // 
            // gameDetails01
            // 
            this.gameDetails01.Location = new System.Drawing.Point(6, 267);
            this.gameDetails01.Margin = new System.Windows.Forms.Padding(6);
            this.gameDetails01.Name = "gameDetails01";
            this.gameDetails01.Size = new System.Drawing.Size(192, 44);
            this.gameDetails01.TabIndex = 3;
            this.gameDetails01.Text = "View Details";
            this.gameDetails01.UseVisualStyleBackColor = true;
            // 
            // Genre01
            // 
            this.Genre01.AutoSize = true;
            this.Genre01.Location = new System.Drawing.Point(8, 237);
            this.Genre01.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Genre01.Name = "Genre01";
            this.Genre01.Size = new System.Drawing.Size(71, 25);
            this.Genre01.TabIndex = 2;
            this.Genre01.Text = "Genre";
            // 
            // Title01
            // 
            this.Title01.AutoSize = true;
            this.Title01.Location = new System.Drawing.Point(6, 204);
            this.Title01.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Title01.Name = "Title01";
            this.Title01.Size = new System.Drawing.Size(53, 25);
            this.Title01.TabIndex = 1;
            this.Title01.Text = "Title";
            // 
            // gameArt01
            // 
            this.gameArt01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameArt01.Location = new System.Drawing.Point(0, 0);
            this.gameArt01.Margin = new System.Windows.Forms.Padding(6);
            this.gameArt01.Name = "gameArt01";
            this.gameArt01.Size = new System.Drawing.Size(204, 198);
            this.gameArt01.TabIndex = 0;
            this.gameArt01.TabStop = false;
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GameInstance01);
            this.Name = "GamePanel";
            this.Size = new System.Drawing.Size(226, 351);
            this.GameInstance01.ResumeLayout(false);
            this.GameInstance01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameArt01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameInstance01;
        private System.Windows.Forms.Button gameDetails01;
        private System.Windows.Forms.Label Genre01;
        private System.Windows.Forms.Label Title01;
        private System.Windows.Forms.PictureBox gameArt01;
    }
}
