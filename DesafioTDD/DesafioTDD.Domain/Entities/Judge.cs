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
            else if (Player1.Move == Enums.EHands.Pedra && Player2.Move == Enums.EHands.Tesoura)
                return Player1;
            else if (Player1.Move == Enums.EHands.Papel && Player2.Move == Enums.EHands.Pedra)
                return Player1;
            else if (Player1.Move == Enums.EHands.Tesoura && Player2.Move == Enums.EHands.Papel)
                return Player1;
            else
                return Player2;
        }
    }
}