using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uygulama_1.model;
namespace Uygulama_1
{
    public partial class urunekle : System.Web.UI.Page
    {
        veriCONTEXT bagkur = new veriCONTEXT();
        protected void Page_Load(object sender, EventArgs e)
        {

            var dropdagoster = (from droplar in bagkur.kategoriler
                                select droplar.kategori_ismi).ToList();

            if (!IsPostBack)
            {
                foreach (var item in dropdagoster)
                {
                    DropDownList1.Items.Add(item);
                }
            }


        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile == true)
            {
                string droptangelen = DropDownList1.SelectedValue;

                string gelenresim_ismi = FileUpload1.FileName;

                System.IO.Directory.CreateDirectory(Server.MapPath("img/" + droptangelen));

                FileUpload1.SaveAs(Server.MapPath("img/" + droptangelen + "/" + gelenresim_ismi));
                //resim ismini yoluyla kaydet
                string resimyoluyla = "img/" + droptangelen + "/" + gelenresim_ismi;

                urun yeniurun = new urun();


                int katidbul = (from katveriler in bagkur.kategoriler
                                where katveriler.kategori_ismi == droptangelen
                                select katveriler.id).FirstOrDefault();

                yeniurun.fiyat = Convert.ToDouble(TextBox_urunfiyati.Text);
                yeniurun.markasi = TextBox_urunmarkasi.Text;
                yeniurun.urun_ismi = TextBox_urunismi.Text;
                yeniurun.resim_ismi = resimyoluyla;//eklenecek
                yeniurun.kat_id = katidbul;

                bagkur.urunler.Add(yeniurun);
                bagkur.SaveChanges();
            }
            else
            {
                Label1.Text = "Lütfen kayıttan önce bir resim seçiniz !";
            }

        }
    }
}