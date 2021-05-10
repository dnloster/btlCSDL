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

     }
}
