using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheSmallGame;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {      
        UserName.Text = User.Identity.IsAuthenticated ? User.Identity.Name : "not logged";
    }
}