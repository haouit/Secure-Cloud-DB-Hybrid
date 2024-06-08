namespace NT219_FinalProject
{
    partial class LoginMongo
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
            tb_username = new TextBox();
            tb_password = new TextBox();
            btn_signin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Location = new Point(271, 102);
            tb_username.Multiline = true;
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(259, 49);
            tb_username.TabIndex = 0;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(271, 175);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(259, 49);
            tb_password.TabIndex = 1;
            // 
            // btn_signin
            // 
            btn_signin.Location = new Point(271, 252);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(259, 39);
            btn_signin.TabIndex = 2;
            btn_signin.Text = "Sign in";
            btn_signin.UseVisualStyleBackColor = true;
            btn_signin.Click += btn_signin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(322, 30);
            label1.Name = "label1";
            label1.Size = new Size(142, 38);
            label1.TabIndex = 3;
            label1.Text = "MongoDB";
            // 
            // LoginMongo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_signin);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Name = "LoginMongo";
            Text = "LoginMongo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_username;
        private TextBox tb_password;
        private Button btn_signin;
        private Label label1;
    }
}