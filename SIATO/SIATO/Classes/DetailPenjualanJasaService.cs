using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SIATO.Classes.Partially;

namespace SIATO.Classes
{
    class DetailPenjualanJasaService
    {
        public int id { get; set; }
        public int id_detail_penjualan { get; set; }
        public JasaService jasa_service { get; set; }
        public int jumlah { get; set; }
        public double harga { get; set; }
    }
}
