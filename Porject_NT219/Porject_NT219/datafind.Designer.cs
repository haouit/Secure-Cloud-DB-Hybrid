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
            label1 = new Label();
            label2 = new Label();
            lb_name = new Label();
            lb_dataname = new Label();
            lb_dataid = new Label();
            label4 = new Label();
            btn_request = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 14);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 46);
            label2.Name = "label2";
            label2.Size = new Size(160, 32);
            label2.TabIndex = 3;
            label2.Text = "Data Request:";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_name.Location = new Point(113, 14);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(69, 32);
            lb_name.TabIndex = 4;
            lb_name.Text = "none";
            // 
            // lb_dataname
            // 
            lb_dataname.AutoSize = true;
            lb_dataname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dataname.Location = new Point(190, 46);
            lb_dataname.Name = "lb_dataname";
            lb_dataname.Size = new Size(69, 32);
            lb_dataname.TabIndex = 5;
            lb_dataname.Text = "none";
            // 
            // lb_dataid
            // 
            lb_dataid.AutoSize = true;
            lb_dataid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dataid.Location = new Point(72, 78);
            lb_dataid.Name = "lb_dataid";
            lb_dataid.Size = new Size(69, 32);
            lb_dataid.TabIndex = 7;
            lb_dataid.Text = "none";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 78);
            label4.Name = "label4";
            label4.Size = new Size(42, 32);
            label4.TabIndex = 6;
            label4.Text = "ID:";
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
            // datafind
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(btn_request);
            Controls.Add(lb_dataid);
            Controls.Add(label4);
            Controls.Add(lb_dataname);
            Controls.Add(lb_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "datafind";
            Size = new Size(950, 123);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label lb_name;
        private Label lb_dataname;
        private Label lb_dataid;
        private Label label4;
        private Button btn_request;
    }
}
