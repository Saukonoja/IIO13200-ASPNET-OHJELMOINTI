using System;
using System.Configuration; //webconfigia varten
using System.Data; //ADO.NETin luokkia varten
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HaeTyontekijatIlta : System.Web.UI.Page
{
    string xmlfile;
    protected void Page_Load(object sender, EventArgs e)
    {
        //luetaan web.configista xml-tiedoston nimi
        xmlfile = ConfigurationManager.AppSettings["tiedosto"];
        lblMessage.Text = xmlfile;
    }

    protected void btnGet_Click(object sender, EventArgs e)
    {
        //luetaan xml-tiedostosta työntekijöitten tiedot ja esitetään ne GridViewssa
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();

        ds.ReadXml(Server.MapPath(xmlfile));
        dt = ds.Tables[0];
        dv = dt.DefaultView;

        //datan sitominen ui controlliin
        gvData.DataSource = dv;
        gvData.DataBind();
        lblMessage.Text = string.Format("Found {0} workers", dt.Rows.Count);
    }
}