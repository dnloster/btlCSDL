using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btlCSDL
{
     public partial class Register : Form
     {
          public Register()
          {
               InitializeComponent();
          }

          public string loaiTK;
          private void Register_Load(object sender, EventArgs e)
          {
               this.Opacity = 0.1;
               timer1.Start();
               //if (loaiTK = 'admin')
               //{

               //}
          }

          private void timer1_Tick(object sender, EventArgs e)
          {
               if (this.Opacity <= 1.0)
               {
                    this.Opacity += 0.25;
               }
               else
               {
                    timer1.Stop();
               }
          }

          private void btnReturn_Click(object sender, EventArgs e)
          {
               this.Hide();
               var Login = new Login();
               Login.Closed += (s, args) => this.Close();
               Login.Show();
          }

          private void label4_Click(object sender, EventArgs e)
          {
               this.Close();
          }

     }
}
