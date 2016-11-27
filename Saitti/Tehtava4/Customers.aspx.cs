using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using JAMK.IT;

public partial class Tehtava4_Customers : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        try {
            gvCustomers2.DataSource = DBDemoxOy.GetDataReal().DefaultView;
            gvCustomers2.DataBind();
            
        } catch (Exception ex) {
            
        }
    }
}