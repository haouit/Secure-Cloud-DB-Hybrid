namespace NT219_FinalProject
{
    partial class User
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
            tabshow = new TabControl();
            Key_setting = new TabPage();
            checkBox4 = new CheckBox();
            btn_config = new Button();
            checkBox3 = new CheckBox();
            btn_loadprivate = new Button();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            btn_saveprivatekey = new Button();
            label2 = new Label();
            rb_privatekey = new RichTextBox();
            btn_createpublickey = new Button();
            btn_loadpublic = new Button();
            label1 = new Label();
            rb_publickey = new RichTextBox();
            list_data = new TabPage();
            btn_find = new Button();
            btn_refresh = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_downdata = new Button();
            btn_newdata = new Button();
            list_request = new TabPage();
            btn_refreshrequest = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            list_accepted = new TabPage();
            btn_refreshaccept = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            tabshow.SuspendLayout();
            Key_setting.SuspendLayout();
            list_data.SuspendLayout();
            list_request.SuspendLayout();
            list_accepted.SuspendLayout();
            SuspendLayout();
            // 
            // tabshow
            // 
            tabshow.Controls.Add(Key_setting);
            tabshow.Controls.Add(list_data);
            tabshow.Controls.Add(list_request);
            tabshow.Controls.Add(list_accepted);
            tabshow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabshow.Location = new Point(1, 1);
            tabshow.Name = "tabshow";
            tabshow.SelectedIndex = 0;
            tabshow.Size = new Size(1275, 683);
            tabshow.TabIndex = 0;
            // 
            // Key_setting
            // 
            Key_setting.Controls.Add(checkBox4);
            Key_setting.Controls.Add(btn_config);
            Key_setting.Controls.Add(checkBox3);
            Key_setting.Controls.Add(btn_loadprivate);
            Key_setting.Controls.Add(checkBox2);
            Key_setting.Controls.Add(checkBox1);
            Key_setting.Controls.Add(btn_saveprivatekey);
            Key_setting.Controls.Add(label2);
            Key_setting.Controls.Add(rb_privatekey);
            Key_setting.Controls.Add(btn_createpublickey);
            Key_setting.Controls.Add(btn_loadpublic);
            Key_setting.Controls.Add(label1);
            Key_setting.Controls.Add(rb_publickey);
            Key_setting.Location = new Point(4, 41);
            Key_setting.Name = "Key_setting";
            Key_setting.Size = new Size(1267, 638);
            Key_setting.TabIndex = 3;
            Key_setting.Text = "Key Setting";
            Key_setting.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Enabled = false;
            checkBox4.Location = new Point(876, 527);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(22, 21);
            checkBox4.TabIndex = 16;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // btn_config
            // 
            btn_config.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_config.Location = new Point(674, 503);
            btn_config.Name = "btn_config";
            btn_config.Size = new Size(196, 61);
            btn_config.TabIndex = 15;
            btn_config.Text = "Config Key";
            btn_config.UseVisualStyleBackColor = true;
            btn_config.Click += btn_config_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Enabled = false;
            checkBox3.Location = new Point(600, 527);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(22, 21);
            checkBox3.TabIndex = 14;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // btn_loadprivate
            // 
            btn_loadprivate.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_loadprivate.Location = new Point(326, 569);
            btn_loadprivate.Name = "btn_loadprivate";
            btn_loadprivate.Size = new Size(268, 61);
            btn_loadprivate.TabIndex = 13;
            btn_loadprivate.Text = "Load private key";
            btn_loadprivate.UseVisualStyleBackColor = true;
            btn_loadprivate.Click += btn_loadprivate_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Enabled = false;
            checkBox2.Location = new Point(1140, 528);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(22, 21);
            checkBox2.TabIndex = 12;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(600, 594);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 11;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_saveprivatekey
            // 
            btn_saveprivatekey.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_saveprivatekey.Location = new Point(934, 503);
            btn_saveprivatekey.Name = "btn_saveprivatekey";
            btn_saveprivatekey.Size = new Size(200, 61);
            btn_saveprivatekey.TabIndex = 10;
            btn_saveprivatekey.Text = "Save key";
            btn_saveprivatekey.UseVisualStyleBackColor = true;
            btn_saveprivatekey.Click += btn_saveprivatekey_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(824, 21);
            label2.Name = "label2";
            label2.Size = new Size(232, 54);
            label2.TabIndex = 9;
            label2.Text = "Private key";
            // 
            // rb_privatekey
            // 
            rb_privatekey.Location = new Point(674, 93);
            rb_privatekey.Name = "rb_privatekey";
            rb_privatekey.Size = new Size(493, 382);
            rb_privatekey.TabIndex = 8;
            rb_privatekey.Text = "";
            // 
            // btn_createpublickey
            // 
            btn_createpublickey.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_createpublickey.Location = new Point(101, 503);
            btn_createpublickey.Name = "btn_createpublickey";
            btn_createpublickey.Size = new Size(196, 61);
            btn_createpublickey.TabIndex = 7;
            btn_createpublickey.Text = "Create key";
            btn_createpublickey.UseVisualStyleBackColor = true;
            btn_createpublickey.Click += btn_createpublickey_Click;
            // 
            // btn_loadpublic
            // 
            btn_loadpublic.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_loadpublic.Location = new Point(326, 502);
            btn_loadpublic.Name = "btn_loadpublic";
            btn_loadpublic.Size = new Size(268, 61);
            btn_loadpublic.TabIndex = 5;
            btn_loadpublic.Text = "Load public key";
            btn_loadpublic.UseVisualStyleBackColor = true;
            btn_loadpublic.Click += btn_loadpublic_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(251, 21);
            label1.Name = "label1";
            label1.Size = new Size(214, 54);
            label1.TabIndex = 4;
            label1.Text = "Public key";
            // 
            // rb_publickey
            // 
            rb_publickey.Location = new Point(101, 93);
            rb_publickey.Name = "rb_publickey";
            rb_publickey.Size = new Size(493, 382);
            rb_publickey.TabIndex = 3;
            rb_publickey.Text = "";
            // 
            // list_data
            // 
            list_data.Controls.Add(btn_find);
            list_data.Controls.Add(btn_refresh);
            list_data.Controls.Add(flowLayoutPanel1);
            list_data.Controls.Add(btn_downdata);
            list_data.Controls.Add(btn_newdata);
            list_data.Location = new Point(4, 41);
            list_data.Name = "list_data";
            list_data.Size = new Size(1267, 638);
            list_data.TabIndex = 2;
            list_data.Text = "Data Manager";
            list_data.UseVisualStyleBackColor = true;
            // 
            // btn_find
            // 
            btn_find.Location = new Point(732, 13);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(128, 45);
            btn_find.TabIndex = 6;
            btn_find.Text = "Find";
            btn_find.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(7, 13);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(155, 45);
            btn_refresh.TabIndex = 5;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 64);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1267, 574);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btn_downdata
            // 
            btn_downdata.Location = new Point(1047, 13);
            btn_downdata.Name = "btn_downdata";
            btn_downdata.Size = new Size(213, 45);
            btn_downdata.TabIndex = 2;
            btn_downdata.Text = "Download Data";
            btn_downdata.UseVisualStyleBackColor = true;
            btn_downdata.Click += btn_downdata_Click;
            // 
            // btn_newdata
            // 
            btn_newdata.Location = new Point(877, 13);
            btn_newdata.Name = "btn_newdata";
            btn_newdata.Size = new Size(155, 45);
            btn_newdata.TabIndex = 1;
            btn_newdata.Text = "New Data";
            btn_newdata.UseVisualStyleBackColor = true;
            btn_newdata.Click += btn_newdata_Click;
            // 
            // list_request
            // 
            list_request.Controls.Add(btn_refreshrequest);
            list_request.Controls.Add(flowLayoutPanel2);
            list_request.Location = new Point(4, 41);
            list_request.Name = "list_request";
            list_request.Padding = new Padding(3);
            list_request.Size = new Size(1267, 638);
            list_request.TabIndex = 0;
            list_request.Text = "Pending Requests";
            list_request.UseVisualStyleBackColor = true;
            // 
            // btn_refreshrequest
            // 
            btn_refreshrequest.Location = new Point(6, 12);
            btn_refreshrequest.Name = "btn_refreshrequest";
            btn_refreshrequest.Size = new Size(155, 45);
            btn_refreshrequest.TabIndex = 6;
            btn_refreshrequest.Text = "Refresh";
            btn_refreshrequest.UseVisualStyleBackColor = true;
            btn_refreshrequest.Click += btn_refreshrequest_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(0, 63);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1267, 575);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // list_accepted
            // 
            list_accepted.Controls.Add(btn_refreshaccept);
            list_accepted.Controls.Add(flowLayoutPanel3);
            list_accepted.Location = new Point(4, 41);
            list_accepted.Name = "list_accepted";
            list_accepted.Padding = new Padding(3);
            list_accepted.Size = new Size(1267, 638);
            list_accepted.TabIndex = 1;
            list_accepted.Text = "Check Request";
            list_accepted.UseVisualStyleBackColor = true;
            // 
            // btn_refreshaccept
            // 
            btn_refreshaccept.Location = new Point(6, 12);
            btn_refreshaccept.Name = "btn_refreshaccept";
            btn_refreshaccept.Size = new Size(155, 45);
            btn_refreshaccept.TabIndex = 8;
            btn_refreshaccept.Text = "Refresh";
            btn_refreshaccept.UseVisualStyleBackColor = true;
            btn_refreshaccept.Click += btn_refreshaccept_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(0, 63);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1267, 575);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 684);
            Controls.Add(tabshow);
            Name = "User";
            Text = "User";
            tabshow.ResumeLayout(false);
            Key_setting.ResumeLayout(false);
            Key_setting.PerformLayout();
            list_data.ResumeLayout(false);
            list_request.ResumeLayout(false);
            list_accepted.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabshow;
        private TabPage list_request;
        private TabPage list_accepted;
        private TabPage list_data;
        private Button btn_newdata;
        private Button btn_downdata;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage Key_setting;
        private Button btn_createpublickey;
        private Button btn_loadpublic;
        private Label label1;
        private RichTextBox rb_publickey;
        private Button btn_refresh;
        private Button btn_refreshrequest;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btn_refreshaccept;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btn_find;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button btn_saveprivatekey;
        private Label label2;
        private RichTextBox rb_privatekey;
        private CheckBox checkBox3;
        private Button btn_loadprivate;
        private Button btn_config;
        private CheckBox checkBox4;
    }
}