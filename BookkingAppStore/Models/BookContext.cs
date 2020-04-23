using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace BookkingAppStore.Models
{
    public class BookContext : DbContext
    {


        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book
            {
                Name = "Мертвые Души",
                Author = "Н.Гоголь",
                Price=220
            });
            db.Books.Add(new Book
            {
                Name = "Отцы и дети",
                Author = "И.Тургенев",
                Price = 180
            });
            db.Books.Add(new Book
            {
                Name = "Чайка",
                Author = "А.Чехов",
                Price = 150
            });
            base.Seed(db);
        }
    }

}