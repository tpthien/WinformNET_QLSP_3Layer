using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKNET_QLSP.DTO
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MSP { get; set; }
        public string NameSP { get; set; }
        public float Gianhap { get; set; }
        public DateTime Ngaynhap { get; set; }
        public int soluong { get; set; }
        public int MaNcc { get; set; }
        [ForeignKey("MaNcc")]
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
