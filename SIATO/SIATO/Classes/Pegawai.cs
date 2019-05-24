using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIATO.Classes
{
    public class Pegawai
    {
        public int id { get; set; }
        public string username { get; set; }
        public string nama { get; set; }
        public string nomor_telepon { get; set; }
        public string alamat { get; set; }
        public double gaji { get; set; }
        public int role { get; set; }
        public string api_key { get; set; }
    }
}
