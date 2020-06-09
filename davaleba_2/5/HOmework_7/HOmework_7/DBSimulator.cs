using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOmework_7
{
    public static class DBSimulator
    {
        public static List<ProductCategory> GetProductCategories()
        {
            List<ProductCategory> ls = new List<ProductCategory>();
            ls.Add(new ProductCategory { Id = 1, Name = "ტანსაცმელი" });
            ls.Add(new ProductCategory { Id = 2, Name = "ფეხსაცმელი" });
            ls.Add(new ProductCategory { Id = 3, Name = "ჰიგიენა&თავის მოვლა" });
            ls.Add(new ProductCategory { Id = 4, Name = "მედიკამენტები" });
            ls.Add(new ProductCategory { Id = 5, Name = "საკონდიტრო" });
            ls.Add(new ProductCategory { Id = 6, Name = "ავეჯი" });
            ls.Add(new ProductCategory { Id = 7, Name = "სასმელები" });
            return ls;
        }
        public static List<Product> GetProducts()
        {
            List<Product> ls = new List<Product>();
            ls.Add(new Product { CategotyID = 1, Name = "ჯინსის ქურთუკი", Code = "000001", Measuring = "ცალი", Price = 100, Valute = "ლარი", Quantity = 1 });
            ls.Add(new Product { CategotyID = 1, Name = "ბავშვის კაბა", Code = "000002", Measuring = "ცალი", Price = 50, Valute = "დოლარი", Quantity = 2 });
            ls.Add(new Product { CategotyID = 2, Name = "ადიდასის კეტასი", Code = "000003", Measuring = "ცალი", Price = 250, Valute = "დოლარი", Quantity = 3 });
            ls.Add(new Product { CategotyID = 2, Name = "პუმას ბოტასი", Code = "000004", Measuring = "ცალი", Price = 250, Valute = "დოლარი", Quantity = 2 });
            ls.Add(new Product { CategotyID = 2, Name = "ნაიკი ბუცი", Code = "000005", Measuring = "ცალი", Price = 3000, Valute = "დოლარი", Quantity = 1 });
            ls.Add(new Product { CategotyID = 3, Name = "სუნამო", Code = "000006", Measuring = "მლ", Price = 300, Valute = "ლარი", Quantity = 3, ExpirationDate = new DateTime(2020,7,31) });
            ls.Add(new Product { CategotyID = 3, Name = "შამპუნი", Code = "000007", Measuring = "მლ", Price = 100, Valute = "ლარი", Quantity = 10, ExpirationDate = new DateTime(2024, 12, 31) });
            ls.Add(new Product { CategotyID = 3, Name = "საპონი", Code = "000008", Measuring = "ცალი", Price = 1.3m, Valute = "ლარი", Quantity = 15, ExpirationDate = new DateTime(2019, 7, 31) });
            ls.Add(new Product { CategotyID = 4, Name = "კორსიზი", Code = "000009", Measuring = "აბი", Price = 0.3m, Valute = "ლარი", Quantity = 10, ExpirationDate = new DateTime(2022, 8, 1) });
            ls.Add(new Product { CategotyID = 4, Name = "წყალბადის ზეჟანგი", Code = "000010", Measuring = "მლ", Price = 2.2m, Valute = "ლარი", Quantity = 100, ExpirationDate = new DateTime(2023, 8, 1) });
            ls.Add(new Product { CategotyID = 4, Name = "სანტავიკი", Code = "000011", Measuring = "ცალი", Price = 0.3m, Valute = "ლარი", Quantity = 150, ExpirationDate = new DateTime(2050, 8, 1) });
            ls.Add(new Product { CategotyID = 5, Name = "მთვრალი ალუბალი", Code = "000012", Measuring = "ცალი", Price = 2.5m, Valute = "ლარი", Quantity = 12, ExpirationDate = new DateTime(2020, 5, 30,23,59,59) });
            ls.Add(new Product { CategotyID = 5, Name = "ნაპოლეონი", Code = "000013", Measuring = "ცალი", Price = 1.5m, Valute = "ლარი", Quantity = 10, ExpirationDate = new DateTime(2020, 5, 31, 23, 59, 59) });
            ls.Add(new Product { CategotyID = 6, Name = "წიგნების კარადა", Code = "000014", Measuring = "ცალი", Price = 1200, Valute = "ლარი", Quantity = 1 });
            ls.Add(new Product { CategotyID = 6, Name = "სკამი", Code = "000015", Measuring = "ცალი", Price = 100, Valute = "ლარი", Quantity = 7 });
            ls.Add(new Product { CategotyID = 7, Name = "ლუდი", Code = "000016", Measuring = "ლიტრი", Price = 2.5m, Valute = "ლარი", Quantity = 10, ExpirationDate = new DateTime(2021, 5, 31, 23, 59, 59) });
            ls.Add(new Product { CategotyID = 7, Name = "რძე", Code = "000017", Measuring = "ლიტრი", Price = 2.5m, Valute = "ლარი", Quantity = 10, ExpirationDate = new DateTime(2020, 5, 31, 23, 59, 59) });
            return ls;
        }
    }
}
