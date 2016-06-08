namespace BPCommunityKataTest
{
    public class Game
    {
        private readonly string WIN = "win";
        private readonly string LOSE = "lose";
        private readonly string STONE = "stone";
        private readonly string SCISSORS = "scissors";
        private readonly string LIZARD = "lizard";
        private readonly string PAPER = "paper";
        private readonly string SPOCK = "spock";
        private readonly string DRAW = "draw";
        public string FirstGame { get; set; }
        public string SecondGame { get; set; }
        public string Play(string firstGame, string secondGame)
        {
            if ((firstGame == STONE && (secondGame == SCISSORS || secondGame == LIZARD))
                || (firstGame == PAPER && (secondGame == STONE || secondGame == SPOCK))
                || (firstGame == SCISSORS && (secondGame == PAPER || secondGame == LIZARD))
                || (firstGame == LIZARD && (secondGame == SPOCK || secondGame == PAPER))
                || (firstGame == SPOCK && (secondGame == SCISSORS || secondGame == STONE)))
                return WIN;
            if ((firstGame == STONE && (secondGame == PAPER || secondGame == SPOCK))
                || (firstGame == PAPER && (secondGame == SCISSORS || secondGame == LIZARD))
                || (firstGame == SCISSORS && (secondGame == STONE || secondGame == SPOCK))
                || (firstGame == LIZARD && (secondGame == STONE || secondGame == SCISSORS))
                || (firstGame == SPOCK && (secondGame == PAPER || secondGame == LIZARD)))
                return LOSE;
            return DRAW;

        }
    }
}