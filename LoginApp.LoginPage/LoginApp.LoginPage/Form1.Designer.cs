namespace LoginApp.LoginPage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userLabel = new Label();
            passLabel = new Label();
            textBoxuser = new TextBox();
            textBoxpass = new TextBox();
            login_button = new Button();
            clear_button = new Button();
            exit_button = new Button();
            regbutton = new Button();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(26, 27);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(60, 15);
            userLabel.TabIndex = 0;
            userLabel.Text = "Username";
            userLabel.Click += label1_Click;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new Point(26, 74);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(57, 15);
            passLabel.TabIndex = 1;
            passLabel.Text = "Password";
            // 
            // textBoxuser
            // 
            textBoxuser.Location = new Point(149, 28);
            textBoxuser.Name = "textBoxuser";
            textBoxuser.Size = new Size(237, 23);
            textBoxuser.TabIndex = 2;
            // 
            // textBoxpass
            // 
            textBoxpass.Location = new Point(149, 74);
            textBoxpass.Name = "textBoxpass";
            textBoxpass.Size = new Size(237, 23);
            textBoxpass.TabIndex = 3;
            // 
            // login_button
            // 
            login_button.Location = new Point(245, 133);
            login_button.Name = "login_button";
            login_button.Size = new Size(75, 23);
            login_button.TabIndex = 4;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(130, 133);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(75, 23);
            clear_button.TabIndex = 5;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(26, 133);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(75, 23);
            exit_button.TabIndex = 6;
            exit_button.Text = "Exit";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // regbutton
            // 
            regbutton.Location = new Point(357, 133);
            regbutton.Name = "regbutton";
            regbutton.Size = new Size(75, 23);
            regbutton.TabIndex = 7;
            regbutton.Text = "Register";
            regbutton.UseVisualStyleBackColor = true;
            regbutton.Click += regbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 186);
            Controls.Add(regbutton);
            Controls.Add(exit_button);
            Controls.Add(clear_button);
            Controls.Add(login_button);
            Controls.Add(textBoxpass);
            Controls.Add(textBoxuser);
            Controls.Add(passLabel);
            Controls.Add(userLabel);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userLabel;
        private Label passLabel;
        private TextBox textBoxuser;
        private TextBox textBoxpass;
        private Button login_button;
        private Button clear_button;
        private Button exit_button;
        private Button regbutton;
    }
}