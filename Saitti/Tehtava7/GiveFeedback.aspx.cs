using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Xml;

public partial class Tehtava7_GiveFeedback : System.Web.UI.Page {
    private string connStr = ConfigurationManager.ConnectionStrings["mysli1"].ConnectionString;
    private string xml = "";
    protected void Page_Load(object sender, EventArgs e) {
        xml = ConfigurationManager.AppSettings["xml"];
        if (!IsPostBack) {
            DateTime today = DateTime.Today;

            txtDate.Text = today.ToString("dd.MM.yyyy");
        }
    }

    protected void btnSendXml_Click(object sender, EventArgs e) {
        try {
            XmlDocument XmlDocObj = new XmlDocument();
            XmlDocObj.Load(Server.MapPath(xml));
            XmlNode RootNode = XmlDocObj.SelectSingleNode("palautteet");
            XmlNode feedbackNode = RootNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "palaute", ""));

            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Pvm", "")).InnerText = txtDate.Text;
            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Nimi", "")).InnerText = txtName.Text;
            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Kurssi", "")).InnerText = txtCourse.Text;
            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Opittu", "")).InnerText = txtLearned.Text;
            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Haluan_oppia", "")).InnerText = txtWant.Text;
            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Hyvää", "")).InnerText = txtGood.Text;
            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Parannettavaa", "")).InnerText = txtImprove.Text;
            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Muuta", "")).InnerText = TextBox1.Text;

            XmlDocObj.Save(Server.MapPath(xml));

            txtName.Text = ""; txtCourse.Text = ""; txtLearned.Text = ""; txtWant.Text = ""; txtGood.Text = ""; txtImprove.Text = "";
            TextBox1.Text = "";
        } catch (Exception ex) {

            lblMessages.Text = ex.Message;
        }
    }

    protected void btnSendMysql_Click(object sender, EventArgs e) {
        try {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = "INSERT INTO palaute(pvm, tekija, opintojakso, opittu, haluanoppia, hyvaa, parannettavaa, muuta) VALUES(@pvm, @tekija, @opintojakso, @opittu, @haluanoppia, @hyvaa, @parannettavaa, @muuta)";
            cmd.Parameters.AddWithValue("@pvm", txtDate.Text);
            cmd.Parameters.AddWithValue("@tekija", txtName.Text);
            cmd.Parameters.AddWithValue("@opintojakso", txtCourse.Text);
            cmd.Parameters.AddWithValue("@opittu", txtLearned.Text);
            cmd.Parameters.AddWithValue("@haluanoppia", txtWant.Text);
            cmd.Parameters.AddWithValue("@hyvaa", txtGood.Text);
            cmd.Parameters.AddWithValue("@parannettavaa", txtImprove.Text);
            cmd.Parameters.AddWithValue("@muuta", TextBox1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            txtName.Text = ""; txtCourse.Text = ""; txtLearned.Text = ""; txtWant.Text = ""; txtGood.Text = ""; txtImprove.Text = "";
            TextBox1.Text = "";
        } catch (Exception ex) {

            lblMessages.Text = ex.Message;
        }
    }

    protected void btnFeedbacks_Click(object sender, EventArgs e) {
        Response.Redirect("ShowFeedback.aspx");
    }

    protected void Validator1_ServerValidate(object source, ServerValidateEventArgs args) {
        if (txtDate.Text == "" || txtName.Text == "" || txtCourse.Text == "" || txtLearned.Text == ""
            || txtWant.Text == "" || txtGood.Text == "" || txtImprove.Text == "") {
            Validator1.ErrorMessage = "Täytä muut paitsi 'Muuta' kenttä!";
            args.IsValid = false;
        } else {           
            lblMessages.Text = "Palautteen annettu onnistuneesti!";
            args.IsValid = true;
        }
    }
}