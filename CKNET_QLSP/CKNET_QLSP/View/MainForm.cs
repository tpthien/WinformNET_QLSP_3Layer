using CKNET_QLSP.BLL;
using CKNET_QLSP.DTO;
using CKNET_QLSP.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKNET_QLSP
{
    public partial class form_Main : Form
    {
        public form_Main()
        {
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {
            cbb_TinhTP.Items.Add(new CBB_TinhItems { MaTinh = "all", TenTinh = "All" });
            cbb_TinhTP.Items.AddRange(BLL_QLSP.Instance.GetAllTinh().ToArray());
            cbb_TinhTP.SelectedIndex = 0;
            cbb_Sort.SelectedIndex = 0;
        }

        public void ReShow()
        {
            dataGridView1.DataSource = BLL_QLSP.Instance.GetAllSP();

        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            form_Detail f2 = new form_Detail();
            f2.Show();
            f2.d += ReShow;
        }

        private void but_Edit_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0) MessageBox.Show("Bạn chưa chọn sản phẩm nào");
            else
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    string namesp = dataGridView1.SelectedRows[0].Cells["NameSP"].Value.ToString();
                    string tentinh = dataGridView1.SelectedRows[0].Cells["TenTinh"].Value.ToString();
                    string tenncc = dataGridView1.SelectedRows[0].Cells["TenNCC"].Value.ToString();
                    form_Detail f2 = new form_Detail(namesp, tentinh, tenncc);
                    f2.Show();
                    f2.d += ReShow;
                }
                else MessageBox.Show("Vui lòng chỉ chọn 1 đối tượng sinh viên ");
            }
            
        }

        private void cbb_TinhTP_TextChanged(object sender, EventArgs e)
        {
            cbb_NCC.Items.Clear();
            string query = ((CBB_TinhItems)cbb_TinhTP.SelectedItem).MaTinh;
            cbb_NCC.Items.AddRange(BLL_QLSP.Instance.getListNCC(query).ToArray());
            cbb_NCC.SelectedIndex = 0;
        }

        private void cbb_NCC_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string nhacungcap = ((CBB_NCCItems)cbb_NCC.SelectedItem).TenNCC.ToString();
            dataGridView1.DataSource = BLL_QLSP.Instance.GetSP(nhacungcap, "");
        }
        

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string query = txt_Search.Text.ToString();
            string nhacungcap = ((CBB_NCCItems)cbb_NCC.SelectedItem).TenNCC.ToString();
            dataGridView1.DataSource = BLL_QLSP.Instance.GetSP(nhacungcap, query);



        }

        //show all sp
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_QLSP.Instance.GetAllSP();
        }

        private void but_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) MessageBox.Show("Bạn chưa chọn đối tượng nào");
            else
            {
                DataGridViewSelectedRowCollection data = dataGridView1.SelectedRows;
                List<string> d_nsp = new List<string>();
                foreach (DataGridViewRow i in data)
                {
                    d_nsp.Add(i.Cells["NameSP"].Value.ToString());
                }
                BLL_QLSP.Instance.DeleteSP(d_nsp);

            }

            ReShow();
        }

        private void but_Sort_Click(object sender, EventArgs e)
        {
            int id = cbb_Sort.SelectedIndex;
            List<QLSPView> lst = BLL_QLSP.Instance.GetAllSP();
            switch (id)
            {
                case 0:
                    lst.Sort((s1, s2) => string.Compare(s1.NameSP, s2.NameSP, true));
                    break;
                case 1:
                    lst.Sort((s1, s2) => { return s1.Gianhap.CompareTo(s2.Gianhap); });
                    break;
                case 2:
                    lst.Sort((s1, s2) => { return s1.soluong.CompareTo(s2.soluong); });
                    break;
            }
            dataGridView1.DataSource = lst;
        }
    }
}
