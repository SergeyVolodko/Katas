namespace Katas.HarryPotterBooks
{
    public class Book
    {
        public string Name { get; private set; }
        public double Price { get { return 8.0; } }

        public const string HarryPotter1 = "Harry Potter 1";
        public const string HarryPotter2 = "Harry Potter 2";
        public const string HarryPotter3 = "Harry Potter 3";
        public const string HarryPotter4 = "Harry Potter 4";
        public const string HarryPotter5 = "Harry Potter 5";

        public Book(string name)
        {
            Name = name;
        }
    }

    public class BasketBuilder
    {
        private Basket basket;

        public BasketBuilder()
        {
            basket = new Basket();
        }

        internal BasketBuilder AddCopyOfFirstBook()
        {
            basket.AddBook(new Book(Book.HarryPotter1));
            return this;
        }

        internal BasketBuilder AddCopyOfSecondBook()
        {
            basket.AddBook(new Book(Book.HarryPotter2));
            return this;
        }
        
        internal BasketBuilder AddCopyOfThirdBook()
        {
            basket.AddBook(new Book(Book.HarryPotter3));
            return this;
        }
        
        internal BasketBuilder AddCopyOfForthBook()
        {
            basket.AddBook(new Book(Book.HarryPotter4));
            return this;
        }
        
        internal BasketBuilder AddCopyOfFifthBook()
        {
            basket.AddBook(new Book(Book.HarryPotter5));
            return this;
        }

        public Basket Build()
        {
            return basket;
        }

        public static implicit operator Basket(BasketBuilder builder)
        {
            return builder.Build();
        }
    }
}