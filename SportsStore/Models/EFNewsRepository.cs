using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFNewsRepository : INewsRepository
    {
        private StoreDbContext context;

        public EFNewsRepository(StoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<NewsEkle> Haberler => context.NewsEkle;

        public void CreateNews(NewsEkle n)
        {
            context.Add(n);
            context.SaveChanges();
        }
        public void DeleteNews(NewsEkle n)
        {
            context.Remove(n);
            context.SaveChanges();
        }

        public void SaveNews(NewsEkle n)
        {
            context.SaveChanges();
        }
    }
}
