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
    public partial class PengelolaanDataPegawai : Form
    {
        private string url = "http://127.0.0.1:8000/api/";
        private string api_key;

        public PengelolaanDataPegawai(string api_key)
        {
            InitializeComponent();
            this.api_key = api_key;
        }

        private void PengelolaanDataPegawai_Load(object sender, EventArgs e)
        {
            reloadTable();
        }

        private void reloadTable()
        {
            if (tbCariDataPegawai.Text != "")
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in dataGridViewDataPegawai.Columns)
                {
                    dt.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dataGridViewDataPegawai.Rows)
                {
                    DataRow dRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dRow);
                }

                DataView DV = new DataView(dt);
                DV.RowFilter = string.Format("nama LIKE '%{0}%'", tbCariDataPegawai.Text);
                dataGridViewDataPegawai.DataSource = DV;
            }
            else
            {
                var client = new RestClient(url);
                var request = new RestRequest("data/pegawai/index", Method.POST);
                request.AddParameter("api_key", api_key);
                var response = client.Execute<APIResponse<List<Pegawai>>>(request);
                if (!response.Data.error)
                {
                    
                    dataGridViewDataPegawai.DataSource = response.Data.data;
                }
                else
                {
                    MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void setTable()
        {
            dataGridViewDataPegawai.ClearSelection();
            dataGridViewDataPegawai.Columns[0].HeaderText = "username";
            dataGridViewDataPegawai.Columns[1].HeaderText = "password";
            dataGridViewDataPegawai.Columns[2].HeaderText = "nama";
            dataGridViewDataPegawai.Columns[3].HeaderText = "nomor telepon";
            dataGridViewDataPegawai.Columns[5].HeaderText = "alamat";
            dataGridViewDataPegawai.Columns[6].HeaderText = "gaji";
            dataGridViewDataPegawai.Columns[7].HeaderText = "peran";
        }

        private void tbCariDataPegawai_TextChanged(object sender, EventArgs e)
        {
            reloadTable();
        }

        private void btnGetDataPegawai_Click(object sender, EventArgs e)
        {
            int index = dataGridViewDataPegawai.CurrentCell.RowIndex;
            tbDataPegawaiID.Text = dataGridViewDataPegawai[0, index].Value.ToString();
            tbDataPegawaiUsername.Text = dataGridViewDataPegawai[1, index].Value.ToString();
            tbDataPegawaiNama.Text = dataGridViewDataPegawai[2, index].Value.ToString();
            tbDataPegawaiNomorTelepon.Text = dataGridViewDataPegawai[3, index].Value.ToString();
            tbDataPegawaiAlamat.Text = dataGridViewDataPegawai[4, index].Value.ToString();
            tbDataPegawaiGaji.Text = dataGridViewDataPegawai[5, index].Value.ToString();
            tbDataPegawaiPeran.Text = dataGridViewDataPegawai[6, index].Value.ToString();
        }

        private void btnTambahDataPegawai_Click(object sender, EventArgs e)
        {
            var client = new RestClient(url);
            var request = new RestRequest("data/pegawai", Method.POST);
            request.AddParameter("username", tbDataPegawaiUsername.Text);
            request.AddParameter("password", tbDataPegawaiPassword.Text);
            request.AddParameter("nama", tbDataPegawaiNama.Text);
            request.AddParameter("nomor_telepon", tbDataPegawaiNomorTelepon.Text);
            request.AddParameter("alamat", tbDataPegawaiAlamat.Text);
            request.AddParameter("gaji", tbDataPegawaiGaji.Text);
            request.AddParameter("role", tbDataPegawaiPeran.Text);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<FormError>>(request);
            if (!response.Data.error)
            {
                reloadTable();
                MessageBox.Show(response.Data.message, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnUbahDataPegawai_Click(object sender, EventArgs e)
        {
            int index = dataGridViewDataPegawai.CurrentCell.RowIndex;
            var client = new RestClient(url);
            var request = new RestRequest("data/pegawai/" + dataGridViewDataPegawai[0, index].Value.ToString(), Method.PUT);
            request.AddParameter("username", tbDataPegawaiUsername.Text);
            request.AddParameter("password", tbDataPegawaiPassword.Text);
            request.AddParameter("nama", tbDataPegawaiNama.Text);
            request.AddParameter("nomor_telepon", tbDataPegawaiNomorTelepon.Text);
            request.AddParameter("alamat", tbDataPegawaiAlamat.Text);
            request.AddParameter("gaji", tbDataPegawaiGaji.Text);
            request.AddParameter("role", tbDataPegawaiPeran.Text);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<FormError>>(request);
            if (!response.Data.error)
            {
                reloadTable();
                MessageBox.Show(response.Data.message, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapusDataPegawai_Click(object sender, EventArgs e)
        {
            int index = dataGridViewDataPegawai.CurrentCell.RowIndex;
            var client = new RestClient(url);
            var request = new RestRequest("data/pegawai/" + dataGridViewDataPegawai[0, index].Value.ToString(), Method.DELETE);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<FormError>>(request);
            if (!response.Data.error)
            {
                reloadTable();
                MessageBox.Show(response.Data.message, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




    }
}
