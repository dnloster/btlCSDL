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

        //private void btnXem_Click(object sender, EventArgs e)
        
        


        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemHoaDon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaHoaDon();
        }
    }
}
