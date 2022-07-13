using CKNET_QLSP.BLL;
using CKNET_QLSP.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKNET_QLSP.View
{
    public partial class form_Detail : Form
    {
        int check = 0;
        int masanpham;
        public delegate void Mydel();
        public Mydel d { get; set; }
        public form_Detail()
        {
            InitializeComponent();
            SetCBB();
        }
        public form_Detail(string namesp, string tentinh, string tenncc)
        {
            check = 1;
            SanPham sp = BLL_QLSP.Instance.findSP_byname(namesp);
            this.masanpham = sp.MSP;
            InitializeComponent();
            txt_nameSP.Text = sp.NameSP;
            txt_Gianhap.Text = sp.Gianhap.ToString();
            txt_Soluong.Text = sp.soluong.ToString();
            pick_NgayNhap.Value = sp.Ngaynhap;
            SetCBB(tentinh, tenncc);
            

        }

        public void SetCBB()
        {
            cbb_Tinh.Items.AddRange(BLL_QLSP.Instance.GetAllTinh().ToArray());
            cbb_Tinh.SelectedIndex = 0;
        }
        public void SetCBB(string tentinh, string tenncc)
        {
            SetCBB();
            cbb_Tinh.SelectedIndex = cbb_Tinh.FindStringExact(tentinh);
            cbb_NhaCungCap.Items.Clear();
            string matinh = ((CBB_TinhItems)cbb_Tinh.SelectedItem).MaTinh;
            cbb_NhaCungCap.Items.AddRange(BLL_QLSP.Instance.getListNCC(matinh).ToArray());
            cbb_NhaCungCap.SelectedIndex = cbb_NhaCungCap.FindStringExact(tenncc);

        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            check = 0;
            this.Close();
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            if(check == 0)
            {
                //add
                SanPham sp = new SanPham();
                sp.NameSP = txt_nameSP.Text.ToString();
                sp.Gianhap = float.Parse(txt_Gianhap.Text.ToString());
                sp.Ngaynhap = pick_NgayNhap.Value;
                sp.soluong = Convert.ToInt32(txt_Soluong.Text.ToString());
                sp.MaNcc = ((CBB_NCCItems)cbb_NhaCungCap.SelectedItem).MaNcc;

                if (BLL_QLSP.Instance.AddSP(sp))
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Them that bai");
                }
            }

            else
            {
                SanPham sp = new SanPham();
                sp.MSP = masanpham;
                sp.NameSP = txt_nameSP.Text.ToString();
                sp.Gianhap = float.Parse(txt_Gianhap.Text.ToString());
                sp.Ngaynhap = pick_NgayNhap.Value;
                sp.soluong = Convert.ToInt32(txt_Soluong.Text.ToString());
                sp.MaNcc = ((CBB_NCCItems)cbb_NhaCungCap.SelectedItem).MaNcc;
                if(BLL_QLSP.Instance.EditSP(sp))
                {
                    MessageBox.Show("Sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Sua that bai");
                }
                //edit
                check = 0;
            }

            d();



        }

        private void cbb_Tinh_TextChanged(object sender, EventArgs e)
        {
            cbb_NhaCungCap.Items.Clear();
            string ncc = ((CBB_TinhItems)cbb_Tinh.SelectedItem).MaTinh;
            cbb_NhaCungCap.Items.AddRange(BLL_QLSP.Instance.getListNCC(ncc).ToArray());
            cbb_NhaCungCap.SelectedIndex = 0;
        }
    }
}
