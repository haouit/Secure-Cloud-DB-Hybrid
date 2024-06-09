namespace NT219_FinalProject
{
    partial class data_user
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
            label1 = new Label();
            lb_nameuser = new Label();
            btn_remove = new Button();
            lb_message = new Label();
            label4 = new Label();
            SuspendLayout();
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
            // lb_nameuser
            // 
            lb_nameuser.AutoSize = true;
            lb_nameuser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_nameuser.Location = new Point(179, 14);
            lb_nameuser.Name = "lb_nameuser";
            lb_nameuser.Size = new Size(69, 32);
            lb_nameuser.TabIndex = 4;
            lb_nameuser.Text = "none";
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.Salmon;
            btn_remove.Location = new Point(744, 39);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(146, 51);
            btn_remove.TabIndex = 9;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // lb_message
            // 
            lb_message.AutoSize = true;
            lb_message.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_message.Location = new Point(135, 58);
            lb_message.Name = "lb_message";
            lb_message.Size = new Size(69, 32);
            lb_message.TabIndex = 11;
            lb_message.Text = "none";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 58);
            label4.Name = "label4";
            label4.Size = new Size(113, 32);
            label4.TabIndex = 10;
            label4.Text = "Message:";
            // 
            // data_user
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(lb_message);
            Controls.Add(label4);
            Controls.Add(btn_remove);
            Controls.Add(lb_nameuser);
            Controls.Add(label1);
            Name = "data_user";
            Size = new Size(950, 123);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lb_nameuser;
        private Button btn_remove;
        private Label lb_message;
        private Label label4;
    }
}
