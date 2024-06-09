using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT219_FinalProject
{
    public partial class Down_file : UserControl
    {
        public Down_file()
        {
            InitializeComponent();
        }

        public void Setnameuser(string s)
        {
            lb_nameuser.Text = s;
        }
        public void Setfilename(string s)
        {
            lb_filename.Text = s;
        }
        public void Setmessage(string s)
        {
            lb_message.Text = s;
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = lb_filename.Text;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string fileContent = lb_message.Text;
                System.IO.File.WriteAllText(filePath, fileContent);
            }
        }
    }
}
