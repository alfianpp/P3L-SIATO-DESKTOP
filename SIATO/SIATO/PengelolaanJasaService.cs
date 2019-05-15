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
    public partial class PengelolaanJasaService : Form
    {
        private string url = "http://127.0.0.1:8000/api/";
        private string api_key;

        public PengelolaanJasaService(string api_key)
        {
            InitializeComponent();
            this.api_key = api_key;
        }

        private void PengelolaanJasaService_Load(object sender, EventArgs e)
        {
            reloadTable();
        }

        private void reloadTable()
        {
            if (tbCariJasaService.Text != "")
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in dataGridViewJasaService.Columns)
                {
                    dt.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dataGridViewJasaService.Rows)
                {
                    DataRow dRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dRow);
                }

                DataView DV = new DataView(dt);
                DV.RowFilter = string.Format("nama LIKE '%{0}%'", tbCariJasaService.Text);
                dataGridViewJasaService.DataSource = DV;
            }
            else
            {
                var client = new RestClient(url);
                var request = new RestRequest("data/jasaservice/index", Method.POST);
                request.AddParameter("api_key", api_key);
                var response = client.Execute<APIResponse<List<JasaService>>>(request);
                if (!response.Data.error)
                {
                    dataGridViewJasaService.DataSource = response.Data.data;
                    setTable();
                }
                else
                {
                    MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void setTable()
        {
            dataGridViewJasaService.ClearSelection();
            dataGridViewJasaService.Columns[0].HeaderText = "ID";
            dataGridViewJasaService.Columns[1].HeaderText = "Nama";
            dataGridViewJasaService.Columns[2].HeaderText = "Harga Jual";
        }

        private void tbCariJasaService_TextChanged(object sender, EventArgs e)
        {
            reloadTable();
        }

        private void btnGetDataJasaService_Click(object sender, EventArgs e)
        {
            int index = dataGridViewJasaService.CurrentCell.RowIndex;
            tbJasaServiceNama.Text = dataGridViewJasaService[1, index].Value.ToString();
            tbJasaServiceHargaJual.Text = dataGridViewJasaService[2, index].Value.ToString();
        }

        private void btnTambahJasaService_Click(object sender, EventArgs e)
        {
            var client = new RestClient(url);
            var request = new RestRequest("data/jasaservice", Method.POST);
            request.AddParameter("nama", tbJasaServiceNama.Text);
            request.AddParameter("harga_jual", tbJasaServiceHargaJual.Text);
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

        private void btnUbahJasaService_Click(object sender, EventArgs e)
        {
            int index = dataGridViewJasaService.CurrentCell.RowIndex;
            var client = new RestClient(url);
            var request = new RestRequest("data/jasaservice/" + dataGridViewJasaService[0, index].Value.ToString(), Method.PUT);
            request.AddParameter("nama", tbJasaServiceNama.Text);
            request.AddParameter("harga_jual", tbJasaServiceHargaJual.Text);
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

        private void btnHapusJasaService_Click(object sender, EventArgs e)
        {
            int index = dataGridViewJasaService.CurrentCell.RowIndex;
            var client = new RestClient(url);
            var request = new RestRequest("data/jasaservice/" + dataGridViewJasaService[0, index].Value.ToString(), Method.DELETE);
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
