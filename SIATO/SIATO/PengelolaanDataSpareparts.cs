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

using SIATO.Classes;

namespace SIATO
{
    public partial class PengelolaanDataSpareparts : Form
    {
        public string api_key;

        public string selectedSparepartsKode = "";
        private List<Spareparts> listSpareparts;
        private List<Spareparts> listSparepartsFiltered;

        public PengelolaanDataSpareparts()
        {
            InitializeComponent();
        }

        private void PengelolaanDataSpareparts_Load(object sender, EventArgs e)
        {
            clear();
            refreshTable();
        }

        private void btnSimpanSpareparts_Click(object sender, EventArgs e)
        {
            if(selectedSparepartsKode == "")
            {
                store();
            }
            else
            {
                update();
            }
        }

        private void btnHapusSpareparts_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnBatalSpareparts_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void tbCariSpareparts_TextChanged(object sender, EventArgs e)
        {
            if (tbCariSpareparts.Text != "")
            {
                List<Spareparts> filteredList = listSpareparts.Where(spareparts => spareparts.nama.ToLower().Contains(tbCariSpareparts.Text.ToLower())).ToList();
                listSparepartsFiltered = filteredList;
            }
            else
            {
                listSparepartsFiltered = listSpareparts;
            }

            setTable();
        }

        private void dataGridViewSpareparts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            show();
            btnSimpanSpareparts.Text = "Ubah";
            btnHapusSpareparts.Enabled = true;
        }

        private void setTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Kode");
            dt.Columns.Add("Nama");
            dt.Columns.Add("Merk");
            dt.Columns.Add("Tipe");
            dt.Columns.Add("Harga Beli");
            dt.Columns.Add("Harga Jual");
            dt.Columns.Add("Peletakan");

            foreach (Spareparts spareparts in listSparepartsFiltered)
            {
                DataRow row = dt.NewRow();
                row[0] = spareparts.kode;
                row[1] = spareparts.nama;
                row[2] = spareparts.merk;
                row[3] = spareparts.tipe;
                row[4] = spareparts.harga_beli;
                row[5] = spareparts.harga_jual;
                row[6] = spareparts.kode_peletakan;
                dt.Rows.Add(row);
            }

            DataView dv = new DataView(dt);
            dataGridViewSpareparts.DataSource = dv;
            dataGridViewSpareparts.ClearSelection();
        }

        private void index()
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/data/spareparts/index", Method.POST);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<List<Spareparts>>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                listSpareparts = apiResponse.data;
                listSparepartsFiltered = apiResponse.data;
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void store()
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/data/spareparts", Method.POST);
            request.AddParameter("kode", tbSparepartsKode.Text);
            request.AddParameter("nama", tbSparepartsNama.Text);
            request.AddParameter("merk", tbSparepartsMerk.Text);
            request.AddParameter("tipe", tbSparepartsTipe.Text);
            request.AddParameter("kode_peletakan", tbSparepartsKodePeletakan.Text);
            request.AddParameter("harga_beli", tbSparepartsHargaBeli.Text);
            request.AddParameter("harga_jual", tbSparepartsHargaJual.Text);
            request.AddParameter("stok", tbSparepartsStok.Text);
            request.AddParameter("stok_minimal", tbSparepartsStokMinimal.Text);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<Spareparts>>(request);

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
            int index = dataGridViewSpareparts.CurrentCell.RowIndex;
            selectedSparepartsKode = listSparepartsFiltered[index].kode;
            tbSparepartsKode.Text = listSparepartsFiltered[index].kode.ToString();
            tbSparepartsKode.Enabled = false;
            tbSparepartsNama.Text = listSparepartsFiltered[index].nama.ToString();
            tbSparepartsMerk.Text = listSparepartsFiltered[index].merk.ToString();
            tbSparepartsTipe.Text = listSparepartsFiltered[index].tipe.ToString();
            tbSparepartsKodePeletakan.Text = listSparepartsFiltered[index].kode_peletakan.ToString();
            tbSparepartsHargaBeli.Text = listSparepartsFiltered[index].harga_beli.ToString();
            tbSparepartsHargaJual.Text = listSparepartsFiltered[index].harga_jual.ToString();
            tbSparepartsStok.Text = listSparepartsFiltered[index].stok.ToString();
            tbSparepartsStok.Enabled = false;
            tbSparepartsStokMinimal.Text = listSparepartsFiltered[index].stok_minimal.ToString();
        }

        private void update()
        {
            int index = dataGridViewSpareparts.CurrentCell.RowIndex;
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/data/spareparts/" + listSparepartsFiltered[index].kode.ToString(), Method.PUT);
            request.AddParameter("nama", tbSparepartsNama.Text);
            request.AddParameter("merk", tbSparepartsMerk.Text);
            request.AddParameter("tipe", tbSparepartsTipe.Text);
            request.AddParameter("kode_peletakan", tbSparepartsKodePeletakan.Text);
            request.AddParameter("harga_beli", tbSparepartsHargaBeli.Text);
            request.AddParameter("harga_jual", tbSparepartsHargaJual.Text);
            request.AddParameter("stok_minimal", tbSparepartsStokMinimal.Text);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<Spareparts>>(request);

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
            int index = dataGridViewSpareparts.CurrentCell.RowIndex;
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/data/spareparts/" + listSparepartsFiltered[index].kode.ToString(), Method.DELETE);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<Spareparts>>(request);

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
            selectedSparepartsKode = "";
            tbSparepartsKode.Text = "";
            tbSparepartsNama.Text = "";
            tbSparepartsMerk.Text = "";
            tbSparepartsTipe.Text = "";
            tbSparepartsKodePeletakan.Text = "";
            tbSparepartsHargaBeli.Text = "";
            tbSparepartsHargaJual.Text = "";
            tbSparepartsStok.Text = "";
            tbSparepartsStokMinimal.Text = "";
            btnSimpanSpareparts.Text = "Tambah";
            btnHapusSpareparts.Enabled = false;
            
        }
    }
}
