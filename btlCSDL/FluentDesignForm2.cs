using btlCSDL.UI.QTV;
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
namespace btlCSDL
{
     public partial class FluentDesignForm2 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
     {
          public FluentDesignForm2()
          {
               InitializeComponent();
               this.OptionsAdaptiveLayout.AdaptiveLayout = false;
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

          private async void accordionControlElement1_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{accordionControlElement1.Text}";
               if (ModulesInfo.GetItem("ucTrangChu2") == null)
                    ModulesInfo.Add(new ModuleInfo("ucTrangChu2", "btlCSDL.ucTrangChu2"));
               await LoadModuleAsync(ModulesInfo.GetItem("ucTrangChu2"));
          }

          private async void AccordionControlElement6_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{accordionControlElement6.Text}";
               if (ModulesInfo.GetItem("ucKhoVC") == null)
                    ModulesInfo.Add(new ModuleInfo("ucKhoVC", "btlCSDL.UI.QTV.ucKhoVC"));
               await LoadModuleAsync(ModulesInfo.GetItem("ucKhoVC"));
          }

          private void FluentDesignForm2_Load(object sender, EventArgs e)
          {
               this.fluentDesignFormContainer1.Controls.Add(new ucTrangChu2() { Dock = DockStyle.Fill });
               this.itemNav.Caption = $"{accordionControlElement1.Text}";
          }

          private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
          {
               this.Hide();                                         //ẩn form1
               var form1 = new FluentDesignForm1();
               form1.Closed += (s, args) => this.Close();       //tạo event form2.closed để gọi this.close()
               form1.Show();
          }

          private async void accordionControlElement13_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{accordionControlElement13.Text}";
               if (ModulesInfo.GetItem("ucVaccine") == null)
                    ModulesInfo.Add(new ModuleInfo("ucVaccine", "btlCSDL.UI.QTV.ucVaccine"));
               await LoadModuleAsync(ModulesInfo.GetItem("ucVaccine"));

          }

          private async void aCKTSK_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{aCKTSK.Text}";
               if (ModulesInfo.GetItem("PhieuKTSK") == null)
                    ModulesInfo.Add(new ModuleInfo("PhieuKTSK", "btlCSDL.UI.QTV.NghiepVu.PhieuKTSK"));
               await LoadModuleAsync(ModulesInfo.GetItem("PhieuKTSK"));
          }

          private async void aCPT_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{aCPT.Text}";
               if (ModulesInfo.GetItem("PhieuTiem") == null)
                    ModulesInfo.Add(new ModuleInfo("PhieuTiem", "btlCSDL.UI.QTV.NghiepVu.PhieuTiem"));
               await LoadModuleAsync(ModulesInfo.GetItem("PhieuTiem"));
          }

          private async void aCHD_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{aCHD.Text}";
               if (ModulesInfo.GetItem("HoaDon") == null)
                    ModulesInfo.Add(new ModuleInfo("HoaDon", "btlCSDL.UI.QTV.NghiepVu.HoaDon"));
               await LoadModuleAsync(ModulesInfo.GetItem("HoaDon"));
          }

          private async void aCPN_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{aCPN.Text}";
               if (ModulesInfo.GetItem("PhieuNhap") == null)
                    ModulesInfo.Add(new ModuleInfo("PhieuNhap", "btlCSDL.UI.QTV.NghiepVu.PhieuNhap"));
               await LoadModuleAsync(ModulesInfo.GetItem("PhieuNhap"));
          }

          private async void accordionControlElement3_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{accordionControlElement8.Text}";
               if (ModulesInfo.GetItem("ucBacSy") == null)
                    ModulesInfo.Add(new ModuleInfo("ucBacSy", "btlCSDL.UI.QTV.ucBacSy"));
               await LoadModuleAsync(ModulesInfo.GetItem("ucBacSy"));
          }

          private async void accordionControlElement4_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{accordionControlElement8.Text}";
               if (ModulesInfo.GetItem("ucRetireBacSy") == null)
                    ModulesInfo.Add(new ModuleInfo("ucRetireBacSy", "btlCSDL.UI.QTV.ucRetireBacSy"));
               await LoadModuleAsync(ModulesInfo.GetItem("ucRetireBacSy"));
          }

          private async void accordionControlElement9_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{accordionControlElement9.Text}";
               if (ModulesInfo.GetItem("ucKhachHang") == null)
                    ModulesInfo.Add(new ModuleInfo("ucKhachHang", "btlCSDL.UI.QTV.ucKhachHang"));
               await LoadModuleAsync(ModulesInfo.GetItem("ucKhachHang"));
          }

          private async void accordionControlElement5_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{accordionControlElement10.Text}";
               if (ModulesInfo.GetItem("ucNhanVien") == null)
                    ModulesInfo.Add(new ModuleInfo("ucNhanVien", "btlCSDL.UI.QTV.ucNhanVien"));
               await LoadModuleAsync(ModulesInfo.GetItem("ucNhanVien"));
          }

          private async void accordionControlElement11_Click(object sender, EventArgs e)
          {
               this.itemNav.Caption = $"{accordionControlElement10.Text}";
               if (ModulesInfo.GetItem("ucRetireNV") == null)
                    ModulesInfo.Add(new ModuleInfo("ucRetireNV", "btlCSDL.UI.QTV.ucRetireNV"));
               await LoadModuleAsync(ModulesInfo.GetItem("ucRetireNV"));
          }
     }
}
