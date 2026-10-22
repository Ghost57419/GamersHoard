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
            this.serRec = new System.Windows.Forms.TextBox();
            this.GameDisplayPnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
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
            this.splitContainer1.Panel2.Controls.Add(this.GameDisplayPnl);
            this.splitContainer1.Panel2.Controls.Add(this.serRec);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1600, 865);
            this.splitContainer1.SplitterDistance = 344;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // databaseContainer
            // 
            this.databaseContainer.AutoScroll = true;
            this.databaseContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.databaseContainer.Location = new System.Drawing.Point(24, 73);
            this.databaseContainer.Margin = new System.Windows.Forms.Padding(6);
            this.databaseContainer.Name = "databaseContainer";
            this.databaseContainer.Size = new System.Drawing.Size(290, 470);
            this.databaseContainer.TabIndex = 5;
            // 
            // btnAdvSer
            // 
            this.btnAdvSer.Location = new System.Drawing.Point(22, 671);
            this.btnAdvSer.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdvSer.Name = "btnAdvSer";
            this.btnAdvSer.Size = new System.Drawing.Size(200, 67);
            this.btnAdvSer.TabIndex = 4;
            this.btnAdvSer.Text = "Advanced Search";
            this.btnAdvSer.UseVisualStyleBackColor = true;
            // 
            // btnNewLib
            // 
            this.btnNewLib.Location = new System.Drawing.Point(24, 750);
            this.btnNewLib.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewLib.Name = "btnNewLib";
            this.btnNewLib.Size = new System.Drawing.Size(200, 67);
            this.btnNewLib.TabIndex = 3;
            this.btnNewLib.Text = "+ New Library";
            this.btnNewLib.UseVisualStyleBackColor = true;
            this.btnNewLib.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(24, 592);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(202, 67);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // serNav
            // 
            this.serNav.Location = new System.Drawing.Point(24, 23);
            this.serNav.Margin = new System.Windows.Forms.Padding(6);
            this.serNav.Name = "serNav";
            this.serNav.Size = new System.Drawing.Size(196, 31);
            this.serNav.TabIndex = 1;
            this.serNav.Text = "Search..";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // serRec
            // 
            this.serRec.Location = new System.Drawing.Point(408, 28);
            this.serRec.Margin = new System.Windows.Forms.Padding(6);
            this.serRec.Name = "serRec";
            this.serRec.Size = new System.Drawing.Size(440, 31);
            this.serRec.TabIndex = 3;
            this.serRec.Text = "Search Recommendations..";
            // 
            // GameDisplayPnl
            // 
            this.GameDisplayPnl.Location = new System.Drawing.Point(44, 96);
            this.GameDisplayPnl.Name = "GameDisplayPnl";
            this.GameDisplayPnl.Size = new System.Drawing.Size(1156, 725);
            this.GameDisplayPnl.TabIndex = 4;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel databaseContainer;
        private System.Windows.Forms.Panel GameDisplayPnl;
    }
}

