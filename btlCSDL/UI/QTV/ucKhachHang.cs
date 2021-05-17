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
     public partial class ucKhachHang : DevExpress.DXperience.Demos.TutorialControlBase //DevExpress.XtraEditors.XtraUserControl
     {
          public ucKhachHang()
          {
               InitializeComponent();
          }

        private void ucKhachHang_Load(object sender, EventArgs e)
        {
            
            //DataSet ds = new DataSet();
            //DataTable db = ExecuteQuery("Show_VCTK_TTTC",Params).Copy();
            //ds.Tables.Add(db);
            dataGridViewKH.DataSource = null;
            dataGridViewKH.DataSource = ExecuteQuery("Show_KH_TTTC").Copy();
        }
        
    }
}
