using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace btlCSDL
{
     public class DataConnection
     {
          //Tạo kết nối CSDL
          private static SqlConnection conn;
          private static void openConnection()
          {
               try
               {
                    string connectionString = @"Data Source=DESKTOP-CMO84O2\THAIAN;Initial Catalog=StudentManagement;Integrated Security=True";
                    if (conn == null)
                    {
                         conn = new SqlConnection(connectionString);
                    }
                    if (conn.State != ConnectionState.Open) conn.Open();
               }
               catch (Exception)
               {
                    XtraMessageBox.Show("Kết nối với CSDL thất bại.", "ERROR");
               }
          }
          //Ngắt kết nối
          private static void closeConnection()
          {
               if (conn == null) return;
               else if (conn.State == ConnectionState.Open)
               {
                    conn.Close();
               }
          }
          //Hàm chứa tên thủ tục và danh sách tham số
          private static SqlCommand buildCommand(string procedureName, SqlParameter[] sqlParameters)
          {
               SqlCommand cmd = new SqlCommand
               {
                    CommandText = procedureName,
                    Connection = conn,
                    CommandType = CommandType.StoredProcedure

               };
               foreach (var sqlParameter in sqlParameters)
               {
                    cmd.Parameters.Add(sqlParameter);
               }
               return cmd;
          }
          private static SqlCommand buildIntCommand(string procedureName, SqlParameter[] sqlParameters)
          {
               var cmd = buildCommand(procedureName, sqlParameters);
               cmd.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4, ParameterDirection.ReturnValue,
                    false, 0, 0, string.Empty, DataRowVersion.Default, null));
               return cmd;
          }
          //Hàm thực thi thủ tục và trả về số dòng đã thực hiện(thành công >0)\
          //Hàm này sử dụng khi thêm và xoá
          public static int ExecuteNonQuery(string proceduceName, SqlParameter[] parameters)
          {
               openConnection();
               var cmd = buildCommand(proceduceName, parameters);
               cmd.CommandType = CommandType.StoredProcedure;
               var rec = cmd.ExecuteNonQuery();
               closeConnection();
               return rec;
          }
          //Hàm thuc thi thủ tục và trả về 1 datatable
          public static DataTable ExecuteQuery(string proceduceName, SqlParameter[] parameters)
          {
               openConnection();
               using (var sqlDa = new SqlDataAdapter(buildCommand(proceduceName, parameters)))
               {
                    using (var ds = new DataSet())
                    {
                         sqlDa.Fill(ds);
                         closeConnection();
                         return ds.Tables[0];
                    }
               }
          }
          public static int ExecuteIntCommand(string procedureName, SqlParameter[] parameters)
          {
               try
               {
                    openConnection();
                    var cmd = buildIntCommand(procedureName, parameters);
                    cmd.ExecuteNonQuery();
                    var rec = (int)cmd.Parameters["ReturnValue"].Value;
                    closeConnection();
                    return rec;
               }
               catch (Exception)
               {
                    XtraMessageBox.Show("Không thể thực thi.", "LỖI");
                    return -1;
               }
          }
     }
}
