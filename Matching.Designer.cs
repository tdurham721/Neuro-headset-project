namespace speak_your_mind
{
    partial class Matching
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
            this.matchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.homeButton = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutButton = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // matchButton
            // 
            this.matchButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.matchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.matchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.matchButton.Location = new System.Drawing.Point(39, 181);
            this.matchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(101, 38);
            this.matchButton.TabIndex = 7;
            this.matchButton.Text = "Match";
            this.matchButton.UseVisualStyleBackColor = false;
            this.matchButton.Click += new System.EventHandler(this.matchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Word Matching";
            // 
            // pBar
            // 
            this.pBar.ForeColor = System.Drawing.Color.LemonChiffon;
            this.pBar.Location = new System.Drawing.Point(39, 245);
            this.pBar.Margin = new System.Windows.Forms.Padding(2);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(445, 18);
            this.pBar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(35, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "Once you click match, think of a word you\'ve trained on, and your word will appea" +
    "r on the screen.";
            // 
            // label3
            // 
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(200, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Result:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(290, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeButton,
            this.toolStripSeparator1,
            this.logoutButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(519, 36);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // homeButton
            // 
            this.homeButton.AutoSize = false;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(200, 35);
            this.homeButton.Text = "Home";
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(59, 33);
            this.logoutButton.Text = "Logout";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Matching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(519, 289);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matchButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Matching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speak Your Mind";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button matchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel homeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel logoutButton;
    }
}