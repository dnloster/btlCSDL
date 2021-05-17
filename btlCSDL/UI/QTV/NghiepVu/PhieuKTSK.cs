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
using static btlCSDL.DataConnection;

namespace btlCSDL.UI.QTV.NghiepVu
{
     public partial class PhieuKTSK : DevExpress.DXperience.Demos.TutorialControlBase    //DevExpress.XtraEditors.XtraUserControl
     {
          public PhieuKTSK()
          {
               InitializeComponent();
          }
          private void PhieuKTSK_Load(object sender, EventArgs e)
          {
               dataGridViewKTSK.DataSource = null;
               dataGridViewKTSK.DataSource = ExecuteQuery("Show_PHIEUKTSK_TTTC").Copy();
          }
          string maphieu;
          private void dataGridViewKTSK_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               int i = e.RowIndex;
               if (i >= 0)
               {
                    try
                    {
                         maphieu = dataGridViewKTSK.Rows[i].Cells["Column1"].Value.ToString();
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
                    }

               }
          }
     }
}
