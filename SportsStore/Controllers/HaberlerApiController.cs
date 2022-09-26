using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HaberlerApiController : ControllerBase
    {
            private StoreDbContext context;
            public HaberlerApiController(StoreDbContext ctx)
            {
                context = ctx;
            }

            [HttpGet]
            public IAsyncEnumerable<NewsEkle> GetNews()
            {
                return context.NewsEkle;
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetNews(int id)
            {
                NewsEkle p = await context.NewsEkle.FindAsync(id);
                if (p == null)
                {
                    return NotFound();
                }
                return Ok(new
                {
                    baslik = p.baslik,
                    haberkategori = p.haberkategori,
                    icerik = p.icerik,
                    ozet = p.ozet,
                    ResimYol = p.ResimYol
                });
            }

            [HttpPost]
            public async Task<IActionResult> SaveNews(NewsBindingTarget target)
            {
                NewsEkle p = target.ToNews();
                await context.NewsEkle.AddAsync(p);
                await context.SaveChangesAsync();
                return Ok(p);
            }

            [HttpPut]
            public async Task UpdateNews(NewsEkle news)
            {
                context.Update(news);
                await context.SaveChangesAsync();
            }

            [HttpDelete("{id}")]
            public async Task DeleteNews(int id)
            {
                context.NewsEkle.Remove(new NewsEkle() { NewsID = id });
                await context.SaveChangesAsync();
            }

            [HttpGet("redirect")]
            public IActionResult Redirect()
            {
                return RedirectToAction(nameof(GetNews), new { Id = 1 });
            }
    }
}

