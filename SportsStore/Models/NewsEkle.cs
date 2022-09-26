using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class NewsEkle
    {
        [Key]
        public int NewsID { get; set; }
        public string baslik { get; set; }
        public string ozet { get; set; }
        public string icerik { get; set; }
        public string haberkategori { get; set; }
        
        //public IFormFile Resim { get; set; }
        public string ResimYol { get; set; } //img/fotoğrafismi
        
    }
}
