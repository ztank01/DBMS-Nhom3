using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class MyDB
    {
        SqlConnection con = new SqlConnection(Globals.connect);
        public SqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }
        public void OpenConnection()
        {
            if ((con.State == System.Data.ConnectionState.Closed))
            {
                con.Open();
            }
        }
        public void CloseConnection()
        {
            if ((con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
            }
        }

        /*  public Boolean exedata(string cmd)
          {
              openConnection();
              Boolean check = false;
              try
              {
                  SqlCommand sc = new SqlCommand(cmd, con);
                  sc.ExecuteNonQuery();
                  check = true;
              }
              catch (Exception)
              {
                  check = false;
              }
              closeConnection();
              return check;
          }

          public DataTable readdata(string cmd)
          {
              openConnection();
              DataTable da = new DataTable();
              try
              {
                  SqlCommand sc = new SqlCommand(cmd, con);
                  SqlDataAdapter sda = new SqlDataAdapter(sc);
                  sda.Fill(da);
              }
              catch (Exception)
              {
                  da = null;
              }
              closeConnection();
              return da;
          }*/
    }
}
