using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uygulama_1.model;
using System.IO;


namespace Uygulama_1
{
    public partial class katsil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int gelenkatid = Convert.ToInt32(Request.QueryString["katsilidyolla"]);

            veriCONTEXT bagkur = new veriCONTEXT();

            var urundensil = (from urndeki_silinecek_katedoriler in bagkur.urunler
                              where urndeki_silinecek_katedoriler.kat_id == gelenkatid
                              select urndeki_silinecek_katedoriler).ToList();

            foreach (var item in urundensil)
            {
                string SilResName = item.resim_ismi;
                // ürün resimlerini siler
                // resim varmı
                if (System.IO.File.Exists(Server.MapPath(SilResName)))
                {
                    System.IO.File.Delete(Server.MapPath(SilResName)); //varsa sil
                }
                bagkur.urunler.Remove(item);
            }
            bagkur.SaveChanges();
            var katdansilinecek = (from katdansil in bagkur.kategoriler
                                   where katdansil.id == gelenkatid
                                   select katdansil).FirstOrDefault();

            //urun kategori klasörünü siler
            string silkadklasor = "img/" + katdansilinecek.kategori_ismi;

            // kalsör varmı abi 
            if (System.IO.Directory.Exists(Server.MapPath(silkadklasor)))
            {
                System.IO.Directory.Delete(Server.MapPath(silkadklasor)); // varsa sil
            }
            bagkur.kategoriler.Remove(katdansilinecek);
            bagkur.SaveChanges();

            Response.Redirect("katlistele.aspx");
        }
    }
}