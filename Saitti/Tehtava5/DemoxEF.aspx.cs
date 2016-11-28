using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava5_DemoxEF : System.Web.UI.Page {
    protected static DemoxOyEntities2 ctx;
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            ctx = new DemoxOyEntities2();
            IniAll();
        }
        
    }
    protected void IniAll() {
        var country = ctx.asiakas.Select(x => new { maa = x.maa }).OrderBy(x => x.maa).Distinct();
        ddlCountries.DataSource = country.ToList();
        ddlCountries.DataTextField = "maa";
        ddlCountries.DataBind();
    }

    protected void btnGetAllCustomers_Click(object sender, EventArgs e) {
        try {
            gvCustomers.DataSource = ctx.asiakas.ToList();
            gvCustomers.DataBind();
            int i = ctx.asiakas.Count();
            lblMessages.Text = string.Format("Haettu {0} asiakkaan tiedot", i);
        } catch (Exception ex) {

            lblMessages.Text = ex.Message;
        }
        
    }


    protected void btnGetFromSelected_Click(object sender, EventArgs e) {
        try {
            string country = ddlCountries.Text;
            var customer = from c in ctx.asiakas where c.maa == country select c;
            gvCustomers.DataSource = customer.ToList();
            gvCustomers.DataBind();
            int i = customer.Count();
            lblMessages.Text = string.Format("Haettu {0} asiakkaan tiedot", i);
        } catch (Exception ex) {

            lblMessages.Text = ex.Message;
        }
        
    }

    protected void btnGetByCountry_Click(object sender, EventArgs e) {
        try {
            lblByCountry.Text = "";
            var country = from x in ctx.asiakas select x.maa;
            List<string> countryList = country.Distinct().ToList();
            List<string> customersList = new List<string>();

            foreach (var country1 in countryList) {
                var customer = from x in ctx.asiakas where x.maa == country1 select x.asnimi;
                customersList = customer.ToList();

                foreach (var customer1 in customersList) {
                    var labelText = lblByCountry.Text;

                    if (!labelText.Contains(country1)) {
                        lblByCountry.Text += "<br><span style='color: green'>" + country1 +
                            "</span><br><br><span style = 'color: blue';>" + customer1.ToString() + "</span><br>";
                    } else {
                        lblByCountry.Text += "<span style='color: blue';>" + customer1.ToString() + "</span><br>";
                    }
                }
            }

            } catch (Exception ex) {

            lblMessages.Text = ex.Message;
        }
    }
}