using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

public partial class Tehtava7_ShowFeedback : System.Web.UI.Page {
    private string connStr = ConfigurationManager.ConnectionStrings["mysli1"].ConnectionString;
    private string xml = "";
    protected void Page_Load(object sender, EventArgs e) {
        xml = ConfigurationManager.AppSettings["xml"];
    }

    protected void btnGetFromXml_Click(object sender, EventArgs e) {
        try {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath(xml));
            gvXml.DataSource = ds;
            gvXml.DataBind();
        } catch (Exception ex) {

            lblMessages.Text = ex.Message;
        }
        

    }

    protected void btnGetFromMysql_Click(object sender, EventArgs e) {
        try {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM palaute;", conn);
            conn.Open();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dataTable);

            gvMysql.DataSource = dataTable;
            gvMysql.DataBind();
            lblMessages.Text = string.Format("Haettu {0} palautetta", dataTable.Rows.Count);
        } catch (Exception ex) {
            lblMessages.Text = ex.Message;
        }
    }


    protected void btnGiveFeedback_Click(object sender, EventArgs e) {
        Response.Redirect("GiveFeedback.aspx");
    }
}