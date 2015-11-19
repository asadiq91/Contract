using DummyBackend.managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminstrationFrontend
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var manager = new AdminstrationManager();
            var customers = manager.GetAllCustomer().Select(x => new CustomerDummy{Mail=x.Mail, Name= x.Firstname+" "+x.Lastname, Address=x.Street+" "+x.HouseNumber+ ","+x.PostalCode+" " +x.City});

            CustomersList.DataSource = customers;
            CustomersList.DataBind();
        }

        private class CustomerDummy
        {
            public string Mail { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            var editLink = (Control)sender;
            GridViewRow row = (GridViewRow)editLink.NamingContainer;
            string mail = row.Cells[1].Text;
           
            Response.Redirect("CreateCustomer.aspx?mail="+mail);
        }
    }
}