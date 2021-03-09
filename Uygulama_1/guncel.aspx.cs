using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uygulama_1.model;

namespace Uygulama_1
{
    public partial class guncel : System.Web.UI.Page
    {
        public string test;
        veriCONTEXT BAG = new veriCONTEXT();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                int gelenurunid = Convert.ToInt32(Request.QueryString["urunidyolla"]);

                var guncellenecekveri = (from veri in BAG.urunler
                                         where veri.id == gelenurunid
                                         select veri).FirstOrDefault();

                TextBox_urunismi.Text = guncellenecekveri.urun_ismi;
                TextBox_urunmarkasi.Text = guncellenecekveri.markasi;
                TextBox_urunfiyati.Text = guncellenecekveri.fiyat.ToString();

                test = guncellenecekveri.resim_ismi;
                //public string resimismi=gun
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int gelenurunid = Convert.ToInt32(Request.QueryString["urunidyolla"]);

            var yeniverileriyukle = (from veri in BAG.urunler
                                     where veri.id == gelenurunid
                                     select veri).FirstOrDefault();


            yeniverileriyukle.urun_ismi = TextBox_urunismi.Text;
            yeniverileriyukle.markasi = TextBox_urunmarkasi.Text;
            yeniverileriyukle.fiyat = Convert.ToInt32(TextBox_urunfiyati.Text);



            string droptangelen, gelenresim_ismi;
            gelenresim_ismi = FileUpload1.FileName;


            droptangelen = (from katismiicin in BAG.kategoriler
                            where katismiicin.id == gelenurunid
                            select katismiicin.kategori_ismi).FirstOrDefault();

            string resimyoluyla = "img/" + droptangelen + "/" + gelenresim_ismi;

            if (FileUpload1.HasFile == true)
            {
                System.IO.File.Delete(Server.MapPath(yeniverileriyukle.resim_ismi));
                yeniverileriyukle.resim_ismi = resimyoluyla;
                FileUpload1.SaveAs(Server.MapPath(resimyoluyla));
            }

            BAG.SaveChanges();
        }
    }
}