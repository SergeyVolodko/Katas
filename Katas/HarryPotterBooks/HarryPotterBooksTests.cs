using FluentAssertions;
using Xunit;
using Xunit.Extensions;

namespace Katas.HarryPotterBooks
{
    public class HarryPotterBooksTests
    {
        [Theory, KatasAutoData]
        public void price_of_empty_basket_is_0(
            Basket sut)
        {
            var pirce = sut.CalculateTotalPrice();
            pirce.Should().Be(0.0);
        }
        
        [Fact]
        public void price_of_one_book_in_basket_is_8()
        {
            Basket sut = new BasketBuilder()
                .AddCopyOfFirstBook();

            var pirce = sut.CalculateTotalPrice();

            pirce.Should().Be(8.0);
        }
        
        [Fact]
        public void price_of_two_same_books_is_16()
        {
            Basket sut = new BasketBuilder()
                .AddCopyOfFirstBook()
                .AddCopyOfFirstBook();
            
            var pirce = sut.CalculateTotalPrice();

            pirce.Should().Be(16.0);
        }
        
        [Fact]
        public void two_different_books_in_basket_gives_5proc_discount()
        {
            Basket sut = new BasketBuilder()
                .AddCopyOfFirstBook()
                .AddCopyOfSecondBook();

            var pirce = sut.CalculateTotalPrice();
            
            pirce.Should().Be(0.95 * 16.0);
        }
        
        [Fact]
        public void three_different_books_in_basket_gives_10proc_discount()
        {
            Basket sut = new BasketBuilder()
                .AddCopyOfFirstBook()
                .AddCopyOfSecondBook()
                .AddCopyOfThirdBook();

            var pirce = sut.CalculateTotalPrice();
            
            pirce.Should().Be(0.90 * 24.0);
        }
        
        [Fact]
        public void four_different_books_in_basket_gives_20proc_discount()
        {
            Basket sut = new BasketBuilder()
                .AddCopyOfFirstBook()
                .AddCopyOfSecondBook()
                .AddCopyOfThirdBook()
                .AddCopyOfForthBook();

            var pirce = sut.CalculateTotalPrice();
            
            pirce.Should().Be(0.80 * 32.0);
        }
        
        [Fact]
        public void five_different_books_in_basket_gives_25proc_discount()
        {
            Basket sut = new BasketBuilder()
                .AddCopyOfFirstBook()
                .AddCopyOfSecondBook()
                .AddCopyOfThirdBook()
                .AddCopyOfForthBook()
                .AddCopyOfFifthBook();

            var pirce = sut.CalculateTotalPrice();
            
            pirce.Should().Be(0.75 * 40.0);
        }
        
        [Fact]
        public void scenario()
        {
            Basket sut = new BasketBuilder()
                .AddCopyOfFirstBook()
                .AddCopyOfFirstBook()
                .AddCopyOfSecondBook()
                .AddCopyOfSecondBook()
                .AddCopyOfThirdBook()
                .AddCopyOfThirdBook()
                .AddCopyOfForthBook()
                .AddCopyOfFifthBook();

            var pirce = sut.CalculateTotalPrice();
            
            pirce.Should().Be(51.60);
        }
    }

}
