using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porject_NT219
{
    public partial class User : Form
    {
        private string receivedTokenType;
        private string receivedAccessToken;
        List<string> thongtin = new List<string>();

        public User(string tokentype, string accesstoken)
        {
            InitializeComponent();
            receivedTokenType = tokentype;
            receivedAccessToken = accesstoken;
        }
        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

        public class DataResponse
        {
            public List<Data> Data { get; set; }
        }

        public class Data
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name_data")]
            public string name_data { get; set; }

            [JsonProperty("name_user")]
            public string name_user { get; set; }
        }

        private void Addprogressbar(string name_data, string name_user, string Id)
        {
            Request data = new Request();
            data.Setname(name_data);
            data.Setdataname(name_user);
            data.Setdataid(Id);
        }

        private void btn_newdata_Click(object sender, EventArgs e)
        {
            DataManager dataForm = new DataManager();
            dataForm.Show();
        }

        private void btn_downdata_Click(object sender, EventArgs e)
        {
            //request data from server

        }
    }
}
