using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PotentialInjectionRisk : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
        if (!IsPostBack) {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }
  }



    protected void btnCommit_Click(object sender, EventArgs e) {
        string nimi = txtName.Text;
        string kommentti = txtComment.Text;
        string pvm = txtDate.Text;
        //siis ei näin
        string sql = string.Format("INSERT INTO comment (name, comment, date) VALUES ('{0}', '{1}', '{2}');", nimi, kommentti, pvm);
        //käytetään parametrisoitua kyselyä
        //string sql = string.Format("INSERT INTO comment (name, comment, date) VALUES (@name, @comment, @date);");
        try {
            MySqlConnection conn = new MySqlConnection(myComments.ConnectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@name", nimi);
            //cmd.Parameters.AddWithValue("@comment", kommentti);
            //cmd.Parameters.AddWithValue("@date", pvm);
            int lkm = cmd.ExecuteNonQuery();
            lblMessages.Text = string.Format("Lisätty {0} kommenttia onnistuneesti tietokantaan", lkm);
            gvComments.DataBind(); 
        } catch (Exception ex) {

            lblMessages.Text = ex.Message;
        }
    }
}