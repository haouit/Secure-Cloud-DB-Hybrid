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

        public void Setdataname(string s)
        {
            lb_dataname.Text = s;
        }
        public void Setname(string s)
        {
            lb_name.Text = s;
        }
        public void Setdataid(string s)
        {
            lb_dataid.Text = s;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

        }
    }
}
