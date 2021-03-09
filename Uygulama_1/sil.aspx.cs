using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uygulama_1.model;

namespace Uygulama_1
{
    public partial class sil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int gelenurunid = Convert.ToInt32(Request.QueryString["urunidyolla"]);

            veriCONTEXT bagkur = new veriCONTEXT();
            var silenecek_kayit = (from sill in bagkur.urunler
                                   where sill.id == gelenurunid
                                   select sill).FirstOrDefault();
            // resmide klasörden sil
            string SilResName = silenecek_kayit.resim_ismi;
            System.IO.File.Delete(Server.MapPath(SilResName));

            bagkur.urunler.Remove(silenecek_kayit);
            bagkur.SaveChanges();
            Response.Redirect("listele.aspx");
        }
    }
}