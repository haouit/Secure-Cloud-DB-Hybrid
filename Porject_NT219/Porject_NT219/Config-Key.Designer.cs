namespace Porject_NT219
{
    partial class Config_Key
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            btn_config = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 80);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1034, 482);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(427, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 54);
            label1.TabIndex = 1;
            label1.Text = "Public key";
            // 
            // btn_config
            // 
            btn_config.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_config.Location = new Point(837, 590);
            btn_config.Name = "btn_config";
            btn_config.Size = new Size(209, 69);
            btn_config.TabIndex = 2;
            btn_config.Text = "Config Key";
            btn_config.UseVisualStyleBackColor = true;
            btn_config.Click += btn_config_Click;
            // 
            // Config_Key
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 684);
            Controls.Add(btn_config);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "Config_Key";
            Text = "Config_Key";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Button btn_config;
    }
}