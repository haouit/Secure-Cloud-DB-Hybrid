namespace NT219_FinalProject
{
    partial class Sign_Up
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
            btn_signup = new Button();
            tb_username = new TextBox();
            tb_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_signup
            // 
            btn_signup.Location = new Point(355, 401);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(274, 47);
            btn_signup.TabIndex = 0;
            btn_signup.Text = "Sign Up";
            btn_signup.UseVisualStyleBackColor = true;
            btn_signup.Click += btn_signup_Click;
            // 
            // tb_username
            // 
            tb_username.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_username.Location = new Point(355, 222);
            tb_username.Multiline = true;
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(274, 53);
            tb_username.TabIndex = 1;
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_password.Location = new Point(355, 298);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(274, 53);
            tb_password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(214, 231);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(214, 307);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 4;
            label2.Text = "Passwork:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(411, 110);
            label3.Name = "label3";
            label3.Size = new Size(178, 60);
            label3.TabIndex = 5;
            label3.Text = "Sign Up";
            // 
            // Sign_Up
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 684);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(btn_signup);
            Name = "Sign_Up";
            Text = "Sign_Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_signup;
        private TextBox tb_username;
        private TextBox tb_password;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}