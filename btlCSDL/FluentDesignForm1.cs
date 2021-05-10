using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btlCSDL.UI.Khach;


namespace btlCSDL
{
     public partial class FluentDesignForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
     {
          public FluentDesignForm1()
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

          async Task LoadModuleAsync(ModuleInfo module)
          {
               await Task.Factory.StartNew(() =>
               {
                    if (!fluentDesignFormContainer1.Controls.ContainsKey(module.Name))
                    {
                         TutorialControlBase control = module.TModule as TutorialControlBase;
                         if (control != null)
                         {
                              control.Dock = DockStyle.Fill;
                              control.CreateWaitDialog();
                              fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                              {
                                   fluentDesignFormContainer1.Controls.Add(control);
                                   control.BringToFront();
                              }));
                         }
                    }
                    else
                    {
                         var control = fluentDesignFormContainer1.Controls.Find(module.Name, true);
                         if (control.Length == 1)
                              fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                              {
                                   control[0].BringToFront();
                              }));
                    }
               });
          }

          private async void aCDKTiem_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{aCXemHD.Text}";
               if (ModulesInfo.GetItem("XemHD") == null)
                    ModulesInfo.Add(new ModuleInfo("XemHD", "btlCSDL.UI.Khach.XemHD"));
               await LoadModuleAsync(ModulesInfo.GetItem("XemHD"));
          }
          private async void aCTrangchu_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{aCTrangchu.Text}";
               if (ModulesInfo.GetItem("ucTrangChu1") == null)
                    ModulesInfo.Add(new ModuleInfo("ucTrangChu1", "btlCSDL.ucTrangChu1"));
               await LoadModuleAsync(ModulesInfo.GetItem("ucTrangChu1"));
          }
          private async void aCBangGia_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{aCBangGia.Text}";
               if (ModulesInfo.GetItem("ucBangGia") == null)
                    ModulesInfo.Add(new ModuleInfo("ucBangGia", "btlCSDL.UI.Khach.ucBangGia"));
               await LoadModuleAsync(ModulesInfo.GetItem("ucBangGia"));
          }

          private void FluentDesignForm1_Load(object sender, EventArgs e)
          {
               this.fluentDesignFormContainer1.Controls.Add(new ucTrangChu1() { Dock = DockStyle.Fill });
               this.itemNav.Caption = $"{aCTrangchu.Text}";
          }
     }
}
