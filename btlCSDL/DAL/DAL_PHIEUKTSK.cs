using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btlCSDL.DTO;
using System.Data;
using System.Data.SqlClient;
using static btlCSDL.DataConnection;

namespace btlCSDL.DAL
{
     class DAL_PHIEUKTSK
     {
          DataConnection dc;
          SqlDataAdapter da;
          SqlCommand cmd;
          public DAL_PHIEUKTSK()
          {
               dc = new DataConnection();
          }
          public DataTable getAllPhieuKTSK()
          {
               string sql = "select * from PHIEUKTSK";
               SqlConnection con = dc.getConnect();
               da = new SqlDataAdapter(sql, con);
               con.Open();
               DataTable dt = new DataTable();
               da.Fill(dt);
               con.Close();
               return dt;
          }
          public bool Add_PHIEUKTSK(DTO_PHIEUKTSK ktsk)
          {
               try
               {
                    SqlConnection con = dc.getConnect();
                    con.Open();
                    cmd = new SqlCommand("ADD_PHIEUKTSK", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MAPHIEUKTSK", SqlDbType.VarChar).Value = ktsk.MAPHIEUKTSK;
                    cmd.Parameters.AddWithValue("@MAKH", SqlDbType.VarChar).Value = ktsk.MAKH;
                    cmd.Parameters.AddWithValue("@MABS", SqlDbType.VarChar).Value = ktsk.MABS;
                    cmd.Parameters.AddWithValue("@NGAYKT", SqlDbType.VarChar).Value = ktsk.NGAYKT;
                    cmd.Parameters.AddWithValue("@NOIDUNG", SqlDbType.VarChar).Value = ktsk.NOIDUNG;
                    cmd.ExecuteNonQuery();
                    con.Close();
               }
               catch(Exception ex)
               {
                    return false;
               }
               return true;
          }
          public bool Update_PHIEUKTSK(DTO_PHIEUKTSK ktsk)
          {
               SqlConnection con = dc.getConnect();
               //string sql = "UPDATE PHIEUKTSK SET MAKH = @MAKH, MABS = @MABS, NOIDUNG = @NOIDUNG, NGAYKT = @NGAYKT, MAPHIEUKTSK = @MAPHIEUKTSK";
               try
               {
                    con.Open();
                    //cmd = new SqlCommand(sql, con);
                    cmd = new SqlCommand("UPDATE_PHIEUKTSK", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MAPHIEUKTSK", SqlDbType.VarChar).Value = ktsk.MAPHIEUKTSK;
                    cmd.Parameters.AddWithValue("@MAKH", SqlDbType.VarChar).Value = ktsk.MAKH;
                    cmd.Parameters.AddWithValue("@MABS", SqlDbType.VarChar).Value = ktsk.MABS   ;
                    cmd.Parameters.AddWithValue("@NGAYKT", SqlDbType.VarChar).Value = ktsk.NGAYKT;
                    cmd.Parameters.AddWithValue("@NOIDUNG", SqlDbType.VarChar).Value = ktsk.NOIDUNG;
                    cmd.ExecuteNonQuery();
                    con.Close();
               }
               catch(Exception ex)
               {
                    return false;
               }
               return true;
          }
     }
}
