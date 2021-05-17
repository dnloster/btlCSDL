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
     public partial class ucNhanVien : DevExpress.DXperience.Demos.TutorialControlBase //DevExpress.XtraEditors.XtraUserControl
     {
          public ucNhanVien()
          {
               InitializeComponent();
          }

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            dataGridViewNV.DataSource = null;
            dataGridViewNV.DataSource = ExecuteQuery("Show_WorkingNV_TTTC").Copy();
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
