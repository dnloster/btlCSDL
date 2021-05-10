namespace btlCSDL.UI.Khach
{
     partial class ucBangGia
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBangGia));
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
               this.bindingNavigatorMoveLastItem = new DevComponents.DotNetBar.ButtonItem();
               this.bindingNavigatorPositionItem = new DevComponents.DotNetBar.TextBoxItem();
               this.bindingNavigatorMovePreviousItem = new DevComponents.DotNetBar.ButtonItem();
               this.bindingNavigatorMoveFirstItem = new DevComponents.DotNetBar.ButtonItem();
               this.bindingNavigatorDeleteItem = new DevComponents.DotNetBar.ButtonItem();
               this.bindingNavigatorCountItem = new DevComponents.DotNetBar.LabelItem();
               this.bindingNavigatorAddNewItem = new DevComponents.DotNetBar.ButtonItem();
               this.bindingNavigatorEx1 = new DevComponents.DotNetBar.Controls.BindingNavigatorEx(this.components);
               this.bindingNavigatorMoveNextItem = new DevComponents.DotNetBar.ButtonItem();
               this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
               this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.NuocSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.TenVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
               ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEx1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
               this.SuspendLayout();
               // 
               // bindingNavigatorMoveLastItem
               // 
               this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
               this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
               this.bindingNavigatorMoveLastItem.Text = "Move last";
               // 
               // bindingNavigatorPositionItem
               // 
               this.bindingNavigatorPositionItem.AccessibleName = "Position";
               this.bindingNavigatorPositionItem.BeginGroup = true;
               this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
               this.bindingNavigatorPositionItem.Text = "0";
               this.bindingNavigatorPositionItem.TextBoxWidth = 54;
               this.bindingNavigatorPositionItem.WatermarkColor = System.Drawing.SystemColors.GrayText;
               // 
               // bindingNavigatorMovePreviousItem
               // 
               this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
               this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
               this.bindingNavigatorMovePreviousItem.Text = "Move previous";
               // 
               // bindingNavigatorMoveFirstItem
               // 
               this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
               this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
               this.bindingNavigatorMoveFirstItem.Text = "Move first";
               // 
               // bindingNavigatorDeleteItem
               // 
               this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
               this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
               this.bindingNavigatorDeleteItem.Text = "Delete";
               // 
               // bindingNavigatorCountItem
               // 
               this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
               this.bindingNavigatorCountItem.Text = "of {0}";
               // 
               // bindingNavigatorAddNewItem
               // 
               this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
               this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
               this.bindingNavigatorAddNewItem.Text = "Add new";
               // 
               // bindingNavigatorEx1
               // 
               this.bindingNavigatorEx1.AddNewRecordButton = this.bindingNavigatorAddNewItem;
               this.bindingNavigatorEx1.AntiAlias = true;
               this.bindingNavigatorEx1.CountLabel = this.bindingNavigatorCountItem;
               this.bindingNavigatorEx1.CountLabelFormat = "of {0}";
               this.bindingNavigatorEx1.DeleteButton = this.bindingNavigatorDeleteItem;
               this.bindingNavigatorEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.bindingNavigatorEx1.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.bindingNavigatorEx1.IsMaximized = false;
               this.bindingNavigatorEx1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
               this.bindingNavigatorEx1.Location = new System.Drawing.Point(0, 710);
               this.bindingNavigatorEx1.MoveFirstButton = this.bindingNavigatorMoveFirstItem;
               this.bindingNavigatorEx1.MoveLastButton = this.bindingNavigatorMoveLastItem;
               this.bindingNavigatorEx1.MoveNextButton = this.bindingNavigatorMoveNextItem;
               this.bindingNavigatorEx1.MovePreviousButton = this.bindingNavigatorMovePreviousItem;
               this.bindingNavigatorEx1.Name = "bindingNavigatorEx1";
               this.bindingNavigatorEx1.PositionTextBox = this.bindingNavigatorPositionItem;
               this.bindingNavigatorEx1.Size = new System.Drawing.Size(981, 24);
               this.bindingNavigatorEx1.Stretch = true;
               this.bindingNavigatorEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
               this.bindingNavigatorEx1.TabIndex = 12;
               this.bindingNavigatorEx1.TabStop = false;
               this.bindingNavigatorEx1.Text = "bindingNavigatorEx1";
               // 
               // bindingNavigatorMoveNextItem
               // 
               this.bindingNavigatorMoveNextItem.BeginGroup = true;
               this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
               this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
               this.bindingNavigatorMoveNextItem.Text = "Move next";
               // 
               // panelEx1
               // 
               this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
               this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
               this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
               this.panelEx1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
               this.panelEx1.TabIndex = 11;
               this.panelEx1.Text = "Bảng giá Vaccine cho 1 lần tiêm";
               // 
               // DonGia
               // 
               this.DonGia.DataPropertyName = "DG";
               this.DonGia.HeaderText = "Đơn Giá";
               this.DonGia.Name = "DonGia";
               // 
               // NuocSX
               // 
               this.NuocSX.DataPropertyName = "NuocSX";
               this.NuocSX.HeaderText = "Nước Sản Xuất";
               this.NuocSX.Name = "NuocSX";
               // 
               // HSD
               // 
               this.HSD.DataPropertyName = "HSD";
               this.HSD.HeaderText = "Hạn Sử Dụng";
               this.HSD.Name = "HSD";
               // 
               // NSX
               // 
               this.NSX.DataPropertyName = "NSX";
               this.NSX.HeaderText = "Ngày Sản Xuất";
               this.NSX.Name = "NSX";
               // 
               // TenVC
               // 
               this.TenVC.DataPropertyName = "TenVC";
               this.TenVC.HeaderText = "Tên Vaccine";
               this.TenVC.Name = "TenVC";
               // 
               // MaVC
               // 
               this.MaVC.DataPropertyName = "CL";
               this.MaVC.HeaderText = "Chủng Loại";
               this.MaVC.Name = "MaVC";
               // 
               // STT
               // 
               this.STT.DataPropertyName = "STT";
               this.STT.HeaderText = "STT";
               this.STT.Name = "STT";
               // 
               // DonViTinh
               // 
               this.DonViTinh.DataPropertyName = "DvT";
               this.DonViTinh.HeaderText = "Đơn vị Tính";
               this.DonViTinh.Name = "DonViTinh";
               // 
               // dataGridViewX1
               // 
               this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
               this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaVC,
            this.TenVC,
            this.NSX,
            this.HSD,
            this.NuocSX,
            this.DonGia,
            this.DonViTinh});
               dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
               dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
               dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
               dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
               dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
               this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
               this.dataGridViewX1.Location = new System.Drawing.Point(0, 34);
               this.dataGridViewX1.Name = "dataGridViewX1";
               this.dataGridViewX1.Size = new System.Drawing.Size(981, 670);
               this.dataGridViewX1.TabIndex = 10;
               // 
               // ucBangGia
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.bindingNavigatorEx1);
               this.Controls.Add(this.panelEx1);
               this.Controls.Add(this.dataGridViewX1);
               this.Name = "ucBangGia";
               this.Size = new System.Drawing.Size(981, 734);
               ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEx1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveLastItem;
          private DevComponents.DotNetBar.TextBoxItem bindingNavigatorPositionItem;
          private DevComponents.DotNetBar.ButtonItem bindingNavigatorMovePreviousItem;
          private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveFirstItem;
          private DevComponents.DotNetBar.ButtonItem bindingNavigatorDeleteItem;
          private DevComponents.DotNetBar.LabelItem bindingNavigatorCountItem;
          private DevComponents.DotNetBar.ButtonItem bindingNavigatorAddNewItem;
          private DevComponents.DotNetBar.Controls.BindingNavigatorEx bindingNavigatorEx1;
          private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveNextItem;
          private DevComponents.DotNetBar.PanelEx panelEx1;
          private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
          private System.Windows.Forms.DataGridViewTextBoxColumn NuocSX;
          private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
          private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
          private System.Windows.Forms.DataGridViewTextBoxColumn TenVC;
          private System.Windows.Forms.DataGridViewTextBoxColumn MaVC;
          private System.Windows.Forms.DataGridViewTextBoxColumn STT;
          private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
          private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
     }
}
