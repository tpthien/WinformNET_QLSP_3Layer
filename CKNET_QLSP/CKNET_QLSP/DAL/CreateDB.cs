using CKNET_QLSP.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKNET_QLSP.DAL
{
    class CreateDB :
        CreateDatabaseIfNotExists<DataQLSP>
    {
        protected override void Seed(DataQLSP context)
        {
            context.DiaChis.AddRange(new DiaChi[]
            {
                new DiaChi {MaTinh = "01", TenTinh = "Quang Ngai"},
                new DiaChi {MaTinh = "02", TenTinh = "Quang Nam"},

            });
            context.NhaCungCaps.AddRange(new NhaCungCap[]
            {
                new NhaCungCap {MaNcc = 1, TenNCC = "AAA", MaTinh = "01"},
                new NhaCungCap {MaNcc = 2, TenNCC = "BBB", MaTinh = "02"},
                new NhaCungCap {MaNcc = 3, TenNCC = "CCC", MaTinh = "01"}
            });
            context.SanPhams.AddRange(new SanPham[]
            {
                new SanPham {MSP = 1, NameSP="Banh", Gianhap = 4.5f, Ngaynhap = DateTime.Now, soluong =4, MaNcc = 1},
                new SanPham {MSP = 2, NameSP="Keo", Gianhap = 4.5f, Ngaynhap = DateTime.Now, soluong =4, MaNcc = 2},
            });
        }
    }
}
