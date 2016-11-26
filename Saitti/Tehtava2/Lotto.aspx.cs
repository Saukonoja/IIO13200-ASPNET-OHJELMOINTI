using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




public partial class Tehtava2_Lotto : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnProfit_Click(object sender, EventArgs e) {
        try {
            lblResult.Text = String.Empty;
            BLLotto lotto = new BLLotto();
            for (int i = 0; i < int.Parse(txtRows.Text); i++) {
                lblResult.Text += lotto.draw(ddlLotto.Text) + "<br/>";
            }
        } catch (Exception ex) {

            lblResult.Text = ex.Message;
        }
    }
}