using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKNET_QLSP.DTO
{
    class QLSPView
    {
        public string NameSP { get; set; }
        public float Gianhap { get; set; }
        public DateTime Ngaynhap { get; set; }
        public bool tinhtrang { get; set; }
        public int soluong { get; set; }
        public string TenNCC { get; set; }
        public string TenTinh { get; set; }
    }
}
