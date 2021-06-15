namespace DesafioDojo.Domain.Entities
{
    public class Light
    {
        public bool On { get; private set; } = false;

        public void Switch() {
            if (On == true)
                On = false;
            else
                On = true;
        }

        public override string ToString() {
            return On == true ? "on" : "off";
        }
    }
}