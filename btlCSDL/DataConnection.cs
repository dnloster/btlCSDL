﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btlCSDL
{
     public class DataConnection
     {
          private string connetionString = @"Data Source=DESKTOP-LDF85Q4\DUCNGUYEN;Initial Catalog=quanlytiemchung;Integrated Security=True";
          private SqlConnection conn;
          private DataTable dt;
          private SqlCommand cmd;
          public DataConnection()
          {
               try
               {
                    conn = new SqlConnection(connetionString);
               }
               catch (Exception ex)
               {
                    MessageBox.Show("connected failed: " + ex.Message);
               }
          }
          public DataTable SelectData(string sql, List<CustomParameter> lstPara)
          {
               try
               {
                    conn.Open();
                    cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var para in lstPara)
                    {
                         cmd.Parameters.AddWithValue(para.key, para.value);
                    }
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
                    return null;
               }
               finally
               {
                    conn.Close();
               }
          }
          public DataRow Select(string sql)
          {
               try
               {
                    conn.Open();
                    cmd = new SqlCommand(sql, conn);
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt.Rows[0];
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                    return null;
               }
               finally
               {
                    conn.Close();
               }
          }

          public int ExeCute(string sql, List<CustomParameter> lstPara)
          {
               try
               {
                    //cần sửa lại hàm execute như sau
                    //string sql,List<CustomParameter> lstPara là tham số truyền vào 
                    conn.Open();
                    cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var p in lstPara)
                    {
                         cmd.Parameters.AddWithValue(p.key, p.value);
                    }
                    var rs = cmd.ExecuteNonQuery();
                    return (int)rs;
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
                    return -100;
               }
               finally
               {
                    conn.Close();
               }
          }
     }
}