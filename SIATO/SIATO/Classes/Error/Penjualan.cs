using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIATO.Classes.Error
{
    class Penjualan
    {
        public List<string> id_cabang { get; set; }
        public List<string> jenis { get; set; }
        public List<string> id_konsumen { get; set; }
        public List<string> diskon { get; set; }
        public List<string> uang_diterima { get; set; }
        public List<string> id_cs { get; set; }
        public List<string> id_kasir { get; set; }
        public List<string> status { get; set; }
    }
}
