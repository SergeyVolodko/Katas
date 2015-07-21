namespace Katas.BowlingGame
{
    public class BowlingGameBuilder
    {
        private BowlingGame game;

        public BowlingGameBuilder()
        {
            game = new BowlingGame();
        }

        internal BowlingGameBuilder Roll(int pins)
        {
            game.Roll(pins);
            return this;
        }

        internal BowlingGameBuilder RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                game.Roll(pins);
            }
            return this;
        }

        internal BowlingGameBuilder RollSpare()
        {
            game.Roll(5);
            game.Roll(5);
            return this;
        }

        internal BowlingGameBuilder RollStrike()
        {
            game.Roll(10);
            return this;
        }

        internal BowlingGame Build()
        {
            return game;
        }

        public static implicit operator BowlingGame(BowlingGameBuilder builder)
        {
            return builder.Build();
        }
    }
}