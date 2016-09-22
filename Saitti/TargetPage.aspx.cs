using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TargetPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string msg = "";
        // VE1 Query String
        msg += "<h3>QueryString</h3>";
        msg += "URLissa välitetty viesti: " + Request.QueryString["Message"];
        msg += "<br/>";
        //RequestQyeryString on kokoelma joka voidaan loopittaa

        foreach (string key in Request.QueryString)
        {
            msg += "URLista löytyy avain: " + key + " ja sen arvo on " + Request.QueryString[key] + "<br/>";
        }
        //VE2 Session
        msg += "<h3>Session</h3>";
        msg += "Sessionista haettu viesti: " + Session["Message"];
       

        //VE3 keksin avulla
        msg += "<h3>Cookie</h3>";
        //tarkistetaan löytyykö haluttua keksiä
        foreach (string kex in Request.Cookies)
        {
            if (kex == "Message")
                msg += "Keksissä lukee " + Request.Cookies[kex].Value;
        }

        //VE4 luetaan edellisen sivun property
        msg += "<h3>Propertyn lukeminen</h3>";
        var previouspage = PreviousPage;
        if (previouspage != null)
        {
            msg += "Ed.sivun Property on " + previouspage.SecretMessage;
        }

        //tulos näkyviin
        mytext.InnerHtml = msg;
    }
}