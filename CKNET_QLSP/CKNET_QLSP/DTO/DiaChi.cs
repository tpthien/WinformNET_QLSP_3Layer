using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKNET_QLSP.DTO
{
    public class DiaChi
    {
        public DiaChi()
        {
            NhaCungCaps = new HashSet<NhaCungCap>();
        }
        [Key]
        public string MaTinh { get; set; }
        public string TenTinh { get; set; }
        public virtual ICollection<NhaCungCap> NhaCungCaps { get; set; }
    }
}
