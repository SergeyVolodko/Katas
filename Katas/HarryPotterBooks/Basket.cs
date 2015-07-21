using System.Collections.Generic;
using System.Linq;

namespace Katas.HarryPotterBooks
{
    public class Basket
    {
        private List<Book> books;
        private string[] bookNames = { Book.HarryPotter1, Book.HarryPotter2, Book.HarryPotter3, Book.HarryPotter4, Book.HarryPotter5 };
        
        public Basket()
        {
            books = new List<Book>();
        }

        public double CalculateTotalPrice()
        {
            var discount = CalculateTotalDiscount();
            
            var price = books.Sum(b => b.Price);

            return price - discount;
        }

        private double CalculateDiscounts(List<Book> allBooks)
        {
            var discount = 0.0;
            var foundBooks = new List<Book>();

            foreach (var name in bookNames)
            {
                var foundBook = allBooks.FirstOrDefault(b => b.Name == name);
                if (foundBook != null)
                {
                    allBooks.Remove(foundBook);
                    foundBooks.Add(foundBook);
                }
            }

            discount = GetDiscount(foundBooks.Count);

            if (allBooks.Count > 0)
            {
                discount += CalculateDiscounts(allBooks);
            }

            return discount;
        }

        private double CalculateTotalDiscount()
        {
            var allBooks = books.Select(b => b).ToList();

            return CalculateDiscounts(allBooks);
        }

        private static double GetDiscount(int differentBooksCount)
        {
            switch (differentBooksCount)
            {
                case 5:
                    return 0.25*40;
                case 4:
                    return 0.2*32;
                case 3:
                    return 0.1*24;
                case 2:
                    return 0.05*16;
            }

            return 0.0;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
    }
}