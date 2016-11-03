using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookShop : System.Web.UI.Page
{
    protected static BookShopEntities ctx;
    protected void Page_Load(object sender, EventArgs e)
    {
        //ctx:ään tiedot vain kerrot ja kontrollien alustaminen
        if (!IsPostBack)
        {
            ctx = new BookShopEntities();
            FillControls();
        }
    }
    #region METHODS
    protected void ShowCustomers()
    {
        gvCustomers.DataSource = ctx.Customers.ToList();
        gvCustomers.DataBind();
        int i = ctx.Customers.Count();
        lblMessages.Text = string.Format("Haettu {0} asiakkaan tiedot", i);
    }

    protected void ShowBooks()
    {
        gvBooks.DataSource = ctx.Books.ToList();
        gvBooks.DataBind();
        int i = ctx.Books.Count();
        lblMessages.Text = string.Format("Haettu {0} kirjaa", i);
    }

    protected void FillControls()
    {
        //dropDownList
        //var retval = ctx.Customers;
        //var retval = from c in ctx.Customers orderby c.lastname select c;
        //sama lambda tyylillä
        var retval = ctx.Customers.OrderBy(x => x.lastname);
        ddlCustomers.DataSource = retval.ToList(); ;
        ddlCustomers.DataTextField = "lastname";       
        ddlCustomers.DataValueField = "id";
        ddlCustomers.DataBind();
        // lisätään tyhjä alkio ddl:ään
        ddlCustomers.Items.Insert(0, string.Empty);
    }

    protected void ShowCustomersOrders(Customer cust)
    {
        //näytetään asiakkaan tilaukset ja tilaukseen kuuluvat rivit = kirjat
        ltResult.Text = string.Format("Asiakkaalla {0} {1} on {2} tilausta", cust.firstname, cust.lastname, cust.Orders.Count);
        //loopitetaan asiakkaan tilaukset läpi
        foreach (var o in cust.Orders)
        {
            ltResult.Text += string.Format("<br>- tilaus {0} sisältää {1} kirjaa: {2}", o.oid, o.odate, o.Orderitems.Count());
            //loopitetaan tilauksen tilausrivit 
            foreach (var oi in o.Orderitems)
            {
                ltResult.Text += string.Format("<br>-- kirja {0} {1} kpl {2}", oi.Book.name, oi.Book.author, oi.count);
            }
            
        }
    }

    #endregion
    protected void btnGetCustomers_Click(object sender, EventArgs e)
    {
        ShowCustomers();
    }

    protected void btnGetBooks_Click(object sender, EventArgs e)
    {
        ShowBooks();
    }

    protected void ddlCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCustomers.SelectedIndex > 0)
        {
            //valitun asiakkaan indeksin perusteella 
            int id = int.Parse(ddlCustomers.SelectedValue);
            var ret = from c in ctx.Customers where c.id == id select c;
            Customer cust = ret.FirstOrDefault();
            ShowCustomersOrders(cust);
        }
    }
}