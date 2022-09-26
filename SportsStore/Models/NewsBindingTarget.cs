using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class NewsBindingTarget
    {
        [Required]
        public string baslik { get; set; }

        [Range(1, 1000)]
        public string ozet { get; set; }

        [Range(1, 1000)]
        public string icerik { get; set; }

        [Range(1, 1000)]
        public string haberkategori { get; set; }

        [Range(1, 1000)]
        public string ResimYol { get; set; }



        public NewsEkle ToNews() => new NewsEkle()
        {
            baslik = this.baslik,
            ozet = this.ozet,
            icerik = this.icerik,
            haberkategori = this.haberkategori,
            ResimYol = this.ResimYol
        };
    }
}
