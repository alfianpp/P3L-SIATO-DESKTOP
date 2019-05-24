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
    public partial class PengelolaanJasaService : Form
    {
        public string api_key;

        private int selectedJasaServiceID = -1;
        private List<JasaService> listJasaService;
        private List<JasaService> listJasaServiceFiltered;

        public PengelolaanJasaService()
        {
            InitializeComponent();
        }

        private void PengelolaanJasaService_Load(object sender, EventArgs e)
        {
            clear();
            refreshTable();
        }

        private void btnSimpanJasaService_Click(object sender, EventArgs e)
        {
            if (selectedJasaServiceID == -1)
            {
                store();
            }
            else
            {
                update();
            }
        }

        private void btnHapusJasaService_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnBatalJasaService_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void tbCariJasaService_TextChanged(object sender, EventArgs e)
        {
            if (tbCariJasaService.Text != "")
            {
                List<JasaService> filteredList = listJasaService.Where(jasa_service => jasa_service.nama.ToLower().Contains(tbCariJasaService.Text.ToLower())).ToList();
                listJasaServiceFiltered = filteredList;
            }
            else
            {
                listJasaServiceFiltered = listJasaService;
            }

            setTable();
        }

        private void dataGridViewJasaService_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            show();
            btnSimpanJasaService.Text = "Ubah";
            btnHapusJasaService.Enabled = true;
        }

        private void setTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nama");
            dt.Columns.Add("Harga Jual");

            foreach (JasaService jasa_service in listJasaServiceFiltered)
            {
                DataRow row = dt.NewRow();
                row[0] = jasa_service.nama;
                row[1] = jasa_service.harga_jual;
                dt.Rows.Add(row);
            }

            DataView dv = new DataView(dt);
            dataGridViewJasaService.DataSource = dv;
            dataGridViewJasaService.ClearSelection();
        }

        private void index()
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/data/jasaservice/index", Method.POST);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<List<JasaService>>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                listJasaService = apiResponse.data;
                listJasaServiceFiltered = apiResponse.data;
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void store()
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/data/jasaservice", Method.POST);
            request.AddParameter("nama", tbJasaServiceNama.Text);
            request.AddParameter("harga_jual", tbJasaServiceHargaJual.Text);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<JasaService>>(request);

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
            int index = dataGridViewJasaService.CurrentCell.RowIndex;
            selectedJasaServiceID = listJasaServiceFiltered[index].id;
            tbJasaServiceNama.Text = listJasaServiceFiltered[index].nama.ToString();
            tbJasaServiceHargaJual.Text = listJasaServiceFiltered[index].harga_jual.ToString();
        }

        private void update()
        {
            int index = dataGridViewJasaService.CurrentCell.RowIndex;
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/data/jasaservice/" + listJasaServiceFiltered[index].id.ToString(), Method.PUT);
            request.AddParameter("nama", tbJasaServiceNama.Text);
            request.AddParameter("harga_jual", tbJasaServiceHargaJual.Text);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<JasaService>>(request);

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
            int index = dataGridViewJasaService.CurrentCell.RowIndex;
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/data/jasaservice/" + listJasaServiceFiltered[index].id.ToString(), Method.DELETE);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<JasaService>>(request);

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
            selectedJasaServiceID = -1;
            tbJasaServiceNama.Text = "";
            tbJasaServiceHargaJual.Text = "";
            btnSimpanJasaService.Text = "Tambah";
            btnHapusJasaService.Enabled = false;
        }
    }
}
