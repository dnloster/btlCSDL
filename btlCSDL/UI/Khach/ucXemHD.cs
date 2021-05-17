using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace btlCSDL.UI.Khach
{
     public partial class ucXemHD : DevExpress.DXperience.Demos.TutorialControlBase //DevExpress.XtraEditors.XtraUserControl
     {
          public ucXemHD()
          {
               InitializeComponent();
          }
          SqlCommand cmd;
          DataConnection dc = new DataConnection();
          private void ucXemHD_Load(object sender, EventArgs e)
          {
               SqlConnection con = dc.getConnect();
               con.Open();
               cmd = new SqlCommand("XemHoaDon", con);
               cmd.CommandType = CommandType.StoredProcedure;
               
               cmd.Parameters.AddWithValue("@makh", SqlDbType.VarChar).Value = "KH010";
               
               cmd.ExecuteNonQuery();
               con.Close();
          }
     }
}
