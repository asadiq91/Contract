using DummyBackend.managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminstrationFrontend
{
    public partial class CreateCustomer : System.Web.UI.Page
    {
        AdminstrationManager manager;
        protected void Page_Load(object sender, EventArgs e)
        {
            manager = new Assembler();
            var mail = Request.QueryString["mail"];
            if (!string.IsNullOrEmpty(mail))
            {
                Headline.InnerText = "Edit Customer";
                var customer = manager.get
                FirstnameTextBox.TemplateControl
            }

        }
    }
}