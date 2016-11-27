using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava3_Calendar : System.Web.UI.Page {
    DateTime today;
    protected void Page_Load(object sender, EventArgs e) {
        today = DateTime.Today;      
        lblToday.Text = today.ToString("dd.MM.yyyy");
        if (!IsPostBack) {
            calendar.VisibleDate = today;
        }
    }

    protected void btnNextYear_Click(object sender, EventArgs e) {
        calendar.VisibleDate = calendar.VisibleDate.AddYears(1);
    }

    protected void btnPreviousYear_Click(object sender, EventArgs e) {
        calendar.VisibleDate = calendar.VisibleDate.AddYears(-1);
    }

    protected void calendar_SelectionChanged(object sender, EventArgs e) {
        DateTime selectedDate = calendar.SelectedDate;
        string selectedDateStr = selectedDate.ToString("dd.MM.yyyy");
        selectedDateStr += " vuosi: ";
        selectedDateStr += calendar.SelectedDate.Year;
        lblSelectedDay.Text = selectedDateStr;
        if (selectedDate <= today) {
            DateTime zerotime = new DateTime(1, 1, 1);
            TimeSpan timespan = today - selectedDate;
            int years = (zerotime + timespan).Year - 1;
            int months = (zerotime + timespan).Month - 1;
            int days = (zerotime + timespan).Day - 1;
            lblDifference.Text = years + " vuotta " + months + " kuukautta ja " + days + " päivää.";
        } else {
            lblDifference.Text = "Valitsemasi päivä on tulevaisuudessa";
        }
    }
}