using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIATO.Classes
{
    class DetailPengadaanBarang
    {
        public int id { get; set; }
        public int id_pengadaan_barang { get; set; }
        public Partially.Spareparts spareparts { get; set; }
        public int jumlah_pesan { get; set; }
        public int jumlah_datang { get; set; }
        public double harga { get; set; }
    }
}
