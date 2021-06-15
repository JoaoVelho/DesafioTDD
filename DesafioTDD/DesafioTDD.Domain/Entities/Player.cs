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

        public static bool Validate(EHands move) {
            if (((int)move > 0) && ((int)move < 4))
                return true;
            else
                return false;
        }
    }
}