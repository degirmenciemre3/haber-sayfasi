using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class news
    {
        public int newsId { get; set; }
        public string baslik { get; set; }
        public string ozet { get; set; }
        public string icerik { get; set; }
        public string haberkategori { get; set; }
        public string ResimYol { get; set; }
    }
}
