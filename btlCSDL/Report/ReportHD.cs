using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btlCSDL.Report
{
     public partial class ReportHD : Form
     {
          public ReportHD()
          {
               InitializeComponent();
          }

          private void ReportHD_Load(object sender, EventArgs e)
          {
               // TODO: This line of code loads data into the 'qltcDataSet.HOADON' table. You can move, or remove it, as needed.
               this.hOADONTableAdapter.Fill(this.qltcDataSet.HOADON);

               this.reportViewer1.RefreshReport();
          }
     }
}
