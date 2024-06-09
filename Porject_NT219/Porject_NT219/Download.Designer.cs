namespace NT219_FinalProject
{
    partial class Download
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
            btn_refresh = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(12, 12);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(143, 47);
            btn_refresh.TabIndex = 1;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 65);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1279, 620);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // Download
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 684);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btn_refresh);
            Name = "Download";
            Text = "Data_Find";
            ResumeLayout(false);
        }

        #endregion
        private Button btn_refresh;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}