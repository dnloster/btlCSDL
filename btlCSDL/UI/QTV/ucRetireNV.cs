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
     public partial class ucRetireNV : DevExpress.DXperience.Demos.TutorialControlBase
     {
          public ucRetireNV()
          {
               InitializeComponent();
          }

          private void ucRetireNV_Load(object sender, EventArgs e)
          {
               dataGridViewRetireNV.DataSource = null;
               dataGridViewRetireNV.DataSource = ExecuteQuery("Show_RetireNV_TTTC").Copy();
          }
     }
}
