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
               this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
               this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBS)).BeginInit();
               this.SuspendLayout();
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
               this.btnSua.TabIndex = 127;
               this.btnSua.Text = "Sửa";
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
               this.dataGridViewBS.Location = new System.Drawing.Point(0, 53);
               this.dataGridViewBS.Name = "dataGridViewBS";
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
               dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
               dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dataGridViewBS.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
               this.dataGridViewBS.Size = new System.Drawing.Size(981, 588);
               this.dataGridViewBS.TabIndex = 125;
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
               this.panelEx1.Text = "Phiếu Tiêm";
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
               // PhieuNhap
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.btnSua);
               this.Controls.Add(this.btnThem);
               this.Controls.Add(this.dataGridViewBS);
               this.Controls.Add(this.panelEx1);
               this.Name = "PhieuNhap";
               this.Size = new System.Drawing.Size(981, 734);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBS)).EndInit();
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
     }
}
