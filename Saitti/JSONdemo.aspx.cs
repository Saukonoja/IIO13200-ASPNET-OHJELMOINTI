using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net;
using JAMK.IT;
using Newtonsoft.Json;

public partial class JSONdemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetPerson_Click(object sender, EventArgs e)
    {
        //muutetaan luettu json person olioksi
        try
        {
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTestP.txt");
            JAMK.IT.Person p = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(json);
            ltReslut.Text = string.Format("Löytyi {0} syntynyt {1}", p.name, p.Birthday);
        }
        catch (Exception ex)
        {

            ltReslut.Text = ex.Message;
        }

    }

    protected void btnGetPolitics_Click(object sender, EventArgs e)
    {
        //muutetaan luettu json politicaan oliokokoelmaksi
        try
        {
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTest");
            List<Politician> hallitus = JsonConvert.DeserializeObject<List<Politician>>(json);
            string ret = "<h2>Suomen vankka hallitus</h2><ul>";
            foreach (var ministeri in hallitus)
            {
                ret += "<li>" + ministeri.name + " " + ministeri.Party + "</li>";
            }
            ret += "</ul>";
            ltReslut.Text = ret;
        }
        catch (Exception ex)
        {

            ltReslut.Text = ex.Message;
        }

    }

    protected void btnGet_Click(object sender, EventArgs e)
    {
        //haetaan jsonia ja näytetään se UI:ssa
        try
        {
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTestP.txt");
            ltReslut.Text = json;
        }
        catch (Exception ex)
        {

            ltReslut.Text = ex.Message;
        }

    }

    protected string GetJsonFrom(string url)
    {
        using (WebClient wc = new WebClient())
        {
            var json = wc.DownloadString(url);
            return json;
        }
    }
}