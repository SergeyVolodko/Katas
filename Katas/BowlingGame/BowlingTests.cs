using FluentAssertions;
using Xunit;

namespace Katas.BowlingGame
{
    public class BowlingTests
    {
        [Fact]
        public void gutter_game()
        {
            var game = new BowlingGameBuilder()
                .RollMany(20, 0)
                .Build();

            game.Score.Should().Be(0);
        }

        [Fact]
        public void all_ones()
        {
            var game = new BowlingGameBuilder()
                .RollMany(20, 1)
                .Build();

            game.Score.Should().Be(20);
        }

        [Fact]
        public void one_spare()
        {
            var game = new BowlingGameBuilder()
                .RollSpare()
                .Roll(3)
                .RollMany(17, 0)
                .Build();

            game.Score.Should().Be(16);
        }

        [Fact]
        public void one_strike()
        {
            var game = new BowlingGameBuilder()
                .RollStrike()
                .Roll(3)
                .Roll(4)
                .RollMany(16, 0)
                .Build();

            game.Score.Should().Be(24);
        }
        
        [Fact]
        public void perfect_game()
        {
            var game = new BowlingGameBuilder()
                .RollMany(12, 10)
                .Build();

            game.Score.Should().Be(300);
        }
    }
}
