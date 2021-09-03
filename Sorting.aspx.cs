using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDOTNETSORTING
{
    
    public partial class Sorting : System.Web.UI.Page
    {
        BLL_Sorting objsorting = new BLL_Sorting();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindEmployeeData();
            }

        }
        private void BindEmployeeData( string sortexpression=null)
        {
            try
            {

                DataTable dtEmployeeData = null;
                dtEmployeeData = objsorting.GetEmployeeData();

                if (dtEmployeeData.Rows.Count > 0)
                {
                    if (sortexpression != null)
                    {
                        DataView dv = dtEmployeeData.AsDataView();
                        sortDirection = sortDirection == "ASC" ? "DESC" : "ASC";
                        dv.Sort = sortexpression + "" + sortDirection;
                        gvEmployeeData.DataSource = dv;
                    }
                    else
                    {
                        gvEmployeeData.DataSource = dtEmployeeData;
                    }
                 }
                else
                {
                    lblMessage.Text = "No data found";
                }
                gvEmployeeData.DataBind();
            }
            catch(Exception e)
            {
                lblMessage.Text = e.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            

        }

        protected void OnSorting(object sender, GridViewSortEventArgs e)
        {
            BindEmployeeData(e.SortExpression);
        }
        public  string sortDirection
        {
            get { return ViewState["sortDirection"] != null ? ViewState["sortDirection"].ToString() : "ASC"; }
            set { ViewState["sortDirection"] = value; }
           
        }
    }
}
