using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKNET_QLSP.DTO
{
    class CBB_NCCItems
    {
        public int MaNcc { get; set; }
        public string MaTinh { get; set; }
        public string TenNCC { get; set; }
        public override string ToString()
        {
            return TenNCC;
        }
    }
}
