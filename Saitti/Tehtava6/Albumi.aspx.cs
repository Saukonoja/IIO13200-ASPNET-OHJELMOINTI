using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Tehtava6_Albumi : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        string album = Request.QueryString["value"];
        albumImage.Attributes["src"] = "/Images/" + album + ".jpg";

        XmlDocument xml = new XmlDocument();
        xml.Load(Server.MapPath("~/App_Data/Kauppa.xml"));

        string info = string.Format("/Records/genre[@name = 'Pop']/record[@ISBN = '{0}']", album);
        string song = string.Format("/Records/genre[@name = 'Pop']/record[@ISBN = '{0}']/song", album);
        XmlNodeList xnlist1 = xml.SelectNodes(info);
        XmlNodeList xnlist2 = xml.SelectNodes(song);

        foreach (XmlNode xn in xnlist1) {
            albumInfo.InnerHtml += " " + xn.Attributes["Artist"].Value;
            albumInfo.InnerHtml += " - " + xn.Attributes["Title"].Value + "<br><br> ";
            albumInfo.InnerHtml += "ISBN: " + xn.Attributes["ISBN"].Value + "<br><br>";
            albumInfo.InnerHtml += "Hinta: " + xn.Attributes["Price"].Value;
        }

        foreach (XmlNode xn in xnlist2) {
            albumSongs.InnerHtml += xn.Attributes["name"].Value + "<br>";
        }
    }
}