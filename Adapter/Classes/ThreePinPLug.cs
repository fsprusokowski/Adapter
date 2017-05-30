namespace Adapter.Classes
{
    public class ThreePinPLug
    {
        public bool Connected { get; set; }

        public ThreePinPLug()
        {
            Connected = false;
        }

        public void Connect(FemalePLug input)
        {
           Connected = (input == FemalePLug.ThreeInputs)? true : false;
        }
    }
}
