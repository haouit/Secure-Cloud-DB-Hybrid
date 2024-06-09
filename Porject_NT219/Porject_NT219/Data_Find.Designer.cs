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
            btn_find = new Button();
            tb_find = new TextBox();
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
            // btn_find
            // 
            btn_find.Location = new Point(1123, 12);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(143, 47);
            btn_find.TabIndex = 1;
            btn_find.Text = "Find";
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += btn_find_Click;
            // 
            // tb_find
            // 
            tb_find.Location = new Point(161, 12);
            tb_find.Multiline = true;
            tb_find.Name = "tb_find";
            tb_find.Size = new Size(956, 47);
            tb_find.TabIndex = 2;
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
            Controls.Add(tb_find);
            Controls.Add(btn_find);
            Controls.Add(btn_refresh);
            Name = "Data_Find";
            Text = "Data_Find";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_refresh;
        private Button btn_find;
        private TextBox tb_find;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}