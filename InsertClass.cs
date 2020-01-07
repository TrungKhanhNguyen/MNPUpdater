using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MNPUpdate
{
    public class InsertClass
    {
        public void InsertCELL(DateTime requestDate, string actionType, string msisdn, string route,string recipient, string donor, string blockHolder, DateTime startDate)
        {
            SqlParameter[] p =
           {
               new SqlParameter("@requestDate",SqlDbType.DateTime),
               new SqlParameter("@actionType",SqlDbType.NVarChar,50),
               new SqlParameter("@msisdn",SqlDbType.NVarChar,50),
               new SqlParameter("@route",SqlDbType.NVarChar,10),
               new SqlParameter("@recipient",SqlDbType.NVarChar,10),
               new SqlParameter("@donor",SqlDbType.NVarChar,10),
               new SqlParameter("@blockHolder",SqlDbType.NVarChar,10),
               new SqlParameter("@startDate",SqlDbType.DateTime),
           };
            p[0].Value = requestDate;
            p[1].Value = actionType;
            p[2].Value = msisdn;
            p[3].Value = route;
            p[4].Value = recipient;
            p[5].Value = donor;
            p[6].Value = blockHolder;
            p[7].Value = startDate;

            DB.ExecuteNonQuery("checkExistData", p);
        }
    }
}
