namespace btlCSDL.UI.QTV
{
     partial class ucKhachHang
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.dTNSKH = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.rGGTKH = new DevExpress.XtraEditors.RadioGroup();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx8 = new DevComponents.DotNetBar.PanelEx();
            this.txtSDTKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx7 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx6 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
            this.txtDiaChiKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.txtTenKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.txtHoKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txtMaKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridViewKH = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.ucKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dTNSKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rGGTKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucKhachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(981, 47);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 44;
            this.panelEx1.Text = "Thông Tin Khách Hàng";
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(891, 495);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 34);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.Symbol = "";
            this.btnXoa.SymbolColor = System.Drawing.Color.Red;
            this.btnXoa.TabIndex = 88;
            this.btnXoa.Text = "Xoá";
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Location = new System.Drawing.Point(799, 495);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 34);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.Symbol = "";
            this.btnSua.SymbolColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.TabIndex = 87;
            this.btnSua.Text = "Sửa";
            // 
            // dTNSKH
            // 
            // 
            // 
            // 
            this.dTNSKH.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dTNSKH.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dTNSKH.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dTNSKH.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dTNSKH.ButtonDropDown.Visible = true;
            this.dTNSKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTNSKH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dTNSKH.IsPopupCalendarOpen = false;
            this.dTNSKH.Location = new System.Drawing.Point(768, 353);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dTNSKH.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dTNSKH.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dTNSKH.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dTNSKH.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dTNSKH.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dTNSKH.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dTNSKH.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dTNSKH.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dTNSKH.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dTNSKH.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dTNSKH.MonthCalendar.DisplayMonth = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dTNSKH.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dTNSKH.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dTNSKH.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dTNSKH.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dTNSKH.MonthCalendar.TodayButtonVisible = true;
            this.dTNSKH.Name = "dTNSKH";
            this.dTNSKH.ShowUpDown = true;
            this.dTNSKH.Size = new System.Drawing.Size(174, 22);
            this.dTNSKH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dTNSKH.TabIndex = 85;
            this.dTNSKH.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            this.dTNSKH.WatermarkText = "18/07/2000";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(706, 353);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(57, 23);
            this.labelX2.TabIndex = 84;
            this.labelX2.Text = "Ngày Sinh";
            // 
            // rGGTKH
            // 
            this.rGGTKH.Location = new System.Drawing.Point(760, 279);
            this.rGGTKH.Name = "rGGTKH";
            this.rGGTKH.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rGGTKH.Properties.Appearance.Options.UseBackColor = true;
            this.rGGTKH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rGGTKH.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Nam", true, null, "Nam"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Nữ", true, null, "Nữ"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Khác", true, null, "Khác")});
            this.rGGTKH.Size = new System.Drawing.Size(183, 23);
            this.rGGTKH.TabIndex = 83;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(706, 279);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(48, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX1.TabIndex = 82;
            this.labelX1.Text = "Giới Tính";
            // 
            // panelEx8
            // 
            this.panelEx8.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelEx8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panelEx8.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx8.Location = new System.Drawing.Point(706, 462);
            this.panelEx8.Name = "panelEx8";
            this.panelEx8.Size = new System.Drawing.Size(237, 1);
            this.panelEx8.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx8.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx8.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx8.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx8.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx8.Style.GradientAngle = 90;
            this.panelEx8.TabIndex = 81;
            this.panelEx8.Text = "panelEx8";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // 
            // 
            this.txtSDTKH.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSDTKH.Border.Class = "TextBoxBorder";
            this.txtSDTKH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSDTKH.DisabledBackColor = System.Drawing.Color.White;
            this.txtSDTKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKH.Location = new System.Drawing.Point(706, 430);
            this.txtSDTKH.Multiline = true;
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.PreventEnterBeep = true;
            this.txtSDTKH.Size = new System.Drawing.Size(237, 26);
            this.txtSDTKH.TabIndex = 80;
            this.txtSDTKH.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKH.WatermarkText = "Số Điện Thoại";
            // 
            // panelEx7
            // 
            this.panelEx7.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelEx7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panelEx7.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx7.Location = new System.Drawing.Point(706, 381);
            this.panelEx7.Name = "panelEx7";
            this.panelEx7.Size = new System.Drawing.Size(237, 1);
            this.panelEx7.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx7.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx7.Style.GradientAngle = 90;
            this.panelEx7.TabIndex = 79;
            this.panelEx7.Text = "panelEx7";
            // 
            // panelEx6
            // 
            this.panelEx6.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panelEx6.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx6.Location = new System.Drawing.Point(706, 308);
            this.panelEx6.Name = "panelEx6";
            this.panelEx6.Size = new System.Drawing.Size(237, 1);
            this.panelEx6.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx6.Style.GradientAngle = 90;
            this.panelEx6.TabIndex = 78;
            this.panelEx6.Text = "panelEx6";
            // 
            // panelEx5
            // 
            this.panelEx5.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panelEx5.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx5.Location = new System.Drawing.Point(706, 234);
            this.panelEx5.Name = "panelEx5";
            this.panelEx5.Size = new System.Drawing.Size(237, 1);
            this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx5.Style.GradientAngle = 90;
            this.panelEx5.TabIndex = 77;
            this.panelEx5.Text = "panelEx5";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // 
            // 
            this.txtDiaChiKH.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDiaChiKH.Border.Class = "TextBoxBorder";
            this.txtDiaChiKH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChiKH.DisabledBackColor = System.Drawing.Color.White;
            this.txtDiaChiKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKH.Location = new System.Drawing.Point(706, 202);
            this.txtDiaChiKH.Multiline = true;
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.PreventEnterBeep = true;
            this.txtDiaChiKH.Size = new System.Drawing.Size(237, 26);
            this.txtDiaChiKH.TabIndex = 76;
            this.txtDiaChiKH.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKH.WatermarkText = "Địa Chỉ";
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panelEx4.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx4.Location = new System.Drawing.Point(784, 167);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(159, 1);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 75;
            this.panelEx4.Text = "panelEx4";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // 
            // 
            this.txtTenKH.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtTenKH.Border.Class = "TextBoxBorder";
            this.txtTenKH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenKH.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(784, 135);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PreventEnterBeep = true;
            this.txtTenKH.Size = new System.Drawing.Size(159, 26);
            this.txtTenKH.TabIndex = 74;
            this.txtTenKH.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.WatermarkText = "Tên";
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Location = new System.Drawing.Point(706, 167);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(72, 1);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 73;
            this.panelEx3.Text = "panelEx3";
            // 
            // txtHoKH
            // 
            this.txtHoKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // 
            // 
            this.txtHoKH.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtHoKH.Border.Class = "TextBoxBorder";
            this.txtHoKH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHoKH.DisabledBackColor = System.Drawing.Color.White;
            this.txtHoKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoKH.Location = new System.Drawing.Point(706, 135);
            this.txtHoKH.Multiline = true;
            this.txtHoKH.Name = "txtHoKH";
            this.txtHoKH.PreventEnterBeep = true;
            this.txtHoKH.Size = new System.Drawing.Size(72, 26);
            this.txtHoKH.TabIndex = 72;
            this.txtHoKH.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoKH.WatermarkText = "Họ";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(706, 100);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(237, 1);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 71;
            this.panelEx2.Text = "panelEx2";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // 
            // 
            this.txtMaKH.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtMaKH.Border.Class = "TextBoxBorder";
            this.txtMaKH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaKH.DisabledBackColor = System.Drawing.Color.White;
            this.txtMaKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(706, 68);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PreventEnterBeep = true;
            this.txtMaKH.Size = new System.Drawing.Size(237, 26);
            this.txtMaKH.TabIndex = 70;
            this.txtMaKH.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.WatermarkText = "Mã Khách Hàng";
            // 
            // dataGridViewKH
            // 
            this.dataGridViewKH.AllowUserToAddRows = false;
            this.dataGridViewKH.AllowUserToDeleteRows = false;
            this.dataGridViewKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.HoKH,
            this.TenKH,
            this.DiaChiKH,
            this.GTKH,
            this.NSKH,
            this.SDTKH,
            this.Col8});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKH.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewKH.Location = new System.Drawing.Point(0, 46);
            this.dataGridViewKH.Name = "dataGridViewKH";
            this.dataGridViewKH.ReadOnly = true;
            this.dataGridViewKH.Size = new System.Drawing.Size(676, 688);
            this.dataGridViewKH.TabIndex = 113;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(703, 495);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 34);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.Symbol = "";
            this.btnThem.SymbolColor = System.Drawing.Color.LimeGreen;
            this.btnThem.TabIndex = 138;
            this.btnThem.Text = "Thêm";
            // 
            // ucKhachHangBindingSource
            // 
            this.ucKhachHangBindingSource.DataSource = typeof(btlCSDL.UI.QTV.ucKhachHang);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MAKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // HoKH
            // 
            this.HoKH.DataPropertyName = "HOKH";
            this.HoKH.HeaderText = "Họ";
            this.HoKH.Name = "HoKH";
            this.HoKH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TENKH";
            this.TenKH.HeaderText = "Tên";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // DiaChiKH
            // 
            this.DiaChiKH.DataPropertyName = "DIACHIKH";
            this.DiaChiKH.HeaderText = "Địa chỉ";
            this.DiaChiKH.Name = "DiaChiKH";
            this.DiaChiKH.ReadOnly = true;
            // 
            // GTKH
            // 
            this.GTKH.DataPropertyName = "GTKH";
            this.GTKH.HeaderText = "Giới tính";
            this.GTKH.Name = "GTKH";
            this.GTKH.ReadOnly = true;
            // 
            // NSKH
            // 
            this.NSKH.DataPropertyName = "NSKH";
            this.NSKH.HeaderText = "Ngày sinh";
            this.NSKH.Name = "NSKH";
            this.NSKH.ReadOnly = true;
            // 
            // SDTKH
            // 
            this.SDTKH.DataPropertyName = "SDTKH";
            this.SDTKH.HeaderText = "Số điện thoại";
            this.SDTKH.Name = "SDTKH";
            this.SDTKH.ReadOnly = true;
            // 
            // Col8
            // 
            this.Col8.DataPropertyName = "NGUOIBT";
            this.Col8.HeaderText = "Người bảo trợ";
            this.Col8.Name = "Col8";
            this.Col8.ReadOnly = true;
            // 
            // ucKhachHang
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewKH);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dTNSKH);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.rGGTKH);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.panelEx8);
            this.Controls.Add(this.txtSDTKH);
            this.Controls.Add(this.panelEx7);
            this.Controls.Add(this.panelEx6);
            this.Controls.Add(this.panelEx5);
            this.Controls.Add(this.txtDiaChiKH);
            this.Controls.Add(this.panelEx4);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.txtHoKH);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.panelEx1);
            this.Name = "ucKhachHang";
            this.Size = new System.Drawing.Size(981, 734);
            this.Load += new System.EventHandler(this.ucKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dTNSKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rGGTKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucKhachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

          }

          #endregion
          private System.Windows.Forms.BindingSource ucKhachHangBindingSource;
          private DevComponents.DotNetBar.PanelEx panelEx1;
          private DevComponents.DotNetBar.ButtonX btnXoa;
          private DevComponents.DotNetBar.ButtonX btnSua;
          private DevComponents.Editors.DateTimeAdv.DateTimeInput dTNSKH;
          private DevComponents.DotNetBar.LabelX labelX2;
          private DevExpress.XtraEditors.RadioGroup rGGTKH;
          private DevComponents.DotNetBar.LabelX labelX1;
          private DevComponents.DotNetBar.PanelEx panelEx8;
          private DevComponents.DotNetBar.Controls.TextBoxX txtSDTKH;
          private DevComponents.DotNetBar.PanelEx panelEx7;
          private DevComponents.DotNetBar.PanelEx panelEx6;
          private DevComponents.DotNetBar.PanelEx panelEx5;
          private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChiKH;
          private DevComponents.DotNetBar.PanelEx panelEx4;
          private DevComponents.DotNetBar.Controls.TextBoxX txtTenKH;
          private DevComponents.DotNetBar.PanelEx panelEx3;
          private DevComponents.DotNetBar.Controls.TextBoxX txtHoKH;
          private DevComponents.DotNetBar.PanelEx panelEx2;
          private DevComponents.DotNetBar.Controls.TextBoxX txtMaKH;
          private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewKH;
          private DevComponents.DotNetBar.ButtonX btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col8;
    }
}
