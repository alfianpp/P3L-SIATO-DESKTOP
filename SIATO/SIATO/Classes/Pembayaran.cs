using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SIATO.Classes.Partially;
using SIATO.Classes.Special;

namespace SIATO.Classes
{
    class Pembayaran
    {
        public string nomor_transaksi { get; set; }
        public Konsumen konsumen { get; set; }
        public List<Partially.Kendaraan> kendaraan { get; set; }
        public List<DetailPenjualanSpareparts> spareparts { get; set; }
        public List<DetailPenjualanJasaService> jasa_service { get; set; }
        public SubtotalPembayaran subtotal { get; set; }
        public double diskon { get; set; }
        public double total { get; set; }
        public Partially.Pegawai cs { get; set; }
        public Partially.Pegawai kasir { get; set; }
        public List<Partially.Pegawai> montir { get; set; }
        public string tgl_transaksi { get; set; }
    }
}
