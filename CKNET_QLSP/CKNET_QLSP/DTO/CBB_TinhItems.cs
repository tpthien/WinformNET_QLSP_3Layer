using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKNET_QLSP.DTO
{
    class CBB_TinhItems
    {
        public string MaTinh { get; set; }
        public string TenTinh { get; set; }
        public override string ToString()
        {
            return TenTinh;
        }
    }
}
