using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplementoProjetoWeb
{
    public partial class Foto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null)
            {
                var _id = Request["id"].ToString();
                if (_id == "1")
                {
                    lblImagem.Text = "<img src='Fotos/1.jpg'/>";
                }
                else if (_id == "2")
                {
                    lblImagem.Text = "<img src='Fotos/2.jpg'/>";
                }
                else if (_id == "3")
                {
                    lblImagem.Text = "<img src='Fotos/3.jpg'/>";
                }
                else if (_id == "4")
                {
                    lblImagem.Text = "<img src='Fotos/4.jpg'/>";
                }
                else if (_id == "5")
                {
                    lblImagem.Text = "<img src='Fotos/5.jpg'/>";
                }
                else if (_id == "6")
                {
                    lblImagem.Text = "<img src='Fotos/6.jpg'/>";
                }
            }
        }
    }
}