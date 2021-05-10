using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace btlCSDL
{
     public partial class FormLoading : DevExpress.XtraEditors.XtraForm
     {
          public FormLoading()
          {
               InitializeComponent();
          }
          int x = 0;
          private void timer1_Tick(object sender, EventArgs e)
          {
               x++;
               if(x <= 3.5)
               {
                    timer1.Stop();
                    this.Hide();
                    var FluentDesignForm1 = new FluentDesignForm1();
                    FluentDesignForm1.Closed += (s, args) => this.Close();
                    FluentDesignForm1.Show();
               }

          }

          private void FormLoading_Load(object sender, EventArgs e)
          {

          }
     }
}