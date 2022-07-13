using CKNET_QLSP.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKNET_QLSP.DAL
{
    public class DataQLSP : DbContext
    {
        private static DataQLSP _Instance;
        public static DataQLSP Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new DataQLSP();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        private DataQLSP()
            : base("name=DataQLSP")
        {
            Database.SetInitializer<DataQLSP>(new CreateDB());
        }

        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<DiaChi> DiaChis { get; set; }

        public void AddSP(SanPham sp)
        {
            using (DataQLSP db = new DataQLSP())
            {
                db.SanPhams.Add(sp);
                db.SaveChanges();
            }
        }


        public void DeleteSP(List<int> data)
        {
            using (DataQLSP db = new DataQLSP())
            {
                foreach (int mssp in data)
                {
                    SanPham sp = db.SanPhams.Find(mssp);
                    db.SanPhams.Remove(sp);
                }
                db.SaveChanges();
            }
        }
        public int find_mspbyname(string namesp)
        {
            int msp = -1;
            using (DataQLSP db = new DataQLSP())
            {
                foreach(SanPham sp in db.SanPhams)
                {
                    if(sp.NameSP==namesp)
                    {
                        msp = sp.MSP;
                    }
                }
            }
            return msp;
        }

        public void EditSP(SanPham sp)
        {
            using(DataQLSP db = new DataQLSP())
            {
                SanPham s = db.SanPhams.Find(sp.MSP);
                s.NameSP = sp.NameSP;
                s.Gianhap = sp.Gianhap;
                s.Ngaynhap = sp.Ngaynhap;
                s.soluong = sp.soluong;
                s.MaNcc = sp.MaNcc;
                db.SaveChanges();
            }
        }

    }


}
