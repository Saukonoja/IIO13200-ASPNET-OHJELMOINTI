using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cassandra;
using System.Data;


public partial class CassieConnector : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {

        }
        
    }

    protected ISession connect() {
        Cluster cluster = Cluster.Builder().AddContactPoint("84.251.189.202").WithPort(9042).Build();
        ISession session = cluster.Connect("test");
        return session;
    }

    protected void insert(ISession session, string firstname, string lastname, int age) {
        session.Execute("insert into users (firstname, lastname, age) values ('" + firstname + "','" + lastname +"'," + age + " );");
    }

    protected void update(ISession session, string firstname, string lastname, int age) {
        session.Execute("update users set firstname= '" + firstname + "' , lastname='" + lastname + "', age='" + age + "' where lastname='"+lastname+"';");
    }

    protected Row select(ISession session, string lastname) {
        Row result = session.Execute("select * from users where lastname='" + lastname + "';").First();
        return result;
    }

    protected void delete(ISession session, string lastname) {
        session.Execute("delete from users where lastname ='" + lastname + "';");
    }

    protected void selectAll(ISession session) {
        var results = session.Execute("select * from users;");


    }

    protected void btnInsert_Click(object sender, EventArgs e) {
        string firstname = txtFirstname.Text;
        string lastname = txtLastname.Text;
        int age = int.Parse(txtAge.Text);
        insert(connect(), firstname, lastname, age);
    }

    protected void btnGetAll_Click(object sender, EventArgs e) {
        ISession session = connect();
        DataTable dt = new DataTable();
        dt.Columns.Add("lastname");
        dt.Columns.Add("firstname");
        dt.Columns.Add("age");
        var results = session.Execute("select * from users;");
        foreach (var row in results) {
            dt.Rows.Add(row.GetValue<string>(0), row.GetValue<int>(1), row.GetValue<string>(2));
        }
        gvUsers.DataSource = dt;
        gvUsers.DataBind();
    }

    protected void btnDelete_Click(object sender, EventArgs e) {
        string lastname = txtLastname.Text;
        delete(connect(), lastname);
    }

    protected void btnUpdate_Click(object sender, EventArgs e) {
        string firstname = txtFirstname.Text;
        string lastname = txtLastname.Text;
        int age = int.Parse(txtAge.Text);
        update(connect(), firstname, lastname, age);
    }
}