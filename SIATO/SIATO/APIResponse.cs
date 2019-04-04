using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIATO
{
    public class APIResponse<T>
    {
        public bool error { get; set; }
        public string message { get; set; }
        public T data { get; set; }
    }
}
