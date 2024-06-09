namespace NT219_FinalProject
{
    partial class datafind
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
            lb_nameuser = new Label();
            lb_namerequest = new Label();
            lb_message = new Label();
            btn_request = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lb_nameuser
            // 
            lb_nameuser.AutoSize = true;
            lb_nameuser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_nameuser.Location = new Point(190, 14);
            lb_nameuser.Name = "lb_nameuser";
            lb_nameuser.Size = new Size(69, 32);
            lb_nameuser.TabIndex = 4;
            lb_nameuser.Text = "none";
            // 
            // lb_namerequest
            // 
            lb_namerequest.AutoSize = true;
            lb_namerequest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_namerequest.Location = new Point(188, 46);
            lb_namerequest.Name = "lb_namerequest";
            lb_namerequest.Size = new Size(69, 32);
            lb_namerequest.TabIndex = 5;
            lb_namerequest.Text = "none";
            // 
            // lb_message
            // 
            lb_message.AutoSize = true;
            lb_message.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_message.Location = new Point(143, 78);
            lb_message.Name = "lb_message";
            lb_message.Size = new Size(69, 32);
            lb_message.TabIndex = 7;
            lb_message.Text = "none";
            // 
            // btn_request
            // 
            btn_request.BackColor = Color.GreenYellow;
            btn_request.Location = new Point(743, 39);
            btn_request.Name = "btn_request";
            btn_request.Size = new Size(146, 51);
            btn_request.TabIndex = 9;
            btn_request.Text = "Request";
            btn_request.UseVisualStyleBackColor = false;
            btn_request.Click += btn_request_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 14);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 2;
            label1.Text = "Name Owner:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 46);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 3;
            label2.Text = "User Request:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 78);
            label4.Name = "label4";
            label4.Size = new Size(113, 32);
            label4.TabIndex = 6;
            label4.Text = "Message:";
            // 
            // datafind
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(btn_request);
            Controls.Add(lb_message);
            Controls.Add(label4);
            Controls.Add(lb_namerequest);
            Controls.Add(lb_nameuser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "datafind";
            Size = new Size(950, 123);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_nameuser;
        private Label lb_namerequest;
        private Label lb_message;
        private Button btn_request;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}
