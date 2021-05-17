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
using System.Data.SqlClient;
using btlCSDL.DTO;
using btlCSDL.BUS;
using btlCSDL.Report;

namespace btlCSDL.UI.QTV.NghiepVu
{
     public partial class PhieuKTSK : DevExpress.DXperience.Demos.TutorialControlBase    //DevExpress.XtraEditors.XtraUserControl
     {
          BUS_PHIEUKTSK bus;
          public PhieuKTSK()
          {
               InitializeComponent();
               bus = new BUS_PHIEUKTSK();
          }
          DataConnection dc;
          SqlDataAdapter da;
          DataSet ds;
          public void ShowAllPhieuKTSK()
          {
               DataTable dt = bus.getAllPhieuKTSK();
               dataGridViewKTSK.DataSource = dt;
          }
          private void PhieuKTSK_Load(object sender, EventArgs e)
          {
               dc = new DataConnection();
               SqlConnection con = dc.getConnect();
               con.Open();
               da = new SqlDataAdapter("select * from PHIEUKTSK", con);
               ds = new DataSet();
               da.Fill(ds, "PHIEUKTSK");
               dataGridViewKTSK.DataSource = ds;
               dataGridViewKTSK.DataMember = "PHIEUKTSK";
               con.Close();
               
          }
          string maphieuktsk;
          private void dataGridViewKTSK_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               int i = e.RowIndex;
               if (i >= 0)
               {
                    try
                    {
                         //DataGridViewRow row = dataGridViewKTSK.Rows[i];
                         
                         txtMaPhieuKTSK.Text = dataGridViewKTSK.Rows[i].Cells["Column1"].Value.ToString();
                         txtMaKH.Text = dataGridViewKTSK.Rows[i].Cells["MAKH"].Value.ToString();
                         txtMaBS.Text = dataGridViewKTSK.Rows[i].Cells["MABS"].Value.ToString();
                         txtNoiDung.Text = dataGridViewKTSK.Rows[i].Cells["NOIDUNG"].Value.ToString();
                         dTNgayKT.Text = dataGridViewKTSK.Rows[i].Cells["NGAYKT"].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                         txtMaPhieuKTSK.Clear();
                         txtMaKH.Clear();
                         txtMaBS.Clear();
                         txtNoiDung.Clear();
                         dTNgayKT.Value = DateTime.Today;
                    }
                    
               }
          }

          private void btnThem_Click(object sender, EventArgs e)
          {
               DTO_PHIEUKTSK ktsk = new DTO_PHIEUKTSK();
               ktsk.MAPHIEUKTSK = txtMaPhieuKTSK.Text;
               ktsk.MAKH = txtMaKH.Text;
               ktsk.MABS = txtMaBS.Text;
               ktsk.NGAYKT = DateTime.Parse(dTNgayKT.Text);
               ktsk.NOIDUNG = txtNoiDung.Text;
               if (bus.Add_PHIEUKTSK(ktsk))
               {
                    ShowAllPhieuKTSK();
                    int nRowIndex = dataGridViewKTSK.Rows.Count - 2;
                    dataGridViewKTSK.CurrentCell = dataGridViewKTSK.Rows[nRowIndex].Cells[0];
                    MessageBox.Show("Thêm thành công");
               }
               else { MessageBox.Show("Error"); }
          }

          private void btnSua_Click(object sender, EventArgs e)
          {
               DTO_PHIEUKTSK ktsk = new DTO_PHIEUKTSK();
               ktsk.MAPHIEUKTSK = maphieuktsk;
               ktsk.MAKH = txtMaKH.Text;
               ktsk.MABS = txtMaBS.Text;
               ktsk.NGAYKT = DateTime.Parse(dTNgayKT.Text);
               ktsk.NOIDUNG = txtNoiDung.Text;
               if(bus.Update_PHIEUKTSK(ktsk))
               {
                    ShowAllPhieuKTSK();
                    MessageBox.Show("Sửa thành công");
               }
               else { MessageBox.Show("Error"); }
          }

          private void btnXuatPhieuKTSK_Click(object sender, EventArgs e)
          {
               
          }
     }
}
