using CKNET_QLSP.DAL;
using CKNET_QLSP.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKNET_QLSP.BLL
{
    class BLL_QLSP
    {
        private static BLL_QLSP _Instance;
        public static BLL_QLSP Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLSP();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_QLSP()
        {
        }

        public List<CBB_TinhItems> GetAllTinh()
        {
            List<CBB_TinhItems> data = new List<CBB_TinhItems>();
            foreach(DiaChi i in DataQLSP.Instance.DiaChis)
            {
                CBB_TinhItems cbb = new CBB_TinhItems();
                cbb.MaTinh = i.MaTinh;
                cbb.TenTinh = i.TenTinh;
                data.Add(cbb);
            }
            return data;
        }

        

        public List<CBB_NCCItems> getListNCC(string query)
        {
            List<CBB_NCCItems> data = new List<CBB_NCCItems>();
            if (query=="all")
            {
                
                foreach (NhaCungCap i in DataQLSP.Instance.NhaCungCaps)
                {
                    data.Add(new CBB_NCCItems { MaNcc = i.MaNcc, MaTinh = i.MaTinh, TenNCC = i.TenNCC });
                }
            }
            else
            {
                foreach (NhaCungCap i in DataQLSP.Instance.NhaCungCaps.Where(p => p.MaTinh == query))
                {
                    data.Add(new CBB_NCCItems { MaNcc = i.MaNcc, MaTinh = i.MaTinh, TenNCC = i.TenNCC });
                }
            }
            
            return data;
        }


        public List<QLSPView> GetAllSP()
        {

            List<QLSPView> data = new List<QLSPView>();
            var query = from c in DataQLSP.Instance.SanPhams select new { c.NameSP, c.Gianhap, c.Ngaynhap, c.soluong, c.NhaCungCap.TenNCC, c.NhaCungCap.DiaChi.TenTinh };
            foreach (var i in query)
            {
                QLSPView sv = new QLSPView();
                sv.NameSP = i.NameSP;
                sv.Gianhap = i.Gianhap;
                sv.Ngaynhap = i.Ngaynhap;
                sv.TenNCC = i.TenNCC;
                sv.soluong = i.soluong;
                if (i.soluong == 0)
                {
                    sv.tinhtrang = false;

                }
                else
                {
                    sv.tinhtrang = true;
                }
                sv.TenTinh = i.TenTinh;
                data.Add(sv);
            }
            return data;
        }

        public List<QLSPView> GetSP(string ncc, string key)
        {
            List<QLSPView> data = new List<QLSPView>();

            foreach (QLSPView i in GetAllSP())
            {
                if (ncc == i.TenNCC && i.NameSP.ToLower().Contains(key.ToLower()))
                {
                    data.Add(i);
                }
            }
            return data;

        }
        public SanPham findSP_byname(string namesp)
        {
            int msp = DataQLSP.Instance.find_mspbyname(namesp);
            if (msp != -1)
            {
                SanPham sp = DataQLSP.Instance.SanPhams.Find(msp);
                return sp;
            }
            else
            {
                return null;
            }
            
        }

        

        public bool AddSP(SanPham sp)
        {
            try
            {
                DataQLSP.Instance.AddSP(sp);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteSP(List<string> name)
        {
            try
            {
                List<int> data = new List<int>();
                foreach (string j in name)
                {
                    foreach (SanPham i in DataQLSP.Instance.SanPhams)
                    {
                        if (i.NameSP == j)
                        {
                            data.Add(i.MSP);
                        }
                    }
                }
                DataQLSP.Instance.DeleteSP(data);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }

        public bool EditSP(SanPham sp)
        {
            try
            {
                DataQLSP.Instance.EditSP(sp);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }


    }
}
