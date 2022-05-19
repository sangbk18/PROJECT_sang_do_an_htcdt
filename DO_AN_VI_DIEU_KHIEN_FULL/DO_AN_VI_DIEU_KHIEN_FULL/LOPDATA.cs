using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DO_AN_VI_DIEU_KHIEN_FULL
{
    public class LOPDATA
    {
        public string sql_link = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\C#_PRATICE\DO_AN_VI_DIEU_KHIEN_FULL\DO_AN_VI_DIEU_KHIEN_FULL\bin\Debug\DATABASE.mdb";
        public OleDbConnection sql_connect = null;
        public void connect_data()
        {
            if(sql_connect == null)
            {
                sql_connect = new OleDbConnection(sql_link);
            }    
            if(sql_connect.State == System.Data.ConnectionState.Closed)
            {
                sql_connect.Open();
            }    
        }
        public void close_data()
        {
            if (sql_connect != null && sql_connect.State == System.Data.ConnectionState.Open)
            {
                sql_connect.Close();
            }
        }
    }
}
