﻿namespace btlCSDL.UI.Khach
{
     partial class ucXemHD
     {
          /// <summary> 
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary> 
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
               this.SuspendLayout();
               // 
               // panelEx1
               // 
               this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
               this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
               this.panelEx1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.panelEx1.Location = new System.Drawing.Point(0, 0);
               this.panelEx1.Name = "panelEx1";
               this.panelEx1.Size = new System.Drawing.Size(981, 37);
               this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
               this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
               this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
               this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
               this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
               this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
               this.panelEx1.Style.GradientAngle = 90;
               this.panelEx1.TabIndex = 104;
               this.panelEx1.Text = "Hoá Đơn Thanh Toán";
               // 
               // ucXemHD
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.panelEx1);
               this.Name = "ucXemHD";
               this.Size = new System.Drawing.Size(981, 734);
               this.Load += new System.EventHandler(this.ucXemHD_Load);
               this.ResumeLayout(false);

          }

          #endregion
          private DevComponents.DotNetBar.PanelEx panelEx1;
     }
}
