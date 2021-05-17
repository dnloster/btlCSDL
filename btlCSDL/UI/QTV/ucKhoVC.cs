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

namespace btlCSDL.UI.QTV
{
     public partial class ucKhoVC : DevExpress.DXperience.Demos.TutorialControlBase //DevExpress.XtraEditors.XtraUserControl
     {
          public ucKhoVC()
          {
               InitializeComponent();
          }
          private static ucKhoVC _instance;
          public static ucKhoVC Instance
          {
               get
               {
                    if (_instance == null)
                         _instance = new ucKhoVC();
                    return _instance;

               }
          }

        private void ucKhoVC_Load(object sender, EventArgs e)
        {
            string kho = "K01";
            SqlParameter[] Params = new SqlParameter[]
                   {
                new SqlParameter("MAKHO", kho)
                   };
            //DataSet ds = new DataSet();
            //DataTable db = ExecuteQuery("Show_VCTK_TTTC",Params).Copy();
            //ds.Tables.Add(db);
            dataGridViewX1.DataSource = null;
            dataGridViewX1.DataSource = ExecuteQuery("XemCTKho", Params).Copy();
        }
    }
}
