using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace ASPDOTNETSORTING
{
    public partial class GridSorting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dataBind();
            }
            
        }
        private  void dataBind()
        {
           /*try
            {
                DataTable dt = new DataTable();
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
                SqlDataAdapter sqladptr = new SqlDataAdapter("Sp_Tbl_DBEmployee", con);
                con.Open();
                sqladptr.Fill(dt);
                //gvEmployeeData.DataSource = dt;
                ViewState["dt1"] = dt;
              //  gvEmployeeData.DataBind();
                con.Close();
            }
            catch
            {
             
            }*/


        }

        protected void gvEmployeeData_Sorting(object sender, GridViewSortEventArgs e)
        {
            /*if (ViewState["dt1"] != null) //check view state is null
            {
                DataTable dt = (DataTable)ViewState["dt1"];//store  viewstate data into datatable
                if (dt.Rows.Count > 0)
                {
                    if (Convert.ToString(ViewState["sort"]) == "ASC")
                    {
                        dt.DefaultView.Sort = e.SortExpression + "DESC";
                        ViewState["sort"] = "DESC";

                    }
                    else
                    {
                        dt.DefaultView.Sort = e.SortExpression + "ASC";
                        ViewState["sort"] = "ASC";
                      }
                }
               // DataView dv = new DataView(dt);
                //dv.Sort = e.SortExpression;
              //  gvEmployeeData.DataSource = dt;
                //gvEmployeeData.DataBind();
            }*/
        }
    }
}