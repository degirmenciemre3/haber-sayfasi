using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models {

    public static class SeedData {

        public static void EnsurePopulated(IApplicationBuilder app) {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate();
            }

            if (!context.Products.Any()) {
                context.Products.AddRange(
                    new Product {
                        Name = "Kayak", Description = "A boat for one person",
                        Category = "Watersports", Price = 275
                    },
                    new Product {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports", Price = 48.95m
                    },
                    new Product {
                        Name = "Soccer Ball",
                        Description = "FIFA-approved size and weight",
                        Category = "Soccer", Price = 19.50m
                    },
                    new Product {
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        Category = "Soccer", Price = 34.95m
                    },
                    new Product {
                        Name = "Stadium",
                        Description = "Flat-packed 35,000-seat stadium",
                        Category = "Soccer", Price = 79500
                    },
                    new Product {
                        Name = "Thinking Cap",
                        Description = "Improve brain efficiency by 75%",
                        Category = "Chess", Price = 16
                    },
                    new Product {
                        Name = "Unsteady Chair",
                        Description = "Secretly give your opponent a disadvantage",
                        Category = "Chess", Price = 29.95m
                    },
                    new Product {
                        Name = "Human Chess Board",
                        Description = "A fun game for the family",
                        Category = "Chess", Price = 75
                    },
                    new Product {
                        Name = "Bling-Bling King",
                        Description = "Gold-plated, diamond-studded King",
                        Category = "Chess", Price = 1200
                    }
                );
                context.SaveChanges();
            }

            if (!context.NewsEkle.Any())
            {
                    context.NewsEkle.AddRange(
                    new NewsEkle
                    {
                        baslik = "Şikayet üzerine durduruldu, üzerinden uyuşturucu çıktı",
                        ozet = "Düzce'de jandarma ekipleri tarafından hakkında şikayet olan ve yakalanan şahsın üzerinden uyuşturucu çıktı.",
                        icerik = "Edinilen bilgiye göre, Düzce'nin Küçükahmetler köyünde Y.O. isimli şahıs, arkadaşı olan A.C.'nin kendisini " +
                        "zorla araca bindirdiğini ve araç içerisinde bulunan tabanca ile tehdit ettiğini şikayetinde bulundu. Şikayet üzerine " +
                        "Jandarma ekipleri A. C. isimli şahsı yakaladı. Şahsın üst aramasında 1 gram metamfetamin olduğu değerlendirilen madde " +
                        "ele geçirildi.",
                        haberkategori = "Uyuşturucu",
                        ResimYol = "/img/haber1.jpg"
                    },
                    new NewsEkle
                    {
                        baslik = "Düzce English Fast'tan lisanslı sporculara İngilizce desteği",
                        ozet = " İngilizce eğitiminde uzmanlaşmış ve marka olan English Fast Düzce Şubesi lisanslı sporculara dil eğitimi verecek.",
                        icerik = "Düzce Gençlik Hizmetleri ve Spor Müdürlüğü ile English Fast Düzce arasında lisanslı sporcuların yurtdışı " +
                        "müsabakalarında yabancı dil eğitiminde destek olmak amacıyla eğitim iş birliği protokolü imzalandı. Spor Hizmetleri " +
                        "Müdürü Gülay Ercan ile Özel Düzce Çocuk Kulübü ve English Fast Düzce Şubesi Kurum Müdürü Fatma Aksu tarafından imzalandı.",
                        haberkategori = "Eğitim",
                        ResimYol = "/img/haber2.jpg"
                    },
                    new NewsEkle
                    {
                        baslik = "Minikler trafik dedektifi oldu",
                        ozet = "Minikler trafik dedektifi olduDÜZCE Düzce'de emniyet ekipleri, ilkokul öğrencilerine trafik kuralları ile " +
                        "ilgili bilgilendirmelerde bulunarak her birini trafik dedektifi yaptı.",
                        icerik = "Düzce İl Emniyet Müdürlüğü Trafik tescil ve Denetleme Şube Müdürlüğü ekipleri il genelinde ilkokul " +
                        "öğrencilerine yönelik Valilik ve belediyenin işbirliğinde Trafik Eğitim Parkuru'nda teorik ve uygulamalı " +
                        "olarak eğitimler vermeye başladı. Namık Kemal İlkokulu öğrencileri parkura gelerek önce teorik olarak eğitim aldı. " +
                        "Akabinde akülü araçlar ile uygulamalı eğitim aldı. Trafikte emniyet kemerinin önemi, kırmızı ışık, yeşil ışık, yaya " +
                        "geçidinde nasıl geçilmeli, trafikte araçların hangi kurallara uyması gerektiği ile ilgili bilgilendirmelerde bulundu. " +
                        "Düzce İHA Büro ekipleri de havadan denetimlerin nasıl yapıldığı ile ilgili de drone ile çocuklara bilgiler verirken, " +
                        "polis ekipleri çocuklara kırmızı düdük dağıttı. Aileleri ile trafikte yolculuk yaptıkları esnada herhangi bir kural hatası " +
                        "gördüklerinde kırmızı düdük çalmaları gerektiğini vurgulayan polis ekipleri, çocukları mini trafik dedektifi yaptı.",
                        haberkategori = "Genel",
                        ResimYol = "/img/haber3.jpg"
                    },
                    new NewsEkle
                    {
                        baslik = "Başkanlığını yaptığı dernekle engellilerin 'gören gözü' oluyor",
                        ozet = "Düzce'de görme engelli 60 yaşındaki Emin Belli, Türkiye Sakatlar " +
                        "Derneği Akçakoca Şubesi Başkanı olarak engellilerin sorunlarına çözüm bulmaya çalışıyor.",
                        icerik = " Düzce'de görme engelli 60 yaşındaki Emin Belli, Türkiye Sakatlar Derneği Akçakoca Şubesi Başkanı olarak engellilerin sorunlarına çözüm bulmaya çalışıyor." +
                        "Başkanlığını üstlendiği dernekle engellilerin adeta 'gören gözü' olan Emin Belli, AA muhabirine, İstanbul'da bir süre esnaflık yaptığını, 24 yıl önce gözlüklerinden kurtulmak için tedavi olmak istediğini söyledi.",
                        haberkategori = "Genel",
                        ResimYol = "/img/haber4.jpg"
                    },
                    new NewsEkle
                    {
                        baslik = "623 öğrenciye kışlık yardımı yapıldı",
                        ozet = "Düzce Müftülüğü ve Diyanet Vakfı Düzce Şubesi ile WEFA Uluslararası İnsani Yardım Organizasyonu iş birliğinde, " +
                        "Düzce'deki 623 ihtiyaç sahibi çocuğa kışlık kıyafet yardımı ulaştırıldı.",
                        icerik = "Düzce Müftülüğü ve Diyanet Vakfı Düzce Şubesi ile WEFA Uluslararası İnsani Yardım Organizasyonu iş birliğinde," +
                        " Düzce'deki 623 ihtiyaç sahibi çocuğa kışlık kıyafet yardımı ulaştırıldı. Düzce'de ki ihtiyaç sahibi çocuklara Müftülük, " +
                        "Diyanet Vakfı Düzce Şubesi ve WEFA Derneği işbirliğiyle mont, bot, çorap, bere, okul çantası ve maskenin de içerisinde " +
                        "bulunduğu yardım paketleri dağıtıldı. Düzce'de eğitim gören 623 öğrencinin yararlandığı yardım paketlerinin dağıtımına, " +
                        "İl Müftüsü ve TDV Düzce Şubesi Yönetim Kurulu Başkanı Rüstem Can'ın yanı sıra, Müftü Yardımcısı Talha Demirkaya, " +
                        "WEFA Uluslararası İnsani Yardım Organizasyonu görevlileri ve TDV Düzce Şube Personeli Yusuf Ziya Tok katıldı.",
                        haberkategori = "Genel",
                        ResimYol = "/img/haber5.jpg"
                    },
                    new NewsEkle
                    {
                        baslik = "Yeni yılın ilk motor denetiminde 17 sürücüye 2 bin TL ceza",
                        ozet = "Düzce'de polis ekipleri motosikletlerin en yoğun olduğu bölgelerde uygulama yaptı.",
                        icerik = "Düzce'de kış mevsimi olmasına rağmen motosikletlerine binerek güneşin tadını çıkartan sürücüler " +
                        "trafik ekiplerine takıldı. Kentin çeşitli noktalarında uygulama yapan Trafik Tescil ve Denetleme Şube Müdürlüğü " +
                        "ekipleri, motosiklet sürücüleri üzerinde uygulama yaptı. Özellikle motosiklet sürücülerinde kask denetimi yapan " +
                        "ekipler, ayrıca sürücülerin ehliyetini ve motosikletlerin evraklarını da kontrol etti.",
                        haberkategori = "Trafik",
                        ResimYol = "/img/haber6.jpg"
                    },
                    new NewsEkle
                    {
                        baslik = "Arı Mucizesi Türkiye'nin dört bir yanına açılmak için kolları sıvadı",
                        ozet = "Arı Mucizesi Türkiye'nin dört bir yanına açılmak için kolları sıvadıDÜZCE " +
                        "Türkiye'de ilk ve tek olarak bir üniversitenin kampüsünde üretimi bulunan Arı Mucizesi, ülkenin dört bir yanında bulunan eczanelere açılmak için kolları sıvadı.",
                        icerik = "DÜZCE Türkiye'de ilk ve tek olarak bir üniversitenin kampüsünde üretimi bulunan Arı Mucizesi, " +
                        "ülkenin dört bir yanında bulunan eczanelere açılmak için kolları sıvadı. Şirket bünyesinde bulunan mümessiller için" +
                        " Düzce'de eğitim kampı düzenlendi.",
                        haberkategori = "Sağlık",
                        ResimYol = "/img/haber7.jpg"
                    },
                    new NewsEkle
                    {
                        baslik = "Muhtarlar bilgilendirildi",
                        ozet = "Yığılca ilçe Tarım ve Orman Müdürlüğü ekipleri 2022 yılında yapılacak çalışmalar ile ilgili köy ve mahalle muhtarlarını bilgilendirdi.",
                        icerik = "Yığılca ilçe Tarım ve Orman Müdürlüğü ekipleri 2022 yılında yapılacak çalışmalar ile ilgili köy ve mahalle muhtarlarını bilgilendirdi.",
                        haberkategori = "Seçim",
                        ResimYol = "/img/haber8.jpg"
                    },
                    new NewsEkle
                    {
                        baslik = "Düzce Atletik bu defa Altınel'i farklı geçti",
                        ozet = "Türkiye Basketbol Federasyonu Gençler Ligi Kızlar kategorisi A grubunda mücadele eden Düzce Atletik 4. hafta mücadelesinde evinde ağırladığı Altınel'in farklı skorla yendi.",
                        icerik = "Türkiye Basketbol Federasyonu Gençler Ligi Kızlar kategorisi A grubunda mücadele eden Düzce Atletik " +
                        "4. hafta mücadelesinde evinde ağırladığı Altınel'in farklı skorla yendi. Basketbol Gençler Ligi Kızlar kategorisi " +
                        "A grubunda mücadelede eden Düzce Atletik basketbol takımı 4. hafta mücadelesinde Altınel'i ağırladı. Kalıcı Konutlar " +
                        "Spor Salonunda oynanan karşılaşmanın ilk saniyelerinden itibaren baskılı oyun oynayan Düzce Atletik peş peşe yakaladığı " +
                        "fırsatları sayıya çevirmesini bildi. Özellikle maçın ilk dakikalarında Altınel'e sayı şansı vermeyen Düzce Atletik maçın " +
                        "ilk periyodunu 24-13 önde tamamladı. İlk yarıyı da 42-13 önde tamamlayan Düzce Atletik, ikinci yarının ilk dakikalarında da " +
                        "etkili oyununu sürdürdü. 3. Periyotta 20 sayı üreterek skoru 62-26 yaptı. Son periyotta ise ataklardan sonuç alamayınca 8 sayı " +
                        "üretebilen Düzce Atletik maçı 70-36 kazandı.",
                        haberkategori = "Spor",
                        ResimYol = "/img/haber9.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
