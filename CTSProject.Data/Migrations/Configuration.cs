namespace CTSProject.Data.Migrations
{
    using CTSProject.Data.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CTSProject.Data.OnlineShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CTSProject.Data.OnlineShopContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var category1 = new Category { Id = 10, Name = "Книги" };
            var category2 = new Category { Id = 20, Name = "Канцелярия" };
            var category3 = new Category { Id = 33, Name = "Сувениры" };

            var categories = new Category[] { category1, category2, category3 };
            context.Categories.AddOrUpdate(s => s.Id, categories);

            var product1 = new Product
            {
                Id = 1000,
                Category = category1,
                Price = 170,
                Name = "'Горе от ума' А.С.Грибоедов",
                Description = "Книга в стихах",
                Rating = 4.1,
                ReviewsCount = 2
            };
            var product2 = new Product
            {
                Id = 1001,
                Category = category1,
                Price = 170,
                Name = "'Герой нашего времени' М.Ю.Лермонтов",
                Description = "Книга-роман",
                Rating = 4.5,
                ReviewsCount = 1
            };
            var product3 = new Product
            {
                Id = 2000,
                Category = category2,
                Price = 30,
                Name = "Ручка Faber Castell",
                Description = "Синяя шариковая ручка",
                Rating = 4.9,
                ReviewsCount = 2
            };
            var product4 = new Product
            {
                Id = 2001,
                Category = category2,
                Price = 790,
                Name = "Блокнот Moleskine",
                Description = "Блокнот с новыйм дизайном от Maleskin",
                Rating = 4.5,
                ReviewsCount = 3
            };
            var product5 = new Product
            {
                Id = 2003,
                Category = category2,
                Price = 10,
                Name = "Ластик KOH-I-NOOR",
                Description = "Стирательная резинка",
                Rating = 3.2,
                ReviewsCount = 0
            };
            var product6 = new Product
            {
                Id = 3000,
                Category = category3,
                Price = 100,
                Name = "Брелок Эйфелева Башня",
                Description = "Брелокс дизайном Эфйелевой Башни в Париже",
                Rating = 2.7,
                ReviewsCount = 2
            };
            var product7 = new Product
            {
                Id = 3001,
                Category = category3,
                Price = 790,
                Name = "Снежный шар 'Снеговик'",
                Description = "Снежный шар со снегом и снеговиком",
                Rating = 3.5,
                ReviewsCount = 1
            };
            var product8 = new Product
            {
                Id = 3002,
                Category = category3,
                Price = 1500,
                Name = "Часы 'Время кушать'",
                Description = "Дизайнерские часы на кухню с кухонными приборами",
                Rating = 4.6,
                ReviewsCount = 1
            };

            var products = new Product[] { product1, product2, product3, product4, product5, product6, product7, product8 };
            context.Products.AddOrUpdate(s => s.Id, products);

            context.MainPhotos.AddOrUpdate(s => s.Id,
                new MainPhoto
                {
                    Id = 1,
                    Product = product1,
                    URL = "photo/1000.png"
                },
                new MainPhoto
                {
                    Id = 2,
                    Product = product2,
                    URL = "/photo/1001.png"
                },
                new MainPhoto
                {
                    Id = 3,
                    Product = product3,
                    URL = "/photo/2000.png"
                },
                new MainPhoto
                {
                    Id = 4,
                    Product = product4,
                    URL = "/photo/2001.png"
                },
                new MainPhoto
                {
                    Id = 5,
                    Product = product5,
                    URL = "/photo/2003.png"
                },
                new MainPhoto
                {
                    Id = 6,
                    Product = product6,
                    URL = "/photo/3000.png"
                },
                new MainPhoto
                {
                    Id = 7,
                    Product = product7,
                    URL = "/photo/3001.png"
                },
                new MainPhoto
                {
                    Id = 8,
                    Product = product8,
                    URL = "/photo/3002.png"
                }
  );

            context.Opinions.AddOrUpdate(s => s.Id,
                new Opinion
                {
                    Id = 001,
                    Product = product1,
                    Grade = 4,
                    Autor = "none",
                    Text = "Мне не нравится."
                },
                new Opinion
                {
                    Id = 002,
                    Product = product1,
                    Grade = 5,
                    Autor = "olpu",
                    Text = "Отличная книга."
                },
                new Opinion
                {
                    Id = 003,
                    Product = product2,
                    Grade = 4,
                    Autor = "ameli",
                    Text = "Мне нравится."
                },
                new Opinion
                {
                    Id = 004,
                    Product = product3,
                    Grade = 2,
                    Autor = "none",
                    Text = "Плохо."
                },
                new Opinion
                {
                    Id = 005,
                    Product = product3,
                    Grade = 4,
                    Autor = "tinkoff",
                    Text = "Нравится."
                },
                new Opinion
                {
                    Id = 001,
                    Product = product4,
                    Grade = 5,
                    Autor = "uiok",
                    Text = "Хорошо."
                },
                new Opinion
                {
                    Id = 001,
                    Product = product4,
                    Grade = 4,
                    Autor = "none",
                    Text = "Мне не нравится."
                },
                new Opinion
                {
                    Id = 001,
                    Product = product5,
                    Grade = 4,
                    Autor = "fghjd",
                    Text = "Хороший продукт."
                },
                new Opinion
                {
                    Id = 001,
                    Product = product6,
                    Grade = 3,
                    Autor = "smith",
                    Text = "Цена не соответствует качеству."
                },
                new Opinion
                {
                    Id = 001,
                    Product = product6,
                    Grade = 3,
                    Autor = "loki",
                    Text = "Слишком банальный дизайн."
                },
                new Opinion
                {
                    Id = 001,
                    Product = product7,
                    Grade = 4,
                    Autor = "color",
                    Text = "Слишком простой дизайн."
                },
                new Opinion
                {
                    Id = 001,
                    Product = product8,
                    Grade = 4,
                    Autor = "cloud",
                    Text = "Цена не соответствует качеству."
                });
        }
    }
}
