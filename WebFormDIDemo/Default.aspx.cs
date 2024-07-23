using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormDIDemo.Api;

namespace WebFormDIDemo
{
    public partial class _Default : Page
    {
        public  IAppService App { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = App.Hello();
        }
    }
}