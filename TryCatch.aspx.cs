using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDOTNETSORTING
{
    public partial class TryCatch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            try
            {
                decimal expectedDecimal = decimal.Parse(txtDecimal.Text);
                message = "your decimal is:" + expectedDecimal;
                lblMessage.Visible = true;
            }
            catch(Exception ex)
            {
                message = "something went wrong" + ex.Message;
            }
            lblMessage.Text = message;
            lblMessage.Visible = true;
        }
    }
}