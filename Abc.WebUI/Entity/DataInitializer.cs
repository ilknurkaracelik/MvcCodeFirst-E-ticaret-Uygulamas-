using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.WebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="Kamera", Description="Kamera Ürünleri"},
                new Category(){Name="Cep Telefonu", Description="Cep Telefonu Ürünleri"},
                new Category(){Name="Hard Disc", Description="Hard Disc Ürünleri"},
                new Category(){Name="Bilgisayar", Description="Bilgisayar Ürünleri"},
                new Category(){Name="Televizyon", Description="Televizyon Ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){Name="Canon EOS 2000D ", Description="Canon EOS 2000D + EF-S 18-55mm f/3.5-5.6 DC III Fotoğraf Makinesi (Canon Eurasia", Price=13.599, IsApproved=true, Stock=129, CategoryId=1,IsHome=true},
                new Product(){Name="Nikon Coolpix P1000 ", Description="Nikon Coolpix P1000 Fotoğraf Makinesi İthalatçı Garantili", Price=31.749, IsApproved=true, Stock=35, CategoryId=1,IsHome=true},
                new Product(){Name="Canon EOS 250D", Description="Canon EOS 250D + EF-S 18-55mm f/3.5-5.6 DC III Siyah Fotoğraf Makinesi (Canon Eurasia Garantili)", Price=22.500, IsApproved=true, Stock=67, CategoryId=1,IsHome=true},
                new Product(){Name="Canon EOS 20F ", Description="Canon EOS 2000D + EF-S 18-55mm f/3.5-5.6 DC III Fotoğraf Makinesi (Canon Eurasia", Price=13.599, IsApproved=true, Stock=129, CategoryId=1,IsHome=true},
                new Product(){Name="Canon EOS 200D ", Description="Canon EOS 2000D + EF-S 18-55mm f/3.5-5.6 DC III Fotoğraf Makinesi (Canon Eurasia", Price=13.599, IsApproved=true, Stock=129, CategoryId=1,IsHome=true},

                new Product(){Name="IPhone-7", Description="Iphone 7 Cep Telefonu", Price=13.599, IsApproved=true, Stock=129, CategoryId=2,IsHome=true},
                new Product(){Name="IPhone-8", Description="Iphone 8 Cep Telefonu", Price=13.599, IsApproved=true, Stock=25, CategoryId=2,IsHome=true},
                new Product(){Name="IPhone-9", Description="Iphone 9 Cep Telefonu", Price=13.599, IsApproved=true, Stock=32, CategoryId=2,IsHome=true},
                new Product(){Name="IPhone-10", Description="Iphone 10 Cep Telefonu", Price=13.599, IsApproved=true, Stock=16, CategoryId=2,IsHome=true},
                new Product(){Name="IPhone-11", Description="Iphone 11 Cep Telefonu", Price=13.599, IsApproved=true, Stock=159, CategoryId=2,IsHome=true},

            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }

    }
}