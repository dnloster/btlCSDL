namespace btlCSDL.UI.QTV.NghiepVu
{
     partial class PhieuTiem
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
               this.dataGridViewBS = new DevComponents.DotNetBar.Controls.DataGridViewX();
               this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.NgayTiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
               this.btnThem = new DevComponents.DotNetBar.ButtonX();
               this.btnSua = new DevComponents.DotNetBar.ButtonX();
               this.dTNgayTiem = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
               this.labelX2 = new DevComponents.DotNetBar.LabelX();
               this.panelEx8 = new DevComponents.DotNetBar.PanelEx();
               this.txtMaKH = new DevComponents.DotNetBar.Controls.TextBoxX();
               this.panelEx7 = new DevComponents.DotNetBar.PanelEx();
               this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
               this.txtMaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
               this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
               this.txtMaPT = new DevComponents.DotNetBar.Controls.TextBoxX();
               this.btnXuatPT = new DevComponents.DotNetBar.ButtonX();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBS)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dTNgayTiem)).BeginInit();
               this.SuspendLayout();
               // 
               // dataGridViewBS
               // 
               this.dataGridViewBS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridViewBS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
               this.dataGridViewBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridViewBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPT,
            this.MaNV,
            this.MaKH,
            this.NgayTiem});
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
               this.dataGridViewBS.Location = new System.Drawing.Point(0, 46);
               this.dataGridViewBS.Name = "dataGridViewBS";
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
               dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
               dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dataGridViewBS.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
               this.dataGridViewBS.Size = new System.Drawing.Size(632, 688);
               this.dataGridViewBS.TabIndex = 118;
               // 
               // STT
               // 
               this.STT.DataPropertyName = "STT";
               this.STT.HeaderText = "STT";
               this.STT.Name = "STT";
               // 
               // MaPT
               // 
               this.MaPT.DataPropertyName = "MaPT";
               this.MaPT.HeaderText = "Mã phiếu tiêm";
               this.MaPT.Name = "MaPT";
               // 
               // MaNV
               // 
               this.MaNV.DataPropertyName = "MaNV";
               this.MaNV.HeaderText = "Mã nhân viên";
               this.MaNV.Name = "MaNV";
               // 
               // MaKH
               // 
               this.MaKH.DataPropertyName = "MaKH";
               this.MaKH.HeaderText = "Mã KH";
               this.MaKH.Name = "MaKH";
               // 
               // NgayTiem
               // 
               this.NgayTiem.DataPropertyName = "NgayTiem";
               this.NgayTiem.HeaderText = "Ngày tiêm";
               this.NgayTiem.Name = "NgayTiem";
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
               this.panelEx1.TabIndex = 98;
               this.panelEx1.Text = "Phiếu Tiêm";
               // 
               // btnThem
               // 
               this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
               this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
               this.btnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnThem.Location = new System.Drawing.Point(653, 420);
               this.btnThem.Name = "btnThem";
               this.btnThem.Size = new System.Drawing.Size(117, 44);
               this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.btnThem.Symbol = "";
               this.btnThem.SymbolColor = System.Drawing.Color.Lime;
               this.btnThem.TabIndex = 119;
               this.btnThem.Text = "Thêm";
               // 
               // btnSua
               // 
               this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
               this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
               this.btnSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSua.Location = new System.Drawing.Point(832, 420);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(117, 44);
               this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.btnSua.Symbol = "";
               this.btnSua.SymbolColor = System.Drawing.Color.MediumBlue;
               this.btnSua.TabIndex = 120;
               this.btnSua.Text = "Sửa";
               // 
               // dTNgayTiem
               // 
               // 
               // 
               // 
               this.dTNgayTiem.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
               this.dTNgayTiem.BackgroundStyle.Class = "DateTimeInputBackground";
               this.dTNgayTiem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.dTNgayTiem.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
               this.dTNgayTiem.ButtonDropDown.Visible = true;
               this.dTNgayTiem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.dTNgayTiem.ForeColor = System.Drawing.SystemColors.WindowText;
               this.dTNgayTiem.IsPopupCalendarOpen = false;
               this.dTNgayTiem.Location = new System.Drawing.Point(767, 347);
               // 
               // 
               // 
               // 
               // 
               // 
               this.dTNgayTiem.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.dTNgayTiem.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
               this.dTNgayTiem.MonthCalendar.ClearButtonVisible = true;
               // 
               // 
               // 
               this.dTNgayTiem.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
               this.dTNgayTiem.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
               this.dTNgayTiem.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
               this.dTNgayTiem.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
               this.dTNgayTiem.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
               this.dTNgayTiem.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
               this.dTNgayTiem.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.dTNgayTiem.MonthCalendar.DisplayMonth = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
               // 
               // 
               // 
               this.dTNgayTiem.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
               this.dTNgayTiem.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
               this.dTNgayTiem.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
               this.dTNgayTiem.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.dTNgayTiem.MonthCalendar.TodayButtonVisible = true;
               this.dTNgayTiem.Name = "dTNgayTiem";
               this.dTNgayTiem.ShowUpDown = true;
               this.dTNgayTiem.Size = new System.Drawing.Size(163, 22);
               this.dTNgayTiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.dTNgayTiem.TabIndex = 160;
               this.dTNgayTiem.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
               this.dTNgayTiem.WatermarkText = "18/07/2000";
               // 
               // labelX2
               // 
               // 
               // 
               // 
               this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.labelX2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelX2.Location = new System.Drawing.Point(694, 347);
               this.labelX2.Name = "labelX2";
               this.labelX2.Size = new System.Drawing.Size(67, 23);
               this.labelX2.TabIndex = 159;
               this.labelX2.Text = "Ngày tiêm:";
               // 
               // panelEx8
               // 
               this.panelEx8.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.panelEx8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
               this.panelEx8.DisabledBackColor = System.Drawing.Color.Empty;
               this.panelEx8.Location = new System.Drawing.Point(693, 285);
               this.panelEx8.Name = "panelEx8";
               this.panelEx8.Size = new System.Drawing.Size(237, 1);
               this.panelEx8.Style.Alignment = System.Drawing.StringAlignment.Center;
               this.panelEx8.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
               this.panelEx8.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
               this.panelEx8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
               this.panelEx8.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
               this.panelEx8.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
               this.panelEx8.Style.GradientAngle = 90;
               this.panelEx8.TabIndex = 156;
               this.panelEx8.Text = "panelEx8";
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
               this.txtMaKH.Location = new System.Drawing.Point(693, 253);
               this.txtMaKH.Multiline = true;
               this.txtMaKH.Name = "txtMaKH";
               this.txtMaKH.PreventEnterBeep = true;
               this.txtMaKH.Size = new System.Drawing.Size(237, 26);
               this.txtMaKH.TabIndex = 155;
               this.txtMaKH.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtMaKH.WatermarkText = "Mã khách hàng";
               // 
               // panelEx7
               // 
               this.panelEx7.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.panelEx7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
               this.panelEx7.DisabledBackColor = System.Drawing.Color.Empty;
               this.panelEx7.Location = new System.Drawing.Point(694, 375);
               this.panelEx7.Name = "panelEx7";
               this.panelEx7.Size = new System.Drawing.Size(237, 1);
               this.panelEx7.Style.Alignment = System.Drawing.StringAlignment.Center;
               this.panelEx7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
               this.panelEx7.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
               this.panelEx7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
               this.panelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
               this.panelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
               this.panelEx7.Style.GradientAngle = 90;
               this.panelEx7.TabIndex = 154;
               this.panelEx7.Text = "panelEx7";
               // 
               // panelEx5
               // 
               this.panelEx5.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.panelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
               this.panelEx5.DisabledBackColor = System.Drawing.Color.Empty;
               this.panelEx5.Location = new System.Drawing.Point(693, 196);
               this.panelEx5.Name = "panelEx5";
               this.panelEx5.Size = new System.Drawing.Size(237, 1);
               this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
               this.panelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
               this.panelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
               this.panelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
               this.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
               this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
               this.panelEx5.Style.GradientAngle = 90;
               this.panelEx5.TabIndex = 152;
               this.panelEx5.Text = "panelEx5";
               // 
               // txtMaNV
               // 
               this.txtMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
               // 
               // 
               // 
               this.txtMaNV.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
               this.txtMaNV.Border.Class = "TextBoxBorder";
               this.txtMaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.txtMaNV.DisabledBackColor = System.Drawing.Color.White;
               this.txtMaNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtMaNV.Location = new System.Drawing.Point(693, 164);
               this.txtMaNV.Multiline = true;
               this.txtMaNV.Name = "txtMaNV";
               this.txtMaNV.PreventEnterBeep = true;
               this.txtMaNV.Size = new System.Drawing.Size(237, 26);
               this.txtMaNV.TabIndex = 151;
               this.txtMaNV.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtMaNV.WatermarkText = "Mã nhân viên";
               // 
               // panelEx2
               // 
               this.panelEx2.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
               this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
               this.panelEx2.Location = new System.Drawing.Point(693, 117);
               this.panelEx2.Name = "panelEx2";
               this.panelEx2.Size = new System.Drawing.Size(237, 1);
               this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
               this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
               this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
               this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
               this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
               this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
               this.panelEx2.Style.GradientAngle = 90;
               this.panelEx2.TabIndex = 146;
               this.panelEx2.Text = "panelEx2";
               // 
               // txtMaPT
               // 
               this.txtMaPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
               // 
               // 
               // 
               this.txtMaPT.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
               this.txtMaPT.Border.Class = "TextBoxBorder";
               this.txtMaPT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.txtMaPT.DisabledBackColor = System.Drawing.Color.White;
               this.txtMaPT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtMaPT.Location = new System.Drawing.Point(693, 85);
               this.txtMaPT.Multiline = true;
               this.txtMaPT.Name = "txtMaPT";
               this.txtMaPT.PreventEnterBeep = true;
               this.txtMaPT.Size = new System.Drawing.Size(237, 26);
               this.txtMaPT.TabIndex = 145;
               this.txtMaPT.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtMaPT.WatermarkText = "Mã phiếu tiêm";
               // 
               // btnXuatPT
               // 
               this.btnXuatPT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
               this.btnXuatPT.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
               this.btnXuatPT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXuatPT.Location = new System.Drawing.Point(653, 520);
               this.btnXuatPT.Name = "btnXuatPT";
               this.btnXuatPT.Size = new System.Drawing.Size(296, 44);
               this.btnXuatPT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.btnXuatPT.Symbol = "";
               this.btnXuatPT.SymbolColor = System.Drawing.Color.Blue;
               this.btnXuatPT.TabIndex = 161;
               this.btnXuatPT.Text = "Xuất Phiếu";
               // 
               // PhieuTiem
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.btnXuatPT);
               this.Controls.Add(this.dTNgayTiem);
               this.Controls.Add(this.labelX2);
               this.Controls.Add(this.panelEx8);
               this.Controls.Add(this.txtMaKH);
               this.Controls.Add(this.panelEx7);
               this.Controls.Add(this.panelEx5);
               this.Controls.Add(this.txtMaNV);
               this.Controls.Add(this.panelEx2);
               this.Controls.Add(this.txtMaPT);
               this.Controls.Add(this.btnSua);
               this.Controls.Add(this.btnThem);
               this.Controls.Add(this.dataGridViewBS);
               this.Controls.Add(this.panelEx1);
               this.Name = "PhieuTiem";
               this.Size = new System.Drawing.Size(981, 734);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBS)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dTNgayTiem)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion
          private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewBS;
          private DevComponents.DotNetBar.PanelEx panelEx1;
          private DevComponents.DotNetBar.ButtonX btnThem;
          private DevComponents.DotNetBar.ButtonX btnSua;
          private System.Windows.Forms.DataGridViewTextBoxColumn STT;
          private System.Windows.Forms.DataGridViewTextBoxColumn MaPT;
          private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
          private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
          private System.Windows.Forms.DataGridViewTextBoxColumn NgayTiem;
          private DevComponents.Editors.DateTimeAdv.DateTimeInput dTNgayTiem;
          private DevComponents.DotNetBar.LabelX labelX2;
          private DevComponents.DotNetBar.PanelEx panelEx8;
          private DevComponents.DotNetBar.Controls.TextBoxX txtMaKH;
          private DevComponents.DotNetBar.PanelEx panelEx7;
          private DevComponents.DotNetBar.PanelEx panelEx5;
          private DevComponents.DotNetBar.Controls.TextBoxX txtMaNV;
          private DevComponents.DotNetBar.PanelEx panelEx2;
          private DevComponents.DotNetBar.Controls.TextBoxX txtMaPT;
          private DevComponents.DotNetBar.ButtonX btnXuatPT;
     }
}
