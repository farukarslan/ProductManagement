using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uygulama_1.model;
namespace Uygulama_1
{
    public partial class listele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            veriCONTEXT bagkur = new veriCONTEXT();
            var kategorileri_oku = (from kat_verileri in bagkur.kategoriler
                                    select kat_verileri).ToList();
            Repeater_kategori.DataSource = kategorileri_oku;
            Repeater_kategori.DataBind();





            int gelenkatid = Convert.ToInt32(Request.QueryString["katidyolla"]);



            if (gelenkatid == 0)
            {
                int ilk_kategorisec = (from katveriler in bagkur.kategoriler
                                       select katveriler.id).FirstOrDefault();


                var ilkurnler = (from veri_urunlerim in bagkur.urunler
                                 where veri_urunlerim.kat_id == ilk_kategorisec
                                 select veri_urunlerim).ToList();


                //tepede kategori ismi gözükmesi için kod
                string ilk_isim_sec = (from katverileri in bagkur.kategoriler
                                       select katverileri.kategori_ismi).FirstOrDefault();
                Label_katismi.Text = ilk_isim_sec;


                Repeater_urunliste.DataSource = ilkurnler;
                Repeater_urunliste.DataBind();
            }

            else
            {
                var urundetay = (from urunincele in bagkur.urunler
                                 where urunincele.kat_id == gelenkatid
                                 select urunincele).ToList();

                //tepede kategori ismi gözükmesi için kod
                string katismial = (from katverileri in bagkur.kategoriler
                                    where katverileri.id == gelenkatid
                                    select katverileri.kategori_ismi).FirstOrDefault();
                Label_katismi.Text = katismial;

                Repeater_urunliste.DataSource = urundetay;
                Repeater_urunliste.DataBind();
            }










        }
    }
}