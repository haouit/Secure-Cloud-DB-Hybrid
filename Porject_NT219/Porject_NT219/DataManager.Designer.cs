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
            btn_loadkey = new Button();
            btn_loadiv = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            lb_namefile = new Label();
            lb_namekey = new Label();
            lb_nameiv = new Label();
            btn_gen = new Button();
            tb_API = new TextBox();
            SuspendLayout();
            // 
            // btn_dataload
            // 
            btn_dataload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dataload.Location = new Point(8, 75);
            btn_dataload.Margin = new Padding(2);
            btn_dataload.Name = "btn_dataload";
            btn_dataload.Size = new Size(108, 30);
            btn_dataload.TabIndex = 0;
            btn_dataload.Text = "Load Data";
            btn_dataload.UseVisualStyleBackColor = true;
            btn_dataload.Click += btn_dataload_Click;
            // 
            // btn_uploaddata
            // 
            btn_uploaddata.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_uploaddata.Location = new Point(8, 263);
            btn_uploaddata.Margin = new Padding(2);
            btn_uploaddata.Name = "btn_uploaddata";
            btn_uploaddata.Size = new Size(108, 30);
            btn_uploaddata.TabIndex = 1;
            btn_uploaddata.Text = "Upload Data";
            btn_uploaddata.UseVisualStyleBackColor = true;
            btn_uploaddata.Click += btn_uploaddata_Click;
            // 
            // btn_loadkey
            // 
            btn_loadkey.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_loadkey.Location = new Point(8, 134);
            btn_loadkey.Margin = new Padding(2);
            btn_loadkey.Name = "btn_loadkey";
            btn_loadkey.Size = new Size(108, 30);
            btn_loadkey.TabIndex = 5;
            btn_loadkey.Text = "Load Key";
            btn_loadkey.UseVisualStyleBackColor = true;
            btn_loadkey.Click += btn_loadkey_Click;
            // 
            // btn_loadiv
            // 
            btn_loadiv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_loadiv.Location = new Point(8, 201);
            btn_loadiv.Margin = new Padding(2);
            btn_loadiv.Name = "btn_loadiv";
            btn_loadiv.Size = new Size(108, 30);
            btn_loadiv.TabIndex = 6;
            btn_loadiv.Text = "Load IV";
            btn_loadiv.UseVisualStyleBackColor = true;
            btn_loadiv.Click += btn_loadiv_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(119, 86);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 7;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Enabled = false;
            checkBox2.Location = new Point(120, 145);
            checkBox2.Margin = new Padding(2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 8;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Enabled = false;
            checkBox3.Location = new Point(120, 212);
            checkBox3.Margin = new Padding(2);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(15, 14);
            checkBox3.TabIndex = 9;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // lb_namefile
            // 
            lb_namefile.AutoSize = true;
            lb_namefile.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lb_namefile.Location = new Point(8, 107);
            lb_namefile.Margin = new Padding(2, 0, 2, 0);
            lb_namefile.Name = "lb_namefile";
            lb_namefile.Size = new Size(72, 20);
            lb_namefile.TabIndex = 10;
            lb_namefile.Text = "NameFile";
            // 
            // lb_namekey
            // 
            lb_namekey.AutoSize = true;
            lb_namekey.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lb_namekey.Location = new Point(8, 166);
            lb_namekey.Margin = new Padding(2, 0, 2, 0);
            lb_namekey.Name = "lb_namekey";
            lb_namekey.Size = new Size(72, 20);
            lb_namekey.TabIndex = 11;
            lb_namekey.Text = "NameFile";
            // 
            // lb_nameiv
            // 
            lb_nameiv.AutoSize = true;
            lb_nameiv.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lb_nameiv.Location = new Point(8, 233);
            lb_nameiv.Margin = new Padding(2, 0, 2, 0);
            lb_nameiv.Name = "lb_nameiv";
            lb_nameiv.Size = new Size(72, 20);
            lb_nameiv.TabIndex = 12;
            lb_nameiv.Text = "NameFile";
            // 
            // btn_gen
            // 
            btn_gen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_gen.Location = new Point(8, 28);
            btn_gen.Margin = new Padding(2);
            btn_gen.Name = "btn_gen";
            btn_gen.Size = new Size(191, 30);
            btn_gen.TabIndex = 13;
            btn_gen.Text = "Gen key and iv";
            btn_gen.UseVisualStyleBackColor = true;
            btn_gen.Click += btn_gen_Click;
            // 
            // tb_API
            // 
            tb_API.Location = new Point(212, 27);
            tb_API.Margin = new Padding(2);
            tb_API.Multiline = true;
            tb_API.Name = "tb_API";
            tb_API.Size = new Size(144, 31);
            tb_API.TabIndex = 14;
            tb_API.Text = "jo4fMpJ2um0iHwkaEZ9ZAMksYHDStCBCmjG1Ubo8AI5FT0SZcQw8T3t6rzXIUjr4";
            // 
            // DataManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 329);
            Controls.Add(tb_API);
            Controls.Add(btn_gen);
            Controls.Add(lb_nameiv);
            Controls.Add(lb_namekey);
            Controls.Add(lb_namefile);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btn_loadiv);
            Controls.Add(btn_loadkey);
            Controls.Add(btn_uploaddata);
            Controls.Add(btn_dataload);
            Margin = new Padding(2);
            Name = "DataManager";
            Text = "Data";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_dataload;
        private Button btn_uploaddata;
        private Button btn_loadkey;
        private Button btn_loadiv;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label lb_namefile;
        private Label lb_namekey;
        private Label lb_nameiv;
        private Button btn_gen;
        private TextBox tb_API;
    }
}