using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Web.UI.HtmlControls;


public partial class Tehtava8_Finnkino : System.Web.UI.Page {
    XmlDocument xml = new XmlDocument();
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            try {
                xml.Load("http://www.finnkino.fi/xml/TheatreAreas/");
                XmlNodeList nodes = xml.SelectNodes("/TheatreAreas/TheatreArea");
                foreach (XmlNode node in nodes) {
                    lbTheaters.Items.Add(new ListItem(node["Name"].InnerText, node["ID"].InnerText));
                }
            } catch (Exception ex) {

                lblMessages.Text = ex.Message;
            }  
        }
    }


    protected void lbTheaters_SelectedIndexChanged(object sender, EventArgs e) {
        lblMessages.Text = "Elokuvateatteri " + lbTheaters.SelectedItem.Text + " valittu";
        GetImages();

    }

    protected void GetImages() {
        string areaID = lbTheaters.SelectedValue;
        xml.Load("http://www.finnkino.fi/xml/Schedule/?area=" + areaID + "&dt=" + DateTime.Today.ToString("dd.MM.yyyy"));
        XmlNodeList nodes = xml.SelectNodes("/Schedule/Shows/Show/Images/EventLargeImagePortrait");
        foreach (XmlNode node in nodes) {
            HtmlGenericControl movieDiv = (HtmlGenericControl)FindControl("movies");
            HtmlGenericControl img = new HtmlGenericControl("img");
            img.Attributes["src"] = node.InnerText;
            movieDiv.Controls.Add(img);
        }
    }
}