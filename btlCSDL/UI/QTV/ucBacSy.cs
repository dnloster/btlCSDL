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
            dataGridViewBS.DataSource = ExecuteQuery("Show_BSALL_TTTC").Copy();
        }
          //public string MaBS { get; set; }
          //public string HoBS { get; set; }
          //public string TenBS { get; set; }
          //public string DiachiBS { get; set; }
          //public string GTBS { get; set; }
          //public DateTime NSBS { get; set; }
          //public char SDTBS { get; set; }
     }
}
