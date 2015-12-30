namespace speak_your_mind
{
    partial class Start
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
            this.matchingButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.homeButton = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trainingButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // matchingButton
            // 
            this.matchingButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.matchingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.matchingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.matchingButton.Location = new System.Drawing.Point(29, 205);
            this.matchingButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matchingButton.Name = "matchingButton";
            this.matchingButton.Size = new System.Drawing.Size(138, 30);
            this.matchingButton.TabIndex = 0;
            this.matchingButton.Text = "Matching";
            this.matchingButton.UseVisualStyleBackColor = false;
            this.matchingButton.Click += new System.EventHandler(this.matchingButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeButton,
            this.toolStripSeparator1,
            this.logoutButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(519, 40);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // homeButton
            // 
            this.homeButton.ActiveLinkColor = System.Drawing.SystemColors.ButtonFace;
            this.homeButton.AutoSize = false;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(250, 30);
            this.homeButton.Text = "Home";
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(205, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thinking of a word you\'ll choose";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(205, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thinking of a word you trained";
            // 
            // trainingButton
            // 
            this.trainingButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.trainingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.trainingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.trainingButton.Location = new System.Drawing.Point(29, 103);
            this.trainingButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trainingButton.Name = "trainingButton";
            this.trainingButton.Size = new System.Drawing.Size(138, 30);
            this.trainingButton.TabIndex = 8;
            this.trainingButton.Text = "Training";
            this.trainingButton.UseVisualStyleBackColor = false;
            this.trainingButton.Click += new System.EventHandler(this.trainingButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(59, 37);
            this.logoutButton.Text = "Logout";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(519, 289);
            this.Controls.Add(this.trainingButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.matchingButton);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speak Your Mind";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button matchingButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel homeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button trainingButton;
        private System.Windows.Forms.ToolStripLabel logoutButton;
    }
}