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
    public partial class data_user : UserControl
    {
        public data_user()
        {
            InitializeComponent();
        }

        public void Setnameuser(string s)
        {
            lb_nameuser.Text = s;
        }

        public void Setmessage(string s)
        {
            lb_message.Text = s;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

        }
    }
}
