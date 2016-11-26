using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class Tehtava1_Ikkuna : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnCalculate_Click(object sender, EventArgs e) {
        double WinWidth;
        double WinHeight;
        double FrWidth;
        double Margin;
        double WinSqrPrice;
        double AlFramePrice;
        double Workcost;
        double Area;
        double Girth;
        double Price;
        
        try {
            WinWidth = double.Parse(txtWinWidth.Text);
            WinHeight = double.Parse(txtWinHeight.Text);
            FrWidth = double.Parse(txtFrWidth.Text);
            Margin = double.Parse(ConfigurationManager.AppSettings["Margin"]);
            WinSqrPrice = double.Parse(ConfigurationManager.AppSettings["WinSqrPrice"]);
            AlFramePrice = double.Parse(ConfigurationManager.AppSettings["AlFramePrice"]);
            Workcost = double.Parse(ConfigurationManager.AppSettings["Workcost"]);

            Area = WinWidth * WinHeight / 1000000;
            lblAreaResult.Text = Area.ToString("0.##") + " m^2";
            Girth = (((WinWidth * 2) + (WinHeight * 2) + FrWidth * 4) / 1000);
            lblGirthResult.Text = Girth.ToString("0.##") + " m";
            Price = (1 + (Margin / 100)) * ((Area * WinSqrPrice) + (Girth * AlFramePrice) + (Workcost));
            lblPriceResult.Text = Price.ToString("0.##") + " €";
            lblMessage.Text = "Ok";

        } catch (Exception) {

            lblMessage.Text = "Jokin meni väärin. Täytitkö kaikki kentät?";
        }
    }

    
}