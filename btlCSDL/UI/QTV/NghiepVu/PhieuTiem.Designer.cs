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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
               this.dataGridViewBS = new DevComponents.DotNetBar.Controls.DataGridViewX();
               this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
               this.btnThem = new DevComponents.DotNetBar.ButtonX();
               this.btnSua = new DevComponents.DotNetBar.ButtonX();
               this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.NgayTiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBS)).BeginInit();
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
               dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
               dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
               dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
               dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
               dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.dataGridViewBS.DefaultCellStyle = dataGridViewCellStyle3;
               this.dataGridViewBS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
               this.dataGridViewBS.Location = new System.Drawing.Point(0, 53);
               this.dataGridViewBS.Name = "dataGridViewBS";
               dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
               dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
               dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dataGridViewBS.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
               this.dataGridViewBS.Size = new System.Drawing.Size(981, 588);
               this.dataGridViewBS.TabIndex = 118;
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
               this.btnThem.Location = new System.Drawing.Point(306, 668);
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
               this.btnSua.Location = new System.Drawing.Point(485, 668);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(117, 44);
               this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.btnSua.Symbol = "";
               this.btnSua.SymbolColor = System.Drawing.Color.MediumBlue;
               this.btnSua.TabIndex = 120;
               this.btnSua.Text = "Sửa";
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
               // PhieuTiem
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.btnSua);
               this.Controls.Add(this.btnThem);
               this.Controls.Add(this.dataGridViewBS);
               this.Controls.Add(this.panelEx1);
               this.Name = "PhieuTiem";
               this.Size = new System.Drawing.Size(981, 734);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBS)).EndInit();
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
     }
}
