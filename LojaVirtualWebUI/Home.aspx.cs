using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LojaVirtualWebUI
{
<<<<<<<< HEAD:LojaVirtualWebUI/Click.Master.cs
    public partial class Click : System.Web.UI.MasterPage
========
    public partial class Home : System.Web.UI.Page
>>>>>>>> f43e6dc46605eda7152999fcab8205894c875ef2:LojaVirtualWebUI/Home.aspx.cs
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["logado"] = true;
        }
    }
}