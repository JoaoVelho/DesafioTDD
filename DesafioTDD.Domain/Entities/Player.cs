using DesafioTDD.Domain.Enums;

namespace DesafioTDD.Domain.Entities
{
    public class Player
    {
        public Player(EHands move)
        {
            Move = move;
        }

        public EHands Move { get; private set; }
    }
}