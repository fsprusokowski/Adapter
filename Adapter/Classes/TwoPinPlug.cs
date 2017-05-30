namespace Adapter.Classes
{
    public class TwoPinPlug
    {
        public bool Connected { get; set; }

        public TwoPinPlug()
        {
            Connected = false;
        }

        public void Connect(FemalePLug input)
        {
            Connected = true;
        }
    }
}
