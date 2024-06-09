namespace NT219_FinalProject
{
    partial class Down_file
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
            btn_down = new Button();
            lb_message = new Label();
            label4 = new Label();
            lb_filename = new Label();
            label3 = new Label();
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
            // btn_down
            // 
            btn_down.BackColor = Color.LawnGreen;
            btn_down.Location = new Point(781, 39);
            btn_down.Name = "btn_down";
            btn_down.Size = new Size(146, 51);
            btn_down.TabIndex = 9;
            btn_down.Text = "DownLoad";
            btn_down.UseVisualStyleBackColor = false;
            btn_down.Click += btn_down_Click;
            // 
            // lb_message
            // 
            lb_message.AutoSize = true;
            lb_message.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_message.Location = new Point(130, 78);
            lb_message.Name = "lb_message";
            lb_message.Size = new Size(69, 32);
            lb_message.TabIndex = 11;
            lb_message.Text = "none";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 78);
            label4.Name = "label4";
            label4.Size = new Size(113, 32);
            label4.TabIndex = 10;
            label4.Text = "Message:";
            // 
            // lb_filename
            // 
            lb_filename.AutoSize = true;
            lb_filename.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_filename.Location = new Point(143, 46);
            lb_filename.Name = "lb_filename";
            lb_filename.Size = new Size(69, 32);
            lb_filename.TabIndex = 13;
            lb_filename.Text = "none";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 46);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 12;
            label3.Text = "File name:";
            // 
            // Down_file
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(lb_filename);
            Controls.Add(label3);
            Controls.Add(lb_message);
            Controls.Add(label4);
            Controls.Add(btn_down);
            Controls.Add(lb_nameuser);
            Controls.Add(label1);
            Name = "Down_file";
            Size = new Size(1065, 123);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lb_nameuser;
        private Button btn_down;
        private Label lb_message;
        private Label label4;
        private Label lb_filename;
        private Label label3;
    }
}
