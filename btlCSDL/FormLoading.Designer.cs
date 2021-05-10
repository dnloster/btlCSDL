namespace btlCSDL
{
     partial class FormLoading
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

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoading));
               this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
               this.labelX1 = new DevComponents.DotNetBar.LabelX();
               this.timer1 = new System.Windows.Forms.Timer(this.components);
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // reflectionLabel1
               // 
               // 
               // 
               // 
               this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.reflectionLabel1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.reflectionLabel1.Location = new System.Drawing.Point(1, 2);
               this.reflectionLabel1.Name = "reflectionLabel1";
               this.reflectionLabel1.Size = new System.Drawing.Size(774, 102);
               this.reflectionLabel1.TabIndex = 1;
               this.reflectionLabel1.Text = "<b><font size=\"+6\"><i> </i><font color=\"#B02B2C\">PHẦN MỀM QUẢN LÝ TIÊM CHỦNG</fon" +
    "t></font></b>";
               // 
               // labelX1
               // 
               // 
               // 
               // 
               this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.labelX1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelX1.Location = new System.Drawing.Point(12, 155);
               this.labelX1.Name = "labelX1";
               this.labelX1.Size = new System.Drawing.Size(341, 143);
               this.labelX1.TabIndex = 2;
               this.labelX1.Text = resources.GetString("labelX1.Text");
               // 
               // timer1
               // 
               this.timer1.Enabled = true;
               this.timer1.Interval = 3500;
               this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
               this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
               this.pictureBox1.Location = new System.Drawing.Point(162, 259);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(363, 147);
               this.pictureBox1.TabIndex = 3;
               this.pictureBox1.TabStop = false;
               // 
               // FormLoading
               // 
               this.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.Appearance.Options.UseBackColor = true;
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(776, 404);
               this.Controls.Add(this.labelX1);
               this.Controls.Add(this.reflectionLabel1);
               this.Controls.Add(this.pictureBox1);
               this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "FormLoading";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "FormLoading";
               this.Load += new System.EventHandler(this.FormLoading_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
          private DevComponents.DotNetBar.LabelX labelX1;
          private System.Windows.Forms.Timer timer1;
          private System.Windows.Forms.PictureBox pictureBox1;
     }
}