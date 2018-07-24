using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthorizationDemo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Secure Method
        [PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        protected void btnAuthorizedAction_Click(object sender, EventArgs e)
        {
            // do some secure stuff here.
            // only authenticated users are allow to access this method
        }

        #endregion
    }
}