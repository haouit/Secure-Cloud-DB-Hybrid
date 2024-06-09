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
    public partial class Accepted : UserControl
    {
        public Accepted()
        {
            InitializeComponent();
        }

        public void Setnamerequest(string s)
        {
            lb_namerequest.Text = s;
        }
        public void Setnameuser(string s)
        {
            lb_nameuser.Text = s;
        }
        public void Setmessage(string s)
        {
            lb_message.Text = s;
        }
    }
}
