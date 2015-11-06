using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class WebAPIDemoContextInitializer : DropCreateDatabaseAlways<WebAPIDemoContext>
    {
        protected override void Seed(WebAPIDemoContext context)
        {
            var books = new List<Book>
            {
                new Book { Name = "Rat i mir", Author = "Tolstoj", Price = 19.95m },
                new Book { Name = "Uporiste", Author = "King", Price = 12.48m },
                new Book { Name = "DaVincijev kod", Author = "Braun", Price = 24.17m },
                new Book { Name = "Hari Poter", Author = "Rovling", Price = 12.44m },
                new Book { Name = "Statisticki godisnjak", Author = "GZZJZ", Price = 1.00m },
                new Book { Name = "Tren 1", Author = "Isakovic", Price = 8.21m },
                new Book { Name = "Vreme zla", Author = "Cosic", Price = 11.34m }
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            var order = new Order { Customer = "Milan Milic", OrderDate = new DateTime(2015, 01, 10) };
            context.Orders.Add(order);
            context.SaveChanges();

            var details = new List<OrderDetail>
            {
                new OrderDetail { Book = books[0], Quantity = 1, Order = order },
                new OrderDetail { Book = books[1], Quantity = 2, Order = order },
                new OrderDetail { Book = books[2], Quantity = 3, Order = order }
            };

            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            order = new Order { Customer = "Ivan Despotovic", OrderDate = new DateTime(2015, 10, 11) };
            context.Orders.Add(order);
            context.SaveChanges();

            details = new List<OrderDetail>
            {
                new OrderDetail { Book = books[1], Quantity = 1, Order = order },
                new OrderDetail { Book = books[1], Quantity = 1, Order = order },
                new OrderDetail { Book = books[3], Quantity = 12, Order = order },
                new OrderDetail { Book = books[4], Quantity = 3, Order = order }
            };

            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            order = new Order { Customer = "Rade Lazic", OrderDate = new DateTime(2015, 10, 12) };
            context.Orders.Add(order);
            context.SaveChanges();

            details = new List<OrderDetail>
            {
                new OrderDetail { Book = books[2], Quantity = 1, Order = order },
                new OrderDetail { Book = books[4], Quantity = 1, Order = order },
                new OrderDetail { Book = books[3], Quantity = 1, Order = order },
                new OrderDetail { Book = books[1], Quantity = 3, Order = order }
            };

            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();
        }
    }
}