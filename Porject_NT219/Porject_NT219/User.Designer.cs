namespace Porject_NT219
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
            fileSystemWatcher1 = new FileSystemWatcher();
            tabshow = new TabControl();
            Key_setting = new TabPage();
            btn_createsecretkey = new Button();
            btn_saveseecertkey = new Button();
            rb_secretkey = new RichTextBox();
            btn_createpublickey = new Button();
            label2 = new Label();
            btn_configpublickey = new Button();
            label1 = new Label();
            rb_publickey = new RichTextBox();
            list_data = new TabPage();
            btn_refresh = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_removedata = new Button();
            btn_downdata = new Button();
            btn_newdata = new Button();
            list_request = new TabPage();
            btn_refreshrequest = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            list_accepted = new TabPage();
            button1 = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btn_ = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            tabshow.SuspendLayout();
            Key_setting.SuspendLayout();
            list_data.SuspendLayout();
            list_request.SuspendLayout();
            list_accepted.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
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
            tabshow.Size = new Size(1055, 683);
            tabshow.TabIndex = 0;
            // 
            // Key_setting
            // 
            Key_setting.Controls.Add(btn_createsecretkey);
            Key_setting.Controls.Add(btn_saveseecertkey);
            Key_setting.Controls.Add(rb_secretkey);
            Key_setting.Controls.Add(btn_createpublickey);
            Key_setting.Controls.Add(label2);
            Key_setting.Controls.Add(btn_configpublickey);
            Key_setting.Controls.Add(label1);
            Key_setting.Controls.Add(rb_publickey);
            Key_setting.Location = new Point(4, 41);
            Key_setting.Name = "Key_setting";
            Key_setting.Size = new Size(1047, 638);
            Key_setting.TabIndex = 3;
            Key_setting.Text = "Key Setting";
            Key_setting.UseVisualStyleBackColor = true;
            // 
            // btn_createsecretkey
            // 
            btn_createsecretkey.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_createsecretkey.Location = new Point(19, 497);
            btn_createsecretkey.Name = "btn_createsecretkey";
            btn_createsecretkey.Size = new Size(196, 61);
            btn_createsecretkey.TabIndex = 10;
            btn_createsecretkey.Text = "Create key";
            btn_createsecretkey.UseVisualStyleBackColor = true;
            // 
            // btn_saveseecertkey
            // 
            btn_saveseecertkey.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_saveseecertkey.Location = new Point(316, 497);
            btn_saveseecertkey.Name = "btn_saveseecertkey";
            btn_saveseecertkey.Size = new Size(196, 61);
            btn_saveseecertkey.TabIndex = 9;
            btn_saveseecertkey.Text = "Save key";
            btn_saveseecertkey.UseVisualStyleBackColor = true;
            // 
            // rb_secretkey
            // 
            rb_secretkey.Location = new Point(19, 87);
            rb_secretkey.Name = "rb_secretkey";
            rb_secretkey.Size = new Size(493, 382);
            rb_secretkey.TabIndex = 8;
            rb_secretkey.Text = "";
            // 
            // btn_createpublickey
            // 
            btn_createpublickey.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_createpublickey.Location = new Point(527, 497);
            btn_createpublickey.Name = "btn_createpublickey";
            btn_createpublickey.Size = new Size(196, 61);
            btn_createpublickey.TabIndex = 7;
            btn_createpublickey.Text = "Create key";
            btn_createpublickey.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(144, 15);
            label2.Name = "label2";
            label2.Size = new Size(216, 54);
            label2.TabIndex = 6;
            label2.Text = "Secret key";
            // 
            // btn_configpublickey
            // 
            btn_configpublickey.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_configpublickey.Location = new Point(824, 497);
            btn_configpublickey.Name = "btn_configpublickey";
            btn_configpublickey.Size = new Size(196, 61);
            btn_configpublickey.TabIndex = 5;
            btn_configpublickey.Text = "Config key";
            btn_configpublickey.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(677, 15);
            label1.Name = "label1";
            label1.Size = new Size(214, 54);
            label1.TabIndex = 4;
            label1.Text = "Public key";
            // 
            // rb_publickey
            // 
            rb_publickey.Location = new Point(527, 87);
            rb_publickey.Name = "rb_publickey";
            rb_publickey.Size = new Size(493, 382);
            rb_publickey.TabIndex = 3;
            rb_publickey.Text = "";
            // 
            // list_data
            // 
            list_data.Controls.Add(btn_);
            list_data.Controls.Add(btn_refresh);
            list_data.Controls.Add(flowLayoutPanel1);
            list_data.Controls.Add(btn_removedata);
            list_data.Controls.Add(btn_downdata);
            list_data.Controls.Add(btn_newdata);
            list_data.Location = new Point(4, 41);
            list_data.Name = "list_data";
            list_data.Size = new Size(1047, 638);
            list_data.TabIndex = 2;
            list_data.Text = "Data Manager";
            list_data.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(7, 13);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(155, 45);
            btn_refresh.TabIndex = 5;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 64);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1047, 574);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btn_removedata
            // 
            btn_removedata.Location = new Point(845, 13);
            btn_removedata.Name = "btn_removedata";
            btn_removedata.Size = new Size(196, 45);
            btn_removedata.TabIndex = 3;
            btn_removedata.Text = "Remove Data";
            btn_removedata.UseVisualStyleBackColor = true;
            // 
            // btn_downdata
            // 
            btn_downdata.Location = new Point(626, 13);
            btn_downdata.Name = "btn_downdata";
            btn_downdata.Size = new Size(213, 45);
            btn_downdata.TabIndex = 2;
            btn_downdata.Text = "Download Data";
            btn_downdata.UseVisualStyleBackColor = true;
            btn_downdata.Click += btn_downdata_Click;
            // 
            // btn_newdata
            // 
            btn_newdata.Location = new Point(456, 13);
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
            list_request.Size = new Size(1047, 638);
            list_request.TabIndex = 0;
            list_request.Text = "Request";
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
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(0, 63);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1047, 575);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // list_accepted
            // 
            list_accepted.Controls.Add(button1);
            list_accepted.Controls.Add(flowLayoutPanel3);
            list_accepted.Location = new Point(4, 41);
            list_accepted.Name = "list_accepted";
            list_accepted.Padding = new Padding(3);
            list_accepted.Size = new Size(1047, 638);
            list_accepted.TabIndex = 1;
            list_accepted.Text = "Accepted";
            list_accepted.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 12);
            button1.Name = "button1";
            button1.Size = new Size(155, 45);
            button1.TabIndex = 8;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(0, 63);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1047, 575);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // btn_
            // 
            btn_.Location = new Point(311, 13);
            btn_.Name = "btn_";
            btn_.Size = new Size(128, 45);
            btn_.TabIndex = 6;
            btn_.Text = "Find";
            btn_.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 684);
            Controls.Add(tabshow);
            Name = "User";
            Text = "User";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            tabshow.ResumeLayout(false);
            Key_setting.ResumeLayout(false);
            Key_setting.PerformLayout();
            list_data.ResumeLayout(false);
            list_request.ResumeLayout(false);
            list_accepted.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FileSystemWatcher fileSystemWatcher1;
        private TabControl tabshow;
        private TabPage list_request;
        private TabPage list_accepted;
        private TabPage list_data;
        private Button btn_newdata;
        private Button btn_downdata;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage Key_setting;
        private RichTextBox rb_secretkey;
        private Button btn_createpublickey;
        private Label label2;
        private Button btn_configpublickey;
        private Label label1;
        private RichTextBox rb_publickey;
        private Button btn_createsecretkey;
        private Button btn_saveseecertkey;
        private Button btn_refresh;
        private Button btn_refreshrequest;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btn_removedata;
        private Button btn_;
    }
}