using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface INewsRepository
    {
        IQueryable<NewsEkle> Haberler { get; }

        void SaveNews(NewsEkle n);
        void CreateNews(NewsEkle n);
        void DeleteNews(NewsEkle n);
    }
}
