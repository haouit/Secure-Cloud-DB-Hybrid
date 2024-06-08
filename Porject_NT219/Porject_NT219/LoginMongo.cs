using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace NT219_FinalProject
{
    public partial class LoginMongo : Form
    {
        public LoginMongo()
        {
            InitializeComponent();
        }


        private async void btn_signin_Click(object sender, EventArgs e)
        {
            string connectionUri = $"mongodb+srv://{tb_username.Text}:{tb_password.Text}@nt219.aqc0g5i.mongodb.net/?retryWrites=true&w=majority&appName=NT219";
            var settings = MongoClientSettings.FromConnectionString(connectionUri);

            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);

            try
            {
                var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                MessageBox.Show($"{result}");
                MessageBox.Show("Pinged your deployment. You successfully connected to MongoDB!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
