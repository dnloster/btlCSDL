using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btlCSDL
{
     public partial class Login : Form
     {
          public Login()
          {
               InitializeComponent();
          }
          public string username = "";
          public string loaitk;

          private void checkBox2_CheckedChanged(object sender, EventArgs e)
          {
               if (checkBox2.Checked)
               {
                    txtPass.UseSystemPasswordChar = false;
               }
               else
               {
                    txtPass.UseSystemPasswordChar = true;
               }
          }
          private void btnLogin_Click(object sender, EventArgs e)
          {
               
          }
          private void linkLabel1_MouseMove(object sender, MouseEventArgs e)
          {
               linkLabel1.Font = new Font(linkLabel1.Font, FontStyle.Regular);
          }

          private void linkLabel1_MouseLeave(object sender, EventArgs e)
          {
               linkLabel1.Font = new Font(linkLabel1.Font, FontStyle.Italic);
          }

          private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
          {
               this.Hide();                                         //ẩn form1
               var Register = new Register();
               Register.Closed += (s, args) => this.Close();       //tạo event form2.closed để gọi this.close()
               Register.Show();
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

          private void Login_Load(object sender, EventArgs e)
          {
               this.Opacity = 0.1;
               timer1.Start();
          }

          private void label3_Click(object sender, EventArgs e)
          {
               this.Close();
          }
     }
}
