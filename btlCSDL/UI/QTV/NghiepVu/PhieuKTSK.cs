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

namespace btlCSDL.UI.QTV.NghiepVu
{
     public partial class PhieuKTSK : DevExpress.DXperience.Demos.TutorialControlBase    //DevExpress.XtraEditors.XtraUserControl
     {
          public PhieuKTSK()
          {
               InitializeComponent();
          }
          DataConnection dc;
          SqlDataAdapter da;
          DataSet ds;
          private void PhieuKTSK_Load(object sender, EventArgs e)
          {
               //dc = new DataConnection();
               //SqlConnection con = dc.getConnect();
               //con.Open();
               //da = new SqlDataAdapter("select * from PHIEUKTSK", con);
               //ds = new DataSet();
               //da.Fill(ds, "PHIEUKTSK");
               //dataGridViewKTSK.DataSource = ds;
               //dataGridViewKTSK.DataMember = "PHIEUKTSK";
               //con.Close();
          }

          private void dataGridViewKTSK_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               //int i = e.RowIndex;
               //if (i >= 0)
               //{
               //     DataGridViewRow row = dataGridViewKTSK.Rows[i];
               //     txtMaPhieuKTSK.Text = row.Cells["MaPhieuKTSK"].Value.ToString();
               //     txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
               //     txtMaBS.Text = row.Cells["MaBS"].Value.ToString();
               //     txtNoiDung.Text = row.Cells["NoiDung"].Value.ToString();
               //     dTNgayKT.Value = Convert.ToDateTime(row.Cells["NgayKT"].Value.ToString());

               //}
          }
     }
}
