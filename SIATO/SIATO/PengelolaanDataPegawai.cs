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
    public partial class PengelolaanDataPegawai : Form
    {
        public string api_key;

        private int selectedPegawaiID = -1;
        private List<Pegawai> listPegawai;
        private List<Pegawai> listPegawaiFiltered;

        public PengelolaanDataPegawai()
        {
            InitializeComponent();
        }

        private void PengelolaanDataPegawai_Load(object sender, EventArgs e)
        {
            clear();
            refreshTable();
        }

        private void btnSimpanPegawai_Click(object sender, EventArgs e)
        {
            if(selectedPegawaiID == -1)
            {
                store();
            }
            else
            {
                update();
            }
        }

        private void btnHapusPegawai_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnBatalPegawai_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void tbCariPegawai_TextChanged(object sender, EventArgs e)
        {
            if (tbCariPegawai.Text != "")
            {
                List<Pegawai> filteredList = listPegawai.Where(pegawai => pegawai.nama.ToLower().Contains(tbCariPegawai.Text.ToLower())).ToList();
                listPegawaiFiltered = filteredList;
            }
            else
            {
                listPegawaiFiltered = listPegawai;
            }

            setTable();
        }

        private void dataGridViewPegawai_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            show();
            btnSimpanPegawai.Text = "Ubah";
            btnHapusPegawai.Enabled = true;
        }

        private void setTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nama");
            dt.Columns.Add("Nomor Telepon");
            dt.Columns.Add("Alamat");
            dt.Columns.Add("Gaji");
            dt.Columns.Add("Peran");

            foreach (Pegawai pegawai in listPegawaiFiltered)
            {
                DataRow row = dt.NewRow();
                row[0] = pegawai.nama;
                row[1] = pegawai.nomor_telepon;
                row[2] = pegawai.alamat;
                row[3] = pegawai.gaji;
                row[4] = pegawai.role;
                dt.Rows.Add(row);
            }

            DataView dv = new DataView(dt);
            dataGridViewPegawai.DataSource = dv;
            dataGridViewPegawai.ClearSelection();
        }

        private void index()
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/data/pegawai/index", Method.POST);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<List<Pegawai>>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                listPegawai = apiResponse.data;
                listPegawaiFiltered = apiResponse.data;
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void store()
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/data/pegawai", Method.POST);
            request.AddParameter("username", tbPegawaiUsername.Text);
            request.AddParameter("password", tbPegawaiPassword.Text);
            request.AddParameter("nama", tbPegawaiNama.Text);
            request.AddParameter("nomor_telepon", tbPegawaiNomorTelepon.Text);
            request.AddParameter("alamat", tbPegawaiAlamat.Text);
            request.AddParameter("gaji", tbPegawaiGaji.Text);
            request.AddParameter("role", tbPegawaiPeran.Text);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<Pegawai>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                MessageBox.Show(apiResponse.message, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
                refreshTable();
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void show()
        {
            int index = dataGridViewPegawai.CurrentCell.RowIndex;
            selectedPegawaiID = listPegawaiFiltered[index].id;
            tbPegawaiUsername.Text = listPegawaiFiltered[index].username.ToString();
            tbPegawaiUsername.Enabled = false;
            tbPegawaiNama.Text = listPegawaiFiltered[index].nama.ToString();
            tbPegawaiNomorTelepon.Text = listPegawaiFiltered[index].nomor_telepon.ToString();
            tbPegawaiAlamat.Text = listPegawaiFiltered[index].alamat.ToString();
            tbPegawaiGaji.Text = listPegawaiFiltered[index].gaji.ToString();
            tbPegawaiPeran.Text = listPegawaiFiltered[index].role.ToString();
        }

        private void update()
        {
            int index = dataGridViewPegawai.CurrentCell.RowIndex;
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/data/pegawai/" + listPegawaiFiltered[index].id.ToString(), Method.PUT);
            request.AddParameter("password", tbPegawaiPassword.Text);
            request.AddParameter("nama", tbPegawaiNama.Text);
            request.AddParameter("nomor_telepon", tbPegawaiNomorTelepon.Text);
            request.AddParameter("alamat", tbPegawaiAlamat.Text);
            request.AddParameter("gaji", tbPegawaiGaji.Text);
            request.AddParameter("role", tbPegawaiPeran.Text);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<Pegawai>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                MessageBox.Show(apiResponse.message, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
                refreshTable();
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delete()
        {
            int index = dataGridViewPegawai.CurrentCell.RowIndex;
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/data/pegawai/" + listPegawaiFiltered[index].id.ToString(), Method.DELETE);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<Pegawai>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                MessageBox.Show(apiResponse.message, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
                refreshTable();
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void refreshTable()
        {
            index();
            setTable();
        }

        private void clear()
        {
            selectedPegawaiID = -1;
            tbPegawaiUsername.Text = "";
            tbPegawaiUsername.Enabled = true;
            tbPegawaiPassword.Text = "";
            tbPegawaiNama.Text = "";
            tbPegawaiNomorTelepon.Text = "";
            tbPegawaiAlamat.Text = "";
            tbPegawaiGaji.Text = "";
            tbPegawaiPeran.Text = "";
            btnSimpanPegawai.Text = "Tambah";
            btnHapusPegawai.Enabled = false;
        }
    }
}
