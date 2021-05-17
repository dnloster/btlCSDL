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


        private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow row = dataGridViewHD.Rows[i];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                txtMaPT.Text = row.Cells[3].Value.ToString();
                txtTongTien.Text = row.Cells[1].Value.ToString();
                dTNgayTT.Value = Convert.ToDateTime(row.Cells[2].Value.ToString()); 
            }
            if (txtMaHD.Text != null)
            {
                txtMaHD.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {

                string mahd = dataGridViewHD.SelectedCells[0].OwningRow.Cells["MaHD"].Value.ToString();
                HOADON dt = db.HOADONs.Find(mahd);
                if (txtMaHD.Text == dt.MAHD)
                {
                    dt.MAPT = txtMaPT.Text;
                    dt.TONGTIEN = decimal.Parse(txtTongTien.Text);
                    dt.NGAYTT = dTNgayTT.Value;
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sai dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Sai Mã Sinh Viên Hoặc Thiếu Thông Tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            FormThêmHD fm = new FormThêmHD();
            fm.Show();
        }
          public static string mahd;
          private void btnXuatHD_Click(object sender, EventArgs e)
          {
               
          }
     }
}
