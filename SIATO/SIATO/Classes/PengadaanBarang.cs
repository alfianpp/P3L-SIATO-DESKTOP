using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIATO.Classes
{
    class PengadaanBarang
    {
        public int id { get; set; }
        public Partially.Supplier supplier { get; set; }
        public double total { get; set; }
        public int status { get; set; }
        public string tgl_transaksi { get; set; }
    }
}
