using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Mysql : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetCities_Click(object sender, EventArgs e)
    {
        try
        {
            string cs = "server=mysql.labranet.jamk.fi;database=salesa;user=salesa;password=fyEfchdior3MZlrcjz6U27L0aiNolowl;";

            DataTable dt = JAMK.ICT.Data.DBPlacebo.GetCitysFromMysql(cs);
            gvCities.DataSource = dt;
            gvCities.DataBind();
        }
        catch ( Exception ex)
        {

            lblMessages.Text = ex.Message;
        }
        
        
    }
}