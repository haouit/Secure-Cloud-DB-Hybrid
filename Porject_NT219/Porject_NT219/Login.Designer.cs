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
            btn_signup = new Button();
            SuspendLayout();
            // 
            // tb_usename
            // 
            tb_usename.Location = new Point(176, 84);
            tb_usename.Margin = new Padding(2, 2, 2, 2);
            tb_usename.Multiline = true;
            tb_usename.Name = "tb_usename";
            tb_usename.Size = new Size(222, 25);
            tb_usename.TabIndex = 0;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(176, 128);
            tb_password.Margin = new Padding(2, 2, 2, 2);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(222, 25);
            tb_password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(237, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 112);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btn_signin
            // 
            btn_signin.Location = new Point(292, 155);
            btn_signin.Margin = new Padding(2, 2, 2, 2);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(105, 29);
            btn_signin.TabIndex = 5;
            btn_signin.Text = "Sign In";
            btn_signin.UseVisualStyleBackColor = true;
            btn_signin.Click += btn_signin_Click;
            // 
            // btn_signup
            // 
            btn_signup.Location = new Point(176, 155);
            btn_signup.Margin = new Padding(2, 2, 2, 2);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(108, 29);
            btn_signup.TabIndex = 7;
            btn_signup.Text = "Sign Up";
            btn_signup.UseVisualStyleBackColor = true;
            btn_signup.Click += btn_signup_Click;
            // 
            // Login
            // 
            AcceptButton = btn_signin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 244);
            Controls.Add(btn_signup);
            Controls.Add(btn_signin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_password);
            Controls.Add(tb_usename);
            Margin = new Padding(2, 2, 2, 2);
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
        private Button btn_signup;
    }
}