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

namespace SIATO
{
    public partial class SIATOForm : Form
    {
        private LoginForm _loginForm;
        private Pegawai logged_in_user;

        public SIATOForm(LoginForm _loginForm, Pegawai logged_in_user)
        {
            InitializeComponent();
            this._loginForm = _loginForm;
            this.logged_in_user = logged_in_user;
        }

        private void SIATOForm_Load(object sender, EventArgs e)
        {
            reloadTable();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            _loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://127.0.0.1:8000/api/");
            var request = new RestRequest("data/jasaservice", Method.POST);
            request.AddParameter("nama", textBox1.Text);
            request.AddParameter("harga_jual", textBox2.Text);
            request.AddParameter("api_key", logged_in_user.api_key);
            var response = client.Execute<APIResponse<FormError>>(request);
            if (!response.Data.error)
            {
                reloadTable();
                MessageBox.Show(response.Data.message, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(response.Data.data != null)
                {
                    if (response.Data.data.nama.Count > 0)
                    {
                        MessageBox.Show(response.Data.data.nama[0], "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (response.Data.data.harga_jual.Count > 0)
                    {
                        MessageBox.Show(response.Data.data.harga_jual[0], "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void reloadTable()
        {
            var client = new RestClient("http://127.0.0.1:8000/api/");
            var request = new RestRequest("data/jasaservice/index", Method.POST);
            request.AddParameter("api_key", logged_in_user.api_key);
            var response = client.Execute<APIResponse<List<JasaService>>>(request);
            if (!response.Data.error)
            {
                dataGridView1.DataSource = response.Data.data;
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
