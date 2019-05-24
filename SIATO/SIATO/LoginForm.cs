using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SIATO.Classes;

namespace SIATO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/auth/pegawai", Method.POST);
            request.AddParameter("username", tbUsername.Text);
            request.AddParameter("password", tbPassword.Text);
            var response = client.Execute<APIResponse<Pegawai>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                Dashboard dashboard = new Dashboard(this, apiResponse.data);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
