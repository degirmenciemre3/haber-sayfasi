﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models.ViewModels
{
    public class NewsListViewModel
    {
        public IEnumerable<NewsEkle> News { get; set; }
    }
}
