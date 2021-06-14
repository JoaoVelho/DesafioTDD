namespace DesafioTDD.Domain.Entities
{
    public class Judge
    {
        public Judge(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        public Player DefineWinner() {
            if (Player1.Move == Player2.Move)
                return null;
            else if (Player1.Move == Enums.EHands.Rock && Player2.Move == Enums.EHands.Scissors)
                return Player1;
            else if (Player1.Move == Enums.EHands.Paper && Player2.Move == Enums.EHands.Rock)
                return Player1;
            else if (Player1.Move == Enums.EHands.Scissors && Player2.Move == Enums.EHands.Paper)
                return Player1;
            else
                return Player2;
        }
    }
}