namespace NT219_FinalProject
{
    partial class DataManager
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
            btn_dataload = new Button();
            btn_uploaddata = new Button();
            btn_savedata = new Button();
            btn_encyptdata = new Button();
            rb_secretkey = new RichTextBox();
            SuspendLayout();
            // 
            // btn_dataload
            // 
            btn_dataload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dataload.Location = new Point(366, 12);
            btn_dataload.Name = "btn_dataload";
            btn_dataload.Size = new Size(154, 50);
            btn_dataload.TabIndex = 0;
            btn_dataload.Text = "Load Data";
            btn_dataload.UseVisualStyleBackColor = true;
            btn_dataload.Click += btn_dataload_Click;
            // 
            // btn_uploaddata
            // 
            btn_uploaddata.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_uploaddata.Location = new Point(703, 12);
            btn_uploaddata.Name = "btn_uploaddata";
            btn_uploaddata.Size = new Size(154, 50);
            btn_uploaddata.TabIndex = 1;
            btn_uploaddata.Text = "Upload Data";
            btn_uploaddata.UseVisualStyleBackColor = true;
            btn_uploaddata.Click += btn_uploaddata_Click;
            // 
            // btn_savedata
            // 
            btn_savedata.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_savedata.Location = new Point(863, 12);
            btn_savedata.Name = "btn_savedata";
            btn_savedata.Size = new Size(154, 50);
            btn_savedata.TabIndex = 2;
            btn_savedata.Text = "Save Data";
            btn_savedata.UseVisualStyleBackColor = true;
            btn_savedata.Click += btn_savedata_Click;
            // 
            // btn_encyptdata
            // 
            btn_encyptdata.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_encyptdata.Location = new Point(526, 12);
            btn_encyptdata.Name = "btn_encyptdata";
            btn_encyptdata.Size = new Size(171, 50);
            btn_encyptdata.TabIndex = 3;
            btn_encyptdata.Text = "Encrypt Data";
            btn_encyptdata.UseVisualStyleBackColor = true;
            btn_encyptdata.Click += btn_encyptdata_Click;
            // 
            // rb_secretkey
            // 
            rb_secretkey.Location = new Point(12, 93);
            rb_secretkey.Name = "rb_secretkey";
            rb_secretkey.Size = new Size(1005, 270);
            rb_secretkey.TabIndex = 4;
            rb_secretkey.Text = "";
            // 
            // Data
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 375);
            Controls.Add(rb_secretkey);
            Controls.Add(btn_encyptdata);
            Controls.Add(btn_savedata);
            Controls.Add(btn_uploaddata);
            Controls.Add(btn_dataload);
            Name = "Data";
            Text = "Data";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_dataload;
        private Button btn_uploaddata;
        private Button btn_savedata;
        private Button btn_encyptdata;
        private RichTextBox rb_secretkey;
    }
}