using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Uygulama_1.model
{
    public class veriCONTEXT:DbContext
    {
        public veriCONTEXT():base("sqlim")
        {

        }
        public DbSet<kategori> kategoriler { get; set; }
        public DbSet<urun> urunler { get; set; }

    }
}