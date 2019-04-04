using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

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
            var client = new RestClient("http://127.0.0.1:8000/api/");
            var request = new RestRequest("auth/pegawai", Method.POST);
            request.AddParameter("username", tbUsername.Text);
            request.AddParameter("password", tbPassword.Text);
            var response = client.Execute<APIResponse<Pegawai>>(request);
            if (!response.Data.error)
            {
                SIATOForm siatoForm = new SIATOForm(this, response.Data.data);
                siatoForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
