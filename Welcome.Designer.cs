namespace speak_your_mind
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.signUpTextBox = new System.Windows.Forms.TextBox();
            this.loginSubmitButton = new System.Windows.Forms.Button();
            this.signUpSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.loginButton.Location = new System.Drawing.Point(33, 145);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(138, 30);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Speak Your Mind!";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signUpButton.Location = new System.Drawing.Point(33, 225);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(138, 30);
            this.signUpButton.TabIndex = 3;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginTextBox.Location = new System.Drawing.Point(205, 148);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(180, 26);
            this.loginTextBox.TabIndex = 4;
            this.loginTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loginTextBox_MouseClick);
            // 
            // signUpTextBox
            // 
            this.signUpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.signUpTextBox.Location = new System.Drawing.Point(205, 228);
            this.signUpTextBox.Name = "signUpTextBox";
            this.signUpTextBox.Size = new System.Drawing.Size(180, 26);
            this.signUpTextBox.TabIndex = 5;
            this.signUpTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.signUpTextBox_MouseClick);
            // 
            // loginSubmitButton
            // 
            this.loginSubmitButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginSubmitButton.Location = new System.Drawing.Point(404, 152);
            this.loginSubmitButton.Name = "loginSubmitButton";
            this.loginSubmitButton.Size = new System.Drawing.Size(85, 23);
            this.loginSubmitButton.TabIndex = 6;
            this.loginSubmitButton.Text = "Submit";
            this.loginSubmitButton.UseVisualStyleBackColor = false;
            this.loginSubmitButton.Click += new System.EventHandler(this.loginSubmitButton_Click);
            // 
            // signUpSubmitButton
            // 
            this.signUpSubmitButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.signUpSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.signUpSubmitButton.Location = new System.Drawing.Point(404, 232);
            this.signUpSubmitButton.Name = "signUpSubmitButton";
            this.signUpSubmitButton.Size = new System.Drawing.Size(85, 23);
            this.signUpSubmitButton.TabIndex = 7;
            this.signUpSubmitButton.Text = "Submit";
            this.signUpSubmitButton.UseVisualStyleBackColor = false;
            this.signUpSubmitButton.Click += new System.EventHandler(this.signUpSubmitButton_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(519, 289);
            this.Controls.Add(this.signUpSubmitButton);
            this.Controls.Add(this.loginSubmitButton);
            this.Controls.Add(this.signUpTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speak Your Mind";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox signUpTextBox;
        private System.Windows.Forms.Button loginSubmitButton;
        private System.Windows.Forms.Button signUpSubmitButton;
    }
}