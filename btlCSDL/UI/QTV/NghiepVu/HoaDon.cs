using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace btlCSDL.UI.QTV.NghiepVu
{
     public partial class HoaDon : DevExpress.DXperience.Demos.TutorialControlBase   
     {

        HoaDonEntities db = new HoaDonEntities();
        public HoaDon()
          {
               InitializeComponent();
               LoadData();
          }
        void LoadData()
        {
            dataGridViewHD.DataSource = db.HOADONs.ToList();
        }

        void ThemHoaDon()
        {
            db.HOADONs.Add(new HOADON() { });
            db.SaveChanges();
        }
        void SuaHoaDon()
        {

        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemHoaDon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaHoaDon();
        }

        private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow row = dataGridViewHD.Rows[i];
                txtMaHD.Text = row.Cells["MaHD"].Value.ToString();
                txtMaPT.Text = row.Cells["MaPT"].Value.ToString();
                txtTongTien.Text = row.Cells["TongTien"].Value.ToString();
                dTNgayTT.Value = Convert.ToDateTime(row.Cells["NgayTT"].Value.ToString());
                
            }
        }
    }
}
