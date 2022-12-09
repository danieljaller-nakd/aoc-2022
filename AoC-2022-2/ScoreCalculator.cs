namespace AoC_2022_2
{
    public static class ScoreCalculator
    {
        private static readonly Dictionary<string, string> moves = new Dictionary<string, string> { { "Rock", "AX" }, { "Paper", "BY" }, { "Scissors", "CZ" } };
        public static int CalculateRound(string a, string b)
        {
            var move1 = (Move)Enum.Parse(typeof(Move), moves.First(x => x.Value.Contains(a)).Key);
            var move2 = (Move)Enum.Parse(typeof(Move), moves.First(x => x.Value.Contains(b)).Key);

            var result = GetResult(move1, move2);

            return (int)move2 + (int)result;
        }

        public static int CalulateRoundPart2(string a, string b)
        {
            var move1 = (Move)Enum.Parse(typeof(Move), moves.First(x => x.Value.Contains(a)).Key);

            var outcome = GetOutcome(b);

            if(outcome == Outcome.Draw)
            {
                return (int)move1 + 3;
            }
            if(outcome == Outcome.Win)
            {
                if (move1 == Move.Scissors) return (int)Move.Rock + 6;
                if (move1 == Move.Paper) return (int)Move.Scissors + 6;
                if (move1 == Move.Rock) return (int)Move.Paper + 6;
            }
            if(outcome == Outcome.Loss)
            {
                if (move1 == Move.Scissors) return (int)Move.Paper;
                if (move1 == Move.Paper) return (int)Move.Rock;
                if (move1 == Move.Rock) return (int)Move.Scissors;
            }
            return default;
        }

        private static Outcome GetOutcome(string b)
        {
            if (b == "X") return Outcome.Loss;
            if (b == "Y") return Outcome.Draw;
            if (b == "Z") return Outcome.Win;

            return default;
        }

        private static Outcome GetResult(Move move1, Move move2)
        {
            if(move1 == move2)
            {
                return Outcome.Draw;
            }
            if((move1 == Move.Rock && move2 == Move.Paper) || (move1 == Move.Paper && move2 == Move.Scissors) || (move1 == Move.Scissors && move2 == Move.Rock))
            {
                return Outcome.Win;
            }

            return Outcome.Loss;
        }
    }

    public enum Move
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3
    }

    public enum Outcome
    {
        Loss = 0,
        Win = 6,
        Draw = 3
    }
}
