namespace NT219_FinalProject
{
    partial class Login
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
            tb_usename = new TextBox();
            tb_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_signin = new Button();
            btn_repass = new Button();
            btn_signup = new Button();
            SuspendLayout();
            // 
            // tb_usename
            // 
            tb_usename.Location = new Point(251, 140);
            tb_usename.Multiline = true;
            tb_usename.Name = "tb_usename";
            tb_usename.Size = new Size(316, 39);
            tb_usename.TabIndex = 0;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(251, 214);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(316, 39);
            tb_password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(338, 36);
            label1.Name = "label1";
            label1.Size = new Size(142, 60);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 112);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 186);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btn_signin
            // 
            btn_signin.Location = new Point(251, 299);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(316, 34);
            btn_signin.TabIndex = 5;
            btn_signin.Text = "Sign In";
            btn_signin.UseVisualStyleBackColor = true;
            btn_signin.Click += btn_signin_Click;
            // 
            // btn_repass
            // 
            btn_repass.Location = new Point(251, 259);
            btn_repass.Name = "btn_repass";
            btn_repass.Size = new Size(155, 34);
            btn_repass.TabIndex = 6;
            btn_repass.Text = "Forget";
            btn_repass.UseVisualStyleBackColor = true;
            btn_repass.Click += btn_repass_Click;
            // 
            // btn_signup
            // 
            btn_signup.Location = new Point(412, 259);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(155, 34);
            btn_signup.TabIndex = 7;
            btn_signup.Text = "Sign Up";
            btn_signup.UseVisualStyleBackColor = true;
            btn_signup.Click += btn_signup_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 406);
            Controls.Add(btn_signup);
            Controls.Add(btn_repass);
            Controls.Add(btn_signin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_password);
            Controls.Add(tb_usename);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_usename;
        private TextBox tb_password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_signin;
        private Button btn_repass;
        private Button btn_signup;
    }
}