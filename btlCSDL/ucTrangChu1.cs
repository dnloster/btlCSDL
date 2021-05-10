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

namespace btlCSDL
{
     public partial class ucTrangChu1 : DevExpress.XtraEditors.XtraUserControl
     {
          public ucTrangChu1()
          {
               InitializeComponent();
          }
          private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
          {
               var Login = new Login();
               Login.Show();
          }
          private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
          {
               var Register = new Register();
               Register.Show();
          }
     }
}
