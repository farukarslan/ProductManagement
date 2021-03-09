using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Uygulama_1.model
{
    public class kategori
    {
        public int id { get; set; }
        [Required]
        public string kategori_ismi { get; set; }

        [ForeignKey("kat_id")]
        public List<urun> urunler { get; set; }

    }
}