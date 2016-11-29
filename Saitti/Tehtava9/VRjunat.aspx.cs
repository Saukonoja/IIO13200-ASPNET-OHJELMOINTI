using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAMK.IT;
using Newtonsoft.Json;
using System.Data;
using System.Net;
using System.Text;

public partial class Tehtava9_VRjunat : System.Web.UI.Page {
    DateTime today = DateTime.Today;
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            try {

                string json = GetJsonFrom("http://rata.digitraffic.fi/api/v1/metadata/stations");
                List<Train> trains = JsonConvert.DeserializeObject<List<Train>>(json);
                var list = new List<string>();
                foreach (var city in trains) {
                    list.Add(city.stationShortCode);
                }
                list.Sort();
                ddlCities.DataSource = list;
                ddlCities.DataBind();
                lblMessages.Text = "";


            } catch (Exception ex) {
                lblMessages.Text = ex.Message;
            }
        }
    }

    protected void btnGetTrains_Click(object sender, EventArgs e) {
        try {

            



            gvTrains.DataSource = getTable();
            gvTrains.DataBind();
            if (gvTrains.Rows.Count == 0) {
                lblMessages.Text = "Ei lähteviä junia";
            } else {
                lblMessages.Text = "Lähteviä junia: " + gvTrains.Rows.Count+ " kpl";
            }
            
        } catch (Exception ex) {
            lblMessages.Text = ex.Message;
        }
    }

    protected string GetJsonFrom(string url) {
        using (WebClient wc = new WebClient()) {
            wc.Encoding = Encoding.UTF8;
            var json = wc.DownloadString(url);
            return json;
        }

        
    }
    public DataTable getTable() {

        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Junan numero", typeof(int)),
                        new DataColumn("Peruutettu", typeof(string)),
                        new DataColumn("Pvm",typeof(string)) });

        string json = GetJsonFrom("http://rata.digitraffic.fi/api/v1/live-trains?station=" + ddlCities.Text);
        List<Train> trains = JsonConvert.DeserializeObject<List<Train>>(json);
        foreach (var item in trains) {
            dt.Rows.Add(item.trainNumber, item.cancelled, DateTime.Now.ToString("MM.dd.yyyy"));
        }

        return dt;
    }
}