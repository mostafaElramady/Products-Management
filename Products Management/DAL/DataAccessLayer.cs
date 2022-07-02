using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Management.DAL
{
    internal class DataAccessLayer
    {
        SqlConnection SqlConnection;
        public DataAccessLayer ()
        {
            SqlConnection = new SqlConnection("Server=DESKTOP-8952LFC ;Database=DATA01; Integrated Security = true ");
        }

        // open connectio
        public void Open()
        {
            if (SqlConnection.State != ConnectionState.Open)
            {

                SqlConnection.Open();

            }
        }

        public void Close()
        {
            if(SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }
           
        }

        public DataTable SelectData(string Stored_Procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_Procedure;
            sqlcmd.Connection = SqlConnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);


                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void ExcuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = SqlConnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);

            }

            sqlcmd.ExecuteNonQuery();
        }

    }
}
