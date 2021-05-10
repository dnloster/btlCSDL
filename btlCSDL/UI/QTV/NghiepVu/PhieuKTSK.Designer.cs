namespace btlCSDL.UI.QTV.NghiepVu
{
     partial class PhieuKTSK
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
               this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
               this.btnSua = new DevComponents.DotNetBar.ButtonX();
               this.btnThem = new DevComponents.DotNetBar.ButtonX();
               this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaPhieuKTSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.ChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.MaPhieuKTSK,
            this.MaKH,
            this.MaBS,
            this.NgayKT,
            this.NoiDung,
            this.ChiPhi});
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
               this.dataGridViewBS.TabIndex = 123;
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
               this.panelEx1.Text = "Phiếu Kiểm Tra Sức Khoẻ";
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
               this.btnSua.TabIndex = 125;
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
               this.btnThem.TabIndex = 124;
               this.btnThem.Text = "Thêm";
               // 
               // STT
               // 
               this.STT.DataPropertyName = "STT";
               this.STT.HeaderText = "STT";
               this.STT.Name = "STT";
               // 
               // MaPhieuKTSK
               // 
               this.MaPhieuKTSK.DataPropertyName = "MaPhieuKTSK";
               this.MaPhieuKTSK.HeaderText = "Mã phiếu";
               this.MaPhieuKTSK.Name = "MaPhieuKTSK";
               // 
               // MaKH
               // 
               this.MaKH.DataPropertyName = "MaKH";
               this.MaKH.HeaderText = "Mã KH";
               this.MaKH.Name = "MaKH";
               // 
               // MaBS
               // 
               this.MaBS.DataPropertyName = "MaBS";
               this.MaBS.HeaderText = "Mã bác sỹ";
               this.MaBS.Name = "MaBS";
               // 
               // NgayKT
               // 
               this.NgayKT.DataPropertyName = "NgayKT";
               this.NgayKT.HeaderText = "Ngày kiểm tra";
               this.NgayKT.Name = "NgayKT";
               // 
               // NoiDung
               // 
               this.NoiDung.DataPropertyName = "NoiDung";
               this.NoiDung.HeaderText = "Nội dung";
               this.NoiDung.Name = "NoiDung";
               // 
               // ChiPhi
               // 
               this.ChiPhi.DataPropertyName = "ChiPhi";
               this.ChiPhi.HeaderText = "Chi phí";
               this.ChiPhi.Name = "ChiPhi";
               // 
               // PhieuKTSK
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.dataGridViewBS);
               this.Controls.Add(this.panelEx1);
               this.Controls.Add(this.btnSua);
               this.Controls.Add(this.btnThem);
               this.Name = "PhieuKTSK";
               this.Size = new System.Drawing.Size(981, 734);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBS)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion
          private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewBS;
          private DevComponents.DotNetBar.PanelEx panelEx1;
          private DevComponents.DotNetBar.ButtonX btnSua;
          private DevComponents.DotNetBar.ButtonX btnThem;
          private System.Windows.Forms.DataGridViewTextBoxColumn STT;
          private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuKTSK;
          private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
          private System.Windows.Forms.DataGridViewTextBoxColumn MaBS;
          private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
          private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
          private System.Windows.Forms.DataGridViewTextBoxColumn ChiPhi;
     }
}
