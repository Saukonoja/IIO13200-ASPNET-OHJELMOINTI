using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class feedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetFeeds_Click(object sender, EventArgs e)
    {
        string url = @"http://www.iltasanomat.fi/rss/tuoreimmat.xml";
        myDataSource.DataFile = url;
        GetFeeds();
    }

    private void GetFeeds()
    {
        try
        {
            //käytetään XmlDocument luokkaa ja sen metodeja,ominaisuuksia
            XmlDocument doc = new XmlDocument();
            doc = myDataSource.GetXmlDocument();
            //aluksi haetaan kanavan tietoja
            XmlNode node1 = doc.SelectSingleNode("/rss/channel");
            string title = node1["title"].InnerText;
            myDiv.InnerHtml = string.Format("<h1>{0} {1}</h1>", title, DateTime.Now.ToString());
            //haetaan kaikki item-elementit ja loopitetaan läpi
            XmlNodeList nodes = doc.SelectNodes("/rss/channel/item");

            string cat;
            string link;
            string piclink;
            foreach (XmlNode item in nodes) 
            {
                if (item["enclosure"] != null)
                { 
                  piclink = item["enclosure"].GetAttribute("url");
                }else
                {
                    piclink = "http://student.labranet.jamk.fi/~salesa/pic/nope.png";
                }

               
                myDiv.InnerHtml += string.Format("<img src='{0}' style='height:50px'>",piclink);
                cat = item["category"].InnerText;
                title = item["title"].InnerText;
                link = item["link"].InnerText;

                myDiv.InnerHtml += string.Format("{0} <a href='{1}'>{2}</a>", cat, link, title);

                myDiv.InnerHtml += "</br>";
            }
        }
        catch (Exception exz)
        {
            myDiv.InnerHtml = exz.Message;
             }
    }

    protected void btnGetFeedsYle_Click(object sender, EventArgs e)
    {
        string url = @"http://feeds.yle.fi/uutiset/v1/recent.rss?publiserids=YLE_UUTISET.xml";
        myDataSource.DataFile = url;
        GetFeeds();
    }
}