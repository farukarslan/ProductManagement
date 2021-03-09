using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uygulama_1.model;

namespace Uygulama_1
{
    public partial class katlistele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            veriCONTEXT bagkur = new veriCONTEXT();
            var tumkatlar = bagkur.kategoriler.ToList(); //Kategorilistesindeki tüm bilgileri alır
            Repeater_katliste.DataSource = tumkatlar;
            Repeater_katliste.DataBind();

            //Repeater_katliste
        }
    }
}