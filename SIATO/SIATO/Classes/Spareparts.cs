using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIATO.Classes
{
    class Spareparts
    {
        public string kode { get; set; }
        public string nama { get; set; }
        public string merk { get; set; }
        public string tipe { get; set; }
        public string kode_peletakan { get; set; }
        public double harga_beli { get; set; }
        public double harga_jual { get; set; }
        public int stok { get; set; }
        public int stok_minimal { get; set; }
        public string url_gambar { get; set; }
    }
}
