namespace NT219_FinalProject
{
    partial class Data_Find
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
            button2 = new Button();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(12, 12);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(143, 47);
            btn_refresh.TabIndex = 0;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1123, 12);
            button2.Name = "button2";
            button2.Size = new Size(143, 47);
            button2.TabIndex = 1;
            button2.Text = "Find";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(956, 47);
            textBox1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(-1, 65);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1279, 620);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // Data_Find
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 684);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(btn_refresh);
            Name = "Data_Find";
            Text = "Data_Find";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_refresh;
        private Button button2;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}