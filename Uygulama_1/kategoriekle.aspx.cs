using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uygulama_1.model;

namespace Uygulama_1
{
    public partial class kategoriekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            veriCONTEXT bag = new veriCONTEXT();
            kategori yenikat = new kategori();

            string eklenecekkat_ismi = TextBox1.Text;
            eklenecekkat_ismi.ToUpper();

            string varmi = (from datalar in bag.kategoriler
                            where datalar.kategori_ismi == eklenecekkat_ismi
                            select datalar.kategori_ismi).FirstOrDefault();
            if (string.IsNullOrEmpty(varmi) == true)
            {
                yenikat.kategori_ismi = eklenecekkat_ismi;
                bag.kategoriler.Add(yenikat);
                bag.SaveChanges();

            }
            else
            {
                Label_uyari.Text = "Dikkat, bu isimde  bir kategori zaten kayıtlı!";

            }
        }
    }
}