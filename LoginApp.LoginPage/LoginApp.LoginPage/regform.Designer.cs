namespace LoginApp.LoginPage
{
    partial class regform
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
            label1 = new Label();
            label2 = new Label();
            RegFormUsername = new TextBox();
            RegFormPassword = new TextBox();
            RegFormEmail = new TextBox();
            RegFormPhoneNumber = new TextBox();
            label3 = new Label();
            label4 = new Label();
            RegButton = new Button();
            backbutton = new Button();
            regformexitbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 91);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // RegFormUsername
            // 
            RegFormUsername.Location = new Point(161, 41);
            RegFormUsername.Name = "RegFormUsername";
            RegFormUsername.Size = new Size(100, 23);
            RegFormUsername.TabIndex = 2;
            RegFormUsername.TextChanged += RegFormUsername_TextChanged;
            // 
            // RegFormPassword
            // 
            RegFormPassword.Location = new Point(161, 88);
            RegFormPassword.Name = "RegFormPassword";
            RegFormPassword.Size = new Size(100, 23);
            RegFormPassword.TabIndex = 3;
            // 
            // RegFormEmail
            // 
            RegFormEmail.Location = new Point(161, 144);
            RegFormEmail.Name = "RegFormEmail";
            RegFormEmail.Size = new Size(100, 23);
            RegFormEmail.TabIndex = 4;
            // 
            // RegFormPhoneNumber
            // 
            RegFormPhoneNumber.Location = new Point(161, 192);
            RegFormPhoneNumber.Name = "RegFormPhoneNumber";
            RegFormPhoneNumber.Size = new Size(100, 23);
            RegFormPhoneNumber.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 152);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 200);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 7;
            label4.Text = "Phone Number";
            // 
            // RegButton
            // 
            RegButton.Location = new Point(317, 247);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(75, 23);
            RegButton.TabIndex = 8;
            RegButton.Text = "Register";
            RegButton.UseVisualStyleBackColor = true;
            RegButton.Click += RegButton_Click;
            // 
            // backbutton
            // 
            backbutton.Location = new Point(173, 247);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(75, 23);
            backbutton.TabIndex = 9;
            backbutton.Text = "Back";
            backbutton.UseVisualStyleBackColor = true;
            backbutton.Click += backbutton_Click;
            // 
            // regformexitbutton
            // 
            regformexitbutton.Location = new Point(36, 247);
            regformexitbutton.Name = "regformexitbutton";
            regformexitbutton.Size = new Size(75, 23);
            regformexitbutton.TabIndex = 10;
            regformexitbutton.Text = "Exit";
            regformexitbutton.UseVisualStyleBackColor = true;
            regformexitbutton.Click += regformexitbutton_Click;
            // 
            // regform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 490);
            Controls.Add(regformexitbutton);
            Controls.Add(backbutton);
            Controls.Add(RegButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(RegFormPhoneNumber);
            Controls.Add(RegFormEmail);
            Controls.Add(RegFormPassword);
            Controls.Add(RegFormUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "regform";
            Text = "regform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox RegFormUsername;
        private TextBox RegFormPassword;
        private TextBox RegFormEmail;
        private TextBox RegFormPhoneNumber;
        private Label label3;
        private Label label4;
        private Button RegButton;
        private Button backbutton;
        private Button regformexitbutton;
    }
}