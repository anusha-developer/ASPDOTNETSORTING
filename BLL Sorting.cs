using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ASPDOTNETSORTING
{
    public class BLL_Sorting
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter sqladpter = null;
        DataTable dtEmployeeData = null;
        SqlConnection constr = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
        public  DataTable GetEmployeeData()
        {
            using (con = constr)
            {
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sp_Tbl_DBEmployee";
                sqladpter = new SqlDataAdapter(cmd);
                dtEmployeeData = new DataTable();
                sqladpter.Fill(dtEmployeeData);

            }
            return dtEmployeeData;
        }

    }
}