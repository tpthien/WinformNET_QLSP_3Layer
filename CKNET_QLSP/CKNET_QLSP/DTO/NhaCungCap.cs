using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKNET_QLSP.DTO
{
    public class NhaCungCap
    {
        public NhaCungCap()
        {
            SanPhams = new HashSet<SanPham>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNcc { get; set; }
        public string TenNCC { get; set; }
        public string MaTinh { get; set; }
        [ForeignKey("MaTinh")]
        public virtual DiaChi DiaChi { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
