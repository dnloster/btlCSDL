namespace btlCSDL.UI.QTV.NghiepVu
{
     partial class PhieuNhap
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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               this.btnSua = new DevComponents.DotNetBar.ButtonX();
               this.btnThem = new DevComponents.DotNetBar.ButtonX();
               this.dataGridViewBS = new DevComponents.DotNetBar.Controls.DataGridViewX();
               this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
               this.dTNgayNhap = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
               this.labelX2 = new DevComponents.DotNetBar.LabelX();
               this.panelEx8 = new DevComponents.DotNetBar.PanelEx();
               this.txtSoLuong = new DevComponents.DotNetBar.Controls.TextBoxX();
               this.panelEx7 = new DevComponents.DotNetBar.PanelEx();
               this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
               this.txtMaVC = new DevComponents.DotNetBar.Controls.TextBoxX();
               this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
               this.txtMaPN = new DevComponents.DotNetBar.Controls.TextBoxX();
               this.btnXuatPN = new DevComponents.DotNetBar.ButtonX();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBS)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dTNgayNhap)).BeginInit();
               this.SuspendLayout();
               // 
               // btnSua
               // 
               this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
               this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
               this.btnSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSua.Location = new System.Drawing.Point(844, 427);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(117, 44);
               this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.btnSua.Symbol = "";
               this.btnSua.SymbolColor = System.Drawing.Color.MediumBlue;
               this.btnSua.TabIndex = 127;
               this.btnSua.Text = "Sửa";
               // 
               // btnThem
               // 
               this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
               this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
               this.btnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnThem.Location = new System.Drawing.Point(665, 427);
               this.btnThem.Name = "btnThem";
               this.btnThem.Size = new System.Drawing.Size(117, 44);
               this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.btnThem.Symbol = "";
               this.btnThem.SymbolColor = System.Drawing.Color.Lime;
               this.btnThem.TabIndex = 126;
               this.btnThem.Text = "Thêm";
               // 
               // dataGridViewBS
               // 
               this.dataGridViewBS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridViewBS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
               this.dataGridViewBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridViewBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPN,
            this.MaVC,
            this.SoLuong,
            this.NgayNhap});
               this.dataGridViewBS.Cursor = System.Windows.Forms.Cursors.Default;
               dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
               dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
               dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
               dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
               dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.dataGridViewBS.DefaultCellStyle = dataGridViewCellStyle1;
               this.dataGridViewBS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
               this.dataGridViewBS.Location = new System.Drawing.Point(0, 45);
               this.dataGridViewBS.Name = "dataGridViewBS";
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
               dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
               dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dataGridViewBS.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
               this.dataGridViewBS.Size = new System.Drawing.Size(647, 689);
               this.dataGridViewBS.TabIndex = 125;
               // 
               // STT
               // 
               this.STT.DataPropertyName = "STT";
               this.STT.HeaderText = "STT";
               this.STT.Name = "STT";
               // 
               // MaPN
               // 
               this.MaPN.DataPropertyName = "MaPN";
               this.MaPN.HeaderText = "Mã phiếu";
               this.MaPN.Name = "MaPN";
               // 
               // MaVC
               // 
               this.MaVC.DataPropertyName = "MaVC";
               this.MaVC.HeaderText = "Mã vaccine";
               this.MaVC.Name = "MaVC";
               // 
               // SoLuong
               // 
               this.SoLuong.DataPropertyName = "SoLuong";
               this.SoLuong.HeaderText = "Số lượng";
               this.SoLuong.Name = "SoLuong";
               // 
               // NgayNhap
               // 
               this.NgayNhap.DataPropertyName = "NgayNhap";
               this.NgayNhap.HeaderText = "Ngày nhập";
               this.NgayNhap.Name = "NgayNhap";
               // 
               // panelEx1
               // 
               this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
               this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
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
               this.panelEx1.TabIndex = 124;
               this.panelEx1.Text = "Phiếu Nhập";
               // 
               // dTNgayNhap
               // 
               // 
               // 
               // 
               this.dTNgayNhap.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
               this.dTNgayNhap.BackgroundStyle.Class = "DateTimeInputBackground";
               this.dTNgayNhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.dTNgayNhap.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
               this.dTNgayNhap.ButtonDropDown.Visible = true;
               this.dTNgayNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.dTNgayNhap.ForeColor = System.Drawing.SystemColors.WindowText;
               this.dTNgayNhap.IsPopupCalendarOpen = false;
               this.dTNgayNhap.Location = new System.Drawing.Point(751, 339);
               // 
               // 
               // 
               // 
               // 
               // 
               this.dTNgayNhap.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.dTNgayNhap.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
               this.dTNgayNhap.MonthCalendar.ClearButtonVisible = true;
               // 
               // 
               // 
               this.dTNgayNhap.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
               this.dTNgayNhap.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
               this.dTNgayNhap.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
               this.dTNgayNhap.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
               this.dTNgayNhap.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
               this.dTNgayNhap.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
               this.dTNgayNhap.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.dTNgayNhap.MonthCalendar.DisplayMonth = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
               // 
               // 
               // 
               this.dTNgayNhap.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
               this.dTNgayNhap.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
               this.dTNgayNhap.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
               this.dTNgayNhap.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.dTNgayNhap.MonthCalendar.TodayButtonVisible = true;
               this.dTNgayNhap.Name = "dTNgayNhap";
               this.dTNgayNhap.ShowUpDown = true;
               this.dTNgayNhap.Size = new System.Drawing.Size(210, 22);
               this.dTNgayNhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.dTNgayNhap.TabIndex = 167;
               this.dTNgayNhap.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
               this.dTNgayNhap.WatermarkText = "18/07/2000";
               // 
               // labelX2
               // 
               // 
               // 
               // 
               this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.labelX2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelX2.Location = new System.Drawing.Point(677, 339);
               this.labelX2.Name = "labelX2";
               this.labelX2.Size = new System.Drawing.Size(126, 23);
               this.labelX2.TabIndex = 166;
               this.labelX2.Text = "Ngày nhập:";
               // 
               // panelEx8
               // 
               this.panelEx8.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.panelEx8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
               this.panelEx8.DisabledBackColor = System.Drawing.Color.Empty;
               this.panelEx8.Location = new System.Drawing.Point(676, 280);
               this.panelEx8.Name = "panelEx8";
               this.panelEx8.Size = new System.Drawing.Size(285, 1);
               this.panelEx8.Style.Alignment = System.Drawing.StringAlignment.Center;
               this.panelEx8.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
               this.panelEx8.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
               this.panelEx8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
               this.panelEx8.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
               this.panelEx8.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
               this.panelEx8.Style.GradientAngle = 90;
               this.panelEx8.TabIndex = 163;
               this.panelEx8.Text = "panelEx8";
               // 
               // txtSoLuong
               // 
               this.txtSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
               // 
               // 
               // 
               this.txtSoLuong.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
               this.txtSoLuong.Border.Class = "TextBoxBorder";
               this.txtSoLuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.txtSoLuong.DisabledBackColor = System.Drawing.Color.White;
               this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtSoLuong.Location = new System.Drawing.Point(676, 248);
               this.txtSoLuong.Multiline = true;
               this.txtSoLuong.Name = "txtSoLuong";
               this.txtSoLuong.PreventEnterBeep = true;
               this.txtSoLuong.Size = new System.Drawing.Size(285, 26);
               this.txtSoLuong.TabIndex = 162;
               this.txtSoLuong.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtSoLuong.WatermarkText = "Số lượng";
               // 
               // panelEx7
               // 
               this.panelEx7.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.panelEx7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
               this.panelEx7.DisabledBackColor = System.Drawing.Color.Empty;
               this.panelEx7.Location = new System.Drawing.Point(677, 367);
               this.panelEx7.Name = "panelEx7";
               this.panelEx7.Size = new System.Drawing.Size(285, 1);
               this.panelEx7.Style.Alignment = System.Drawing.StringAlignment.Center;
               this.panelEx7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
               this.panelEx7.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
               this.panelEx7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
               this.panelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
               this.panelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
               this.panelEx7.Style.GradientAngle = 90;
               this.panelEx7.TabIndex = 161;
               this.panelEx7.Text = "panelEx7";
               // 
               // panelEx5
               // 
               this.panelEx5.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.panelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
               this.panelEx5.DisabledBackColor = System.Drawing.Color.Empty;
               this.panelEx5.Location = new System.Drawing.Point(676, 199);
               this.panelEx5.Name = "panelEx5";
               this.panelEx5.Size = new System.Drawing.Size(285, 1);
               this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
               this.panelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
               this.panelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
               this.panelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
               this.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
               this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
               this.panelEx5.Style.GradientAngle = 90;
               this.panelEx5.TabIndex = 159;
               this.panelEx5.Text = "panelEx5";
               // 
               // txtMaVC
               // 
               this.txtMaVC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
               // 
               // 
               // 
               this.txtMaVC.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
               this.txtMaVC.Border.Class = "TextBoxBorder";
               this.txtMaVC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.txtMaVC.DisabledBackColor = System.Drawing.Color.White;
               this.txtMaVC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtMaVC.Location = new System.Drawing.Point(676, 167);
               this.txtMaVC.Multiline = true;
               this.txtMaVC.Name = "txtMaVC";
               this.txtMaVC.PreventEnterBeep = true;
               this.txtMaVC.Size = new System.Drawing.Size(285, 26);
               this.txtMaVC.TabIndex = 158;
               this.txtMaVC.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtMaVC.WatermarkText = "Mã vaccine";
               // 
               // panelEx2
               // 
               this.panelEx2.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
               this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
               this.panelEx2.Location = new System.Drawing.Point(676, 121);
               this.panelEx2.Name = "panelEx2";
               this.panelEx2.Size = new System.Drawing.Size(285, 1);
               this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
               this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
               this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
               this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
               this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
               this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
               this.panelEx2.Style.GradientAngle = 90;
               this.panelEx2.TabIndex = 153;
               this.panelEx2.Text = "panelEx2";
               // 
               // txtMaPN
               // 
               this.txtMaPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
               // 
               // 
               // 
               this.txtMaPN.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
               this.txtMaPN.Border.Class = "TextBoxBorder";
               this.txtMaPN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.txtMaPN.DisabledBackColor = System.Drawing.Color.White;
               this.txtMaPN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtMaPN.Location = new System.Drawing.Point(676, 89);
               this.txtMaPN.Multiline = true;
               this.txtMaPN.Name = "txtMaPN";
               this.txtMaPN.PreventEnterBeep = true;
               this.txtMaPN.Size = new System.Drawing.Size(285, 26);
               this.txtMaPN.TabIndex = 152;
               this.txtMaPN.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtMaPN.WatermarkText = "Mã phiếu nhập";
               // 
               // btnXuatPN
               // 
               this.btnXuatPN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
               this.btnXuatPN.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
               this.btnXuatPN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXuatPN.Location = new System.Drawing.Point(665, 533);
               this.btnXuatPN.Name = "btnXuatPN";
               this.btnXuatPN.Size = new System.Drawing.Size(296, 44);
               this.btnXuatPN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.btnXuatPN.Symbol = "";
               this.btnXuatPN.SymbolColor = System.Drawing.Color.Blue;
               this.btnXuatPN.TabIndex = 168;
               this.btnXuatPN.Text = "Xuất Phiếu";
               // 
               // PhieuNhap
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.btnXuatPN);
               this.Controls.Add(this.dTNgayNhap);
               this.Controls.Add(this.labelX2);
               this.Controls.Add(this.panelEx8);
               this.Controls.Add(this.txtSoLuong);
               this.Controls.Add(this.panelEx7);
               this.Controls.Add(this.panelEx5);
               this.Controls.Add(this.txtMaVC);
               this.Controls.Add(this.panelEx2);
               this.Controls.Add(this.txtMaPN);
               this.Controls.Add(this.btnSua);
               this.Controls.Add(this.btnThem);
               this.Controls.Add(this.dataGridViewBS);
               this.Controls.Add(this.panelEx1);
               this.Name = "PhieuNhap";
               this.Size = new System.Drawing.Size(981, 734);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBS)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dTNgayNhap)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private DevComponents.DotNetBar.ButtonX btnSua;
          private DevComponents.DotNetBar.ButtonX btnThem;
          private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewBS;
          private System.Windows.Forms.DataGridViewTextBoxColumn STT;
          private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
          private System.Windows.Forms.DataGridViewTextBoxColumn MaVC;
          private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
          private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
          private DevComponents.DotNetBar.PanelEx panelEx1;
          private DevComponents.Editors.DateTimeAdv.DateTimeInput dTNgayNhap;
          private DevComponents.DotNetBar.LabelX labelX2;
          private DevComponents.DotNetBar.PanelEx panelEx8;
          private DevComponents.DotNetBar.Controls.TextBoxX txtSoLuong;
          private DevComponents.DotNetBar.PanelEx panelEx7;
          private DevComponents.DotNetBar.PanelEx panelEx5;
          private DevComponents.DotNetBar.Controls.TextBoxX txtMaVC;
          private DevComponents.DotNetBar.PanelEx panelEx2;
          private DevComponents.DotNetBar.Controls.TextBoxX txtMaPN;
          private DevComponents.DotNetBar.ButtonX btnXuatPN;
     }
}
