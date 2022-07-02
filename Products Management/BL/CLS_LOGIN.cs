using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Products_Management.BL
{
    internal class CLS_LOGIN
    {
        public DataTable LOGIN (string USER_ID , String USER_PWD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@USER_ID", SqlDbType.VarChar, 50);
            param[0].Value = USER_ID;
            param[1] = new SqlParameter("@USER_PWD", SqlDbType.VarChar, 50);
            param[1].Value = USER_PWD;

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_LOGIN" , param);
            DAL.Close();
            return Dt;

        }

    }
}
