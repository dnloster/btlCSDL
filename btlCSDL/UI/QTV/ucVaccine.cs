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

namespace btlCSDL.UI.QTV
{
     public partial class ucVaccine : DevExpress.DXperience.Demos.TutorialControlBase //DevExpress.XtraEditors.XtraUserControl
     {
          public ucVaccine()
          {
               InitializeComponent();
          }
          private static ucVaccine _instance;
          public static ucVaccine Instance
          {
               get
               {
                    if (_instance == null)
                         _instance = new ucVaccine();
                    return _instance;
               }
          }
     }
}
