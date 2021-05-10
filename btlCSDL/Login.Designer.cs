namespace btlCSDL
{
     partial class Login
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
               this.pictureBox3 = new System.Windows.Forms.PictureBox();
               this.pictureBox4 = new System.Windows.Forms.PictureBox();
               this.panel3 = new System.Windows.Forms.Panel();
               this.panel4 = new System.Windows.Forms.Panel();
               this.checkBox2 = new System.Windows.Forms.CheckBox();
               this.btnLogin = new System.Windows.Forms.Button();
               this.lblstatus = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.linkLabel1 = new System.Windows.Forms.LinkLabel();
               this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
               this.txtPass = new DevComponents.DotNetBar.Controls.TextBoxX();
               this.timer1 = new System.Windows.Forms.Timer(this.components);
               this.label3 = new System.Windows.Forms.Label();
               this.cbLoaiTK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
               this.admin = new DevComponents.Editors.ComboItem();
               this.KH = new DevComponents.Editors.ComboItem();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
               this.SuspendLayout();
               // 
               // pictureBox3
               // 
               this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
               this.pictureBox3.Location = new System.Drawing.Point(41, 139);
               this.pictureBox3.Name = "pictureBox3";
               this.pictureBox3.Size = new System.Drawing.Size(47, 40);
               this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox3.TabIndex = 1;
               this.pictureBox3.TabStop = false;
               // 
               // pictureBox4
               // 
               this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
               this.pictureBox4.Location = new System.Drawing.Point(41, 211);
               this.pictureBox4.Name = "pictureBox4";
               this.pictureBox4.Size = new System.Drawing.Size(47, 40);
               this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox4.TabIndex = 2;
               this.pictureBox4.TabStop = false;
               // 
               // panel3
               // 
               this.panel3.BackColor = System.Drawing.Color.White;
               this.panel3.Location = new System.Drawing.Point(41, 185);
               this.panel3.Name = "panel3";
               this.panel3.Size = new System.Drawing.Size(338, 1);
               this.panel3.TabIndex = 5;
               // 
               // panel4
               // 
               this.panel4.BackColor = System.Drawing.Color.White;
               this.panel4.Location = new System.Drawing.Point(41, 257);
               this.panel4.Name = "panel4";
               this.panel4.Size = new System.Drawing.Size(338, 1);
               this.panel4.TabIndex = 6;
               // 
               // checkBox2
               // 
               this.checkBox2.AutoSize = true;
               this.checkBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
               this.checkBox2.Location = new System.Drawing.Point(40, 272);
               this.checkBox2.Name = "checkBox2";
               this.checkBox2.Size = new System.Drawing.Size(109, 20);
               this.checkBox2.TabIndex = 7;
               this.checkBox2.Text = "Hiện mật khẩu";
               this.checkBox2.UseVisualStyleBackColor = true;
               this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
               // 
               // btnLogin
               // 
               this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
               this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.btnLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnLogin.Location = new System.Drawing.Point(40, 314);
               this.btnLogin.Name = "btnLogin";
               this.btnLogin.Size = new System.Drawing.Size(338, 48);
               this.btnLogin.TabIndex = 8;
               this.btnLogin.Text = "Đăng nhập";
               this.btnLogin.UseVisualStyleBackColor = false;
               this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
               // 
               // lblstatus
               // 
               this.lblstatus.AutoSize = true;
               this.lblstatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblstatus.ForeColor = System.Drawing.Color.Red;
               this.lblstatus.Location = new System.Drawing.Point(172, 272);
               this.lblstatus.Name = "lblstatus";
               this.lblstatus.Size = new System.Drawing.Size(0, 16);
               this.lblstatus.TabIndex = 12;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.Red;
               this.label1.Location = new System.Drawing.Point(152, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(118, 25);
               this.label1.TabIndex = 13;
               this.label1.Text = "Đăng Nhập";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
               this.label2.Location = new System.Drawing.Point(259, 374);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(69, 16);
               this.label2.TabIndex = 14;
               this.label2.Text = "New User?";
               // 
               // linkLabel1
               // 
               this.linkLabel1.AutoSize = true;
               this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.linkLabel1.LinkColor = System.Drawing.Color.Aqua;
               this.linkLabel1.Location = new System.Drawing.Point(323, 374);
               this.linkLabel1.Name = "linkLabel1";
               this.linkLabel1.Size = new System.Drawing.Size(55, 16);
               this.linkLabel1.TabIndex = 15;
               this.linkLabel1.TabStop = true;
               this.linkLabel1.Text = "Register";
               this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
               this.linkLabel1.MouseLeave += new System.EventHandler(this.linkLabel1_MouseLeave);
               this.linkLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.linkLabel1_MouseMove);
               // 
               // txtUsername
               // 
               this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
               // 
               // 
               // 
               this.txtUsername.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
               this.txtUsername.Border.Class = "TextBoxBorder";
               this.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.txtUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtUsername.ForeColor = System.Drawing.SystemColors.Menu;
               this.txtUsername.Location = new System.Drawing.Point(93, 152);
               this.txtUsername.Multiline = true;
               this.txtUsername.Name = "txtUsername";
               this.txtUsername.PreventEnterBeep = true;
               this.txtUsername.Size = new System.Drawing.Size(285, 27);
               this.txtUsername.TabIndex = 16;
               this.txtUsername.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtUsername.WatermarkText = "Username";
               // 
               // txtPass
               // 
               this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
               // 
               // 
               // 
               this.txtPass.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
               this.txtPass.Border.Class = "TextBoxBorder";
               this.txtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
               this.txtPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtPass.ForeColor = System.Drawing.SystemColors.Menu;
               this.txtPass.Location = new System.Drawing.Point(94, 228);
               this.txtPass.Name = "txtPass";
               this.txtPass.PreventEnterBeep = true;
               this.txtPass.Size = new System.Drawing.Size(285, 27);
               this.txtPass.TabIndex = 17;
               this.txtPass.UseSystemPasswordChar = true;
               this.txtPass.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtPass.WatermarkText = "Password";
               // 
               // timer1
               // 
               this.timer1.Interval = 40;
               this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
               this.label3.ForeColor = System.Drawing.Color.Red;
               this.label3.Location = new System.Drawing.Point(415, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(16, 16);
               this.label3.TabIndex = 18;
               this.label3.Text = "X";
               this.label3.Click += new System.EventHandler(this.label3_Click);
               // 
               // cbLoaiTK
               // 
               this.cbLoaiTK.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
               this.cbLoaiTK.DisabledForeColor = System.Drawing.Color.White;
               this.cbLoaiTK.DisplayMember = "Text";
               this.cbLoaiTK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
               this.cbLoaiTK.FormattingEnabled = true;
               this.cbLoaiTK.ItemHeight = 18;
               this.cbLoaiTK.Items.AddRange(new object[] {
            this.admin,
            this.KH});
               this.cbLoaiTK.Location = new System.Drawing.Point(40, 80);
               this.cbLoaiTK.Name = "cbLoaiTK";
               this.cbLoaiTK.Size = new System.Drawing.Size(166, 24);
               this.cbLoaiTK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.cbLoaiTK.TabIndex = 19;
               this.cbLoaiTK.WatermarkColor = System.Drawing.SystemColors.ActiveBorder;
               this.cbLoaiTK.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.cbLoaiTK.WatermarkText = "Loại tài khoản";
               // 
               // admin
               // 
               this.admin.FontSize = 12F;
               this.admin.Text = "admin";
               // 
               // KH
               // 
               this.KH.FontSize = 12F;
               this.KH.Text = "Khách hàng";
               // 
               // Login
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
               this.ClientSize = new System.Drawing.Size(430, 423);
               this.Controls.Add(this.cbLoaiTK);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.txtPass);
               this.Controls.Add(this.txtUsername);
               this.Controls.Add(this.linkLabel1);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.lblstatus);
               this.Controls.Add(this.btnLogin);
               this.Controls.Add(this.checkBox2);
               this.Controls.Add(this.panel4);
               this.Controls.Add(this.panel3);
               this.Controls.Add(this.pictureBox4);
               this.Controls.Add(this.pictureBox3);
               this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.KeyPreview = true;
               this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.Name = "Login";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.TopMost = true;
               this.Load += new System.EventHandler(this.Login_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.PictureBox pictureBox3;
          private System.Windows.Forms.PictureBox pictureBox4;
          private System.Windows.Forms.Panel panel3;
          private System.Windows.Forms.Panel panel4;
          private System.Windows.Forms.CheckBox checkBox2;
          private System.Windows.Forms.Button btnLogin;
          private System.Windows.Forms.Label lblstatus;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.LinkLabel linkLabel1;
          private DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
          private DevComponents.DotNetBar.Controls.TextBoxX txtPass;
          private System.Windows.Forms.Timer timer1;
          private System.Windows.Forms.Label label3;
          private DevComponents.DotNetBar.Controls.ComboBoxEx cbLoaiTK;
          private DevComponents.Editors.ComboItem admin;
          private DevComponents.Editors.ComboItem KH;
     }
}