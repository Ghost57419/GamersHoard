namespace SeniorDesignProject
{
    partial class MainScreen
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.databaseContainer = new System.Windows.Forms.Panel();
            this.btnAdvSer = new System.Windows.Forms.Button();
            this.btnNewLib = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.serNav = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GameInstance01 = new System.Windows.Forms.Panel();
            this.gameDetails01 = new System.Windows.Forms.Button();
            this.Genre01 = new System.Windows.Forms.Label();
            this.Title01 = new System.Windows.Forms.Label();
            this.gameArt01 = new System.Windows.Forms.PictureBox();
            this.serRec = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GameInstance01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameArt01)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.databaseContainer);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdvSer);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewLib);
            this.splitContainer1.Panel1.Controls.Add(this.btnHome);
            this.splitContainer1.Panel1.Controls.Add(this.serNav);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.GameInstance01);
            this.splitContainer1.Panel2.Controls.Add(this.serRec);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 0;
            // 
            // databaseContainer
            // 
            this.databaseContainer.AutoScroll = true;
            this.databaseContainer.AutoSize = true;
            this.databaseContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.databaseContainer.Location = new System.Drawing.Point(12, 38);
            this.databaseContainer.Name = "databaseContainer";
            this.databaseContainer.Size = new System.Drawing.Size(146, 245);
            this.databaseContainer.TabIndex = 5;
            // 
            // btnAdvSer
            // 
            this.btnAdvSer.Location = new System.Drawing.Point(11, 349);
            this.btnAdvSer.Name = "btnAdvSer";
            this.btnAdvSer.Size = new System.Drawing.Size(100, 35);
            this.btnAdvSer.TabIndex = 4;
            this.btnAdvSer.Text = "Advanced Search";
            this.btnAdvSer.UseVisualStyleBackColor = true;
            // 
            // btnNewLib
            // 
            this.btnNewLib.Location = new System.Drawing.Point(12, 390);
            this.btnNewLib.Name = "btnNewLib";
            this.btnNewLib.Size = new System.Drawing.Size(100, 35);
            this.btnNewLib.TabIndex = 3;
            this.btnNewLib.Text = "+ New Library";
            this.btnNewLib.UseVisualStyleBackColor = true;
            this.btnNewLib.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 308);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(101, 35);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // serNav
            // 
            this.serNav.Location = new System.Drawing.Point(12, 12);
            this.serNav.Name = "serNav";
            this.serNav.Size = new System.Drawing.Size(100, 20);
            this.serNav.TabIndex = 1;
            this.serNav.Text = "Search..";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(37, 249);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 166);
            this.panel3.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "View Details";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Title";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 104);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(433, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 166);
            this.panel2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "View Details";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Title";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 104);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(224, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 166);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "View Details";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GameInstance01
            // 
            this.GameInstance01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameInstance01.Controls.Add(this.gameDetails01);
            this.GameInstance01.Controls.Add(this.Genre01);
            this.GameInstance01.Controls.Add(this.Title01);
            this.GameInstance01.Controls.Add(this.gameArt01);
            this.GameInstance01.Location = new System.Drawing.Point(37, 51);
            this.GameInstance01.Name = "GameInstance01";
            this.GameInstance01.Size = new System.Drawing.Size(103, 166);
            this.GameInstance01.TabIndex = 4;
            this.GameInstance01.Paint += new System.Windows.Forms.PaintEventHandler(this.GameInstance01_Paint);
            // 
            // gameDetails01
            // 
            this.gameDetails01.Location = new System.Drawing.Point(3, 139);
            this.gameDetails01.Name = "gameDetails01";
            this.gameDetails01.Size = new System.Drawing.Size(96, 23);
            this.gameDetails01.TabIndex = 3;
            this.gameDetails01.Text = "View Details";
            this.gameDetails01.UseVisualStyleBackColor = true;
            // 
            // Genre01
            // 
            this.Genre01.AutoSize = true;
            this.Genre01.Location = new System.Drawing.Point(4, 123);
            this.Genre01.Name = "Genre01";
            this.Genre01.Size = new System.Drawing.Size(36, 13);
            this.Genre01.TabIndex = 2;
            this.Genre01.Text = "Genre";
            this.Genre01.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // Title01
            // 
            this.Title01.AutoSize = true;
            this.Title01.Location = new System.Drawing.Point(3, 106);
            this.Title01.Name = "Title01";
            this.Title01.Size = new System.Drawing.Size(27, 13);
            this.Title01.TabIndex = 1;
            this.Title01.Text = "Title";
            this.Title01.Click += new System.EventHandler(this.label4_Click);
            // 
            // gameArt01
            // 
            this.gameArt01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameArt01.Location = new System.Drawing.Point(0, 0);
            this.gameArt01.Name = "gameArt01";
            this.gameArt01.Size = new System.Drawing.Size(103, 104);
            this.gameArt01.TabIndex = 0;
            this.gameArt01.TabStop = false;
            this.gameArt01.Click += new System.EventHandler(this.gameArt01_Click);
            // 
            // serRec
            // 
            this.serRec.Location = new System.Drawing.Point(184, 12);
            this.serRec.Name = "serRec";
            this.serRec.Size = new System.Drawing.Size(222, 20);
            this.serRec.TabIndex = 3;
            this.serRec.Text = "Search Recommendations..";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GameInstance01.ResumeLayout(false);
            this.GameInstance01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameArt01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox serNav;
        private System.Windows.Forms.TextBox serRec;
        private System.Windows.Forms.Button btnNewLib;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAdvSer;
        private System.Windows.Forms.Panel GameInstance01;
        private System.Windows.Forms.Label Title01;
        private System.Windows.Forms.PictureBox gameArt01;
        private System.Windows.Forms.Label Genre01;
        private System.Windows.Forms.Button gameDetails01;
        private System.Windows.Forms.Panel databaseContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

