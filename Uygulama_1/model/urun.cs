using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uygulama_1.model
{
    public class urun
    {
        public int id { get; set; }
        public string urun_ismi { get; set; }
        public double fiyat { get; set; }
        public string markasi { get; set; }
        public string resim_ismi { get; set; }
        public int kat_id { get; set; }

    }
}