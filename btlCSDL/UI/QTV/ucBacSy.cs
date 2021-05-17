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
using static btlCSDL.DataConnection;

namespace btlCSDL.UI.QTV
{
     public partial class ucBacSy : DevExpress.DXperience.Demos.TutorialControlBase //DevExpress.XtraEditors.XtraUserControl
     {
          public ucBacSy()
          {
               InitializeComponent();
          }

          private void ucBacSy_Load(object sender, EventArgs e)
          {
            dataGridViewBS.DataSource = null;
            dataGridViewBS.DataSource = ExecuteQuery("Show_WorkingBS_TTTC").Copy();
          }

          string mabs;
          private void dataGridViewBS_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               int index = e.RowIndex;
               if(index >= 0)
               {
                    try
                    {
                         mabs = dataGridViewBS.Rows[index].Cells["MaBS"].Value.ToString();
                         txtMaBS.Text = dataGridViewBS.Rows[index].Cells["MaBS"].Value.ToString();
                         txtHoBS.Text = dataGridViewBS.Rows[index].Cells["HoBS"].Value.ToString();
                         txtTenBS.Text = dataGridViewBS.Rows[index].Cells["TenBS"].Value.ToString();
                         txtDiaChiBS.Text = dataGridViewBS.Rows[index].Cells["DiaChiBS"].Value.ToString();
                         rGGTBS.Text = dataGridViewBS.Rows[index].Cells["GTBS"].Value.ToString();
                         dTNSBS.Text = dataGridViewBS.Rows[index].Cells["NSBS"].Value.ToString();
                         txtSDTBS.Text = dataGridViewBS.Rows[index].Cells["SDTBS"].Value.ToString();
                    }
                    catch(Exception ex)
                    {
                         txtMaBS.Clear();
                         txtHoBS.Clear();
                         txtTenBS.Clear();
                         txtDiaChiBS.Clear();
                         txtSDTBS.Clear();
                         rGGTBS.Reset();
                    }
               }
          }
     }
}
