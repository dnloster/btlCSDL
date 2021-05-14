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
using System.Data.SqlClient;

namespace btlCSDL.UI.Khach
{
     public partial class ucXemHD : DevExpress.DXperience.Demos.TutorialControlBase //DevExpress.XtraEditors.XtraUserControl
     {
          public ucXemHD()
          {
               InitializeComponent();
          }

          private void ucXemHD_Load(object sender, EventArgs e)
          {
            string kh = "KH001";
            SqlParameter[] Params = new SqlParameter[]
                   {
                new SqlParameter("MAKH", kh)
                   };
            dataGridViewX1.DataSource = null;
            dataGridViewX1.DataSource = ExecuteQuery("XemHoaDon",Params).Copy();
        }
     }
}
