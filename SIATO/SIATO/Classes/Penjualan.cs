using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SIATO.Classes.Partially;

namespace SIATO.Classes
{
    class Penjualan
    {
        public int id { get; set; }
        public Cabang cabang { get; set; }
        public string jenis { get; set; }
        public Konsumen konsumen { get; set; }
        public double subtotal { get; set; }
        public double diskon { get; set; }
        public double total { get; set; }
        public double uang_diterima { get; set; }
        public Partially.Pegawai cs { get; set; }
        public Partially.Pegawai kasir { get; set; }
        public int status { get; set; }
        public string tgl_transaksi { get; set; }
    }
}
