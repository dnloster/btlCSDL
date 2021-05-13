namespace btlCSDL.UI.QTV.NghiepVu
{
     partial class HoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dataGridViewHD = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTNgayTT = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx8 = new DevComponents.DotNetBar.PanelEx();
            this.txtTongTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx7 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
            this.txtMaPT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txtMaHD = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnXuatHD = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTNgayTT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(682, 439);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 44);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.Symbol = "";
            this.btnThem.SymbolColor = System.Drawing.Color.Lime;
            this.btnThem.TabIndex = 124;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(839, 439);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 44);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.Symbol = "";
            this.btnSua.SymbolColor = System.Drawing.Color.MediumBlue;
            this.btnSua.TabIndex = 125;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
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
            this.panelEx1.TabIndex = 122;
            this.panelEx1.Text = "Hoá Đơn";
            // 
            // dataGridViewHD
            // 
            this.dataGridViewHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaPT,
            this.TongTien,
            this.NgayTT});
            this.dataGridViewHD.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewHD.Location = new System.Drawing.Point(0, 46);
            this.dataGridViewHD.Name = "dataGridViewHD";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewHD.Size = new System.Drawing.Size(668, 688);
            this.dataGridViewHD.TabIndex = 123;
            this.dataGridViewHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHD_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hoá đơn";
            this.MaHD.Name = "MaHD";
            // 
            // MaPT
            // 
            this.MaPT.DataPropertyName = "MaPT";
            this.MaPT.HeaderText = "Mã phiếu tiêm";
            this.MaPT.Name = "MaPT";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // NgayTT
            // 
            this.NgayTT.DataPropertyName = "NgayTT";
            this.NgayTT.HeaderText = "Ngày thanh toán";
            this.NgayTT.Name = "NgayTT";
            // 
            // dTNgayTT
            // 
            // 
            // 
            // 
            this.dTNgayTT.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dTNgayTT.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dTNgayTT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dTNgayTT.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dTNgayTT.ButtonDropDown.Visible = true;
            this.dTNgayTT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTNgayTT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dTNgayTT.IsPopupCalendarOpen = false;
            this.dTNgayTT.Location = new System.Drawing.Point(796, 352);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dTNgayTT.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dTNgayTT.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dTNgayTT.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dTNgayTT.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dTNgayTT.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dTNgayTT.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dTNgayTT.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dTNgayTT.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dTNgayTT.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dTNgayTT.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dTNgayTT.MonthCalendar.DisplayMonth = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dTNgayTT.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dTNgayTT.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dTNgayTT.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dTNgayTT.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dTNgayTT.MonthCalendar.TodayButtonVisible = true;
            this.dTNgayTT.Name = "dTNgayTT";
            this.dTNgayTT.ShowUpDown = true;
            this.dTNgayTT.Size = new System.Drawing.Size(160, 22);
            this.dTNgayTT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dTNgayTT.TabIndex = 163;
            this.dTNgayTT.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            this.dTNgayTT.WatermarkText = "18/07/2000";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(693, 352);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(124, 23);
            this.labelX2.TabIndex = 162;
            this.labelX2.Text = "Ngày thanh toán:";
            // 
            // panelEx8
            // 
            this.panelEx8.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelEx8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panelEx8.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx8.Location = new System.Drawing.Point(692, 295);
            this.panelEx8.Name = "panelEx8";
            this.panelEx8.Size = new System.Drawing.Size(264, 1);
            this.panelEx8.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx8.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx8.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx8.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx8.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx8.Style.GradientAngle = 90;
            this.panelEx8.TabIndex = 159;
            this.panelEx8.Text = "panelEx8";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // 
            // 
            this.txtTongTien.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtTongTien.Border.Class = "TextBoxBorder";
            this.txtTongTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTongTien.DisabledBackColor = System.Drawing.Color.White;
            this.txtTongTien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(692, 263);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PreventEnterBeep = true;
            this.txtTongTien.Size = new System.Drawing.Size(264, 26);
            this.txtTongTien.TabIndex = 158;
            this.txtTongTien.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.WatermarkText = "Tổng tiền";
            // 
            // panelEx7
            // 
            this.panelEx7.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelEx7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panelEx7.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx7.Location = new System.Drawing.Point(693, 380);
            this.panelEx7.Name = "panelEx7";
            this.panelEx7.Size = new System.Drawing.Size(264, 1);
            this.panelEx7.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx7.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx7.Style.GradientAngle = 90;
            this.panelEx7.TabIndex = 157;
            this.panelEx7.Text = "panelEx7";
            // 
            // panelEx5
            // 
            this.panelEx5.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panelEx5.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx5.Location = new System.Drawing.Point(692, 200);
            this.panelEx5.Name = "panelEx5";
            this.panelEx5.Size = new System.Drawing.Size(264, 1);
            this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx5.Style.GradientAngle = 90;
            this.panelEx5.TabIndex = 155;
            this.panelEx5.Text = "panelEx5";
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
            this.txtMaPT.Location = new System.Drawing.Point(692, 168);
            this.txtMaPT.Multiline = true;
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.PreventEnterBeep = true;
            this.txtMaPT.Size = new System.Drawing.Size(264, 26);
            this.txtMaPT.TabIndex = 154;
            this.txtMaPT.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPT.WatermarkText = "Mã phiếu tiêm";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(692, 116);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(264, 1);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 149;
            this.panelEx2.Text = "panelEx2";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // 
            // 
            this.txtMaHD.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtMaHD.Border.Class = "TextBoxBorder";
            this.txtMaHD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaHD.DisabledBackColor = System.Drawing.Color.White;
            this.txtMaHD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(692, 84);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PreventEnterBeep = true;
            this.txtMaHD.Size = new System.Drawing.Size(264, 26);
            this.txtMaHD.TabIndex = 148;
            this.txtMaHD.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.WatermarkText = "Mã hoá đơn";
            // 
            // btnXuatHD
            // 
            this.btnXuatHD.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatHD.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnXuatHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHD.Location = new System.Drawing.Point(682, 525);
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.Size = new System.Drawing.Size(274, 44);
            this.btnXuatHD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatHD.Symbol = "";
            this.btnXuatHD.SymbolColor = System.Drawing.Color.Blue;
            this.btnXuatHD.TabIndex = 164;
            this.btnXuatHD.Text = "Xuất hoá đơn";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXuatHD);
            this.Controls.Add(this.dTNgayTT);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.panelEx8);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.panelEx7);
            this.Controls.Add(this.panelEx5);
            this.Controls.Add(this.txtMaPT);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.dataGridViewHD);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "HoaDon";
            this.Size = new System.Drawing.Size(981, 734);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTNgayTT)).EndInit();
            this.ResumeLayout(false);

          }

          #endregion

          private DevComponents.DotNetBar.ButtonX btnThem;
          private DevComponents.DotNetBar.ButtonX btnSua;
          private DevComponents.DotNetBar.PanelEx panelEx1;
          private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewHD;
          private DevComponents.Editors.DateTimeAdv.DateTimeInput dTNgayTT;
          private DevComponents.DotNetBar.LabelX labelX2;
          private DevComponents.DotNetBar.PanelEx panelEx8;
          private DevComponents.DotNetBar.Controls.TextBoxX txtTongTien;
          private DevComponents.DotNetBar.PanelEx panelEx7;
          private DevComponents.DotNetBar.PanelEx panelEx5;
          private DevComponents.DotNetBar.Controls.TextBoxX txtMaPT;
          private DevComponents.DotNetBar.PanelEx panelEx2;
          private DevComponents.DotNetBar.Controls.TextBoxX txtMaHD;
          private DevComponents.DotNetBar.ButtonX btnXuatHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTT;
    }
}
