namespace SeniorDesignProject
{
    partial class databaseInstance
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
            this.clark = new System.Windows.Forms.Panel();
            this.clarksSon = new System.Windows.Forms.Label();
            this.clark.SuspendLayout();
            this.SuspendLayout();
            // 
            // clark
            // 
            this.clark.AutoSize = true;
            this.clark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clark.Controls.Add(this.clarksSon);
            this.clark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clark.Location = new System.Drawing.Point(0, 0);
            this.clark.Name = "clark";
            this.clark.Size = new System.Drawing.Size(114, 51);
            this.clark.TabIndex = 0;
            this.clark.Click += new System.EventHandler(this.clark_Click);
            this.clark.Paint += new System.Windows.Forms.PaintEventHandler(this.clark_Paint);
            // 
            // clarksSon
            // 
            this.clarksSon.AutoSize = true;
            this.clarksSon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clarksSon.Location = new System.Drawing.Point(26, 16);
            this.clarksSon.Name = "clarksSon";
            this.clarksSon.Size = new System.Drawing.Size(53, 13);
            this.clarksSon.TabIndex = 0;
            this.clarksSon.Text = "Database";
            this.clarksSon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // databaseInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.clark);
            this.Name = "databaseInstance";
            this.Size = new System.Drawing.Size(114, 51);
            this.clark.ResumeLayout(false);
            this.clark.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel clark;
        private System.Windows.Forms.Label clarksSon;
    }
}
