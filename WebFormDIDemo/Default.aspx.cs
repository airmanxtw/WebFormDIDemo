using CSharpFunctionalExtensions;
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
            //Label1.Text = App.Hello();

            Label1.Text = Add(-1, 2).Bind(Doub).Match(s => s.ToString(),f => f);
        }

        public Result<int,string> Add(int a,int b)
        {
            return a>0 && b>0 ? Result.Success<int, string>(a + b) : Result.Failure<int, string>("Invalid input");
        }

        public Result<int,string> Doub(int v)=> Result.Success<int, string>(v * 2);

    }
}