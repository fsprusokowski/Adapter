namespace Adapter.Classes
{
    public class PlugAdapter : TwoPinPlug
    {
        private ThreePinPLug ThreeInputPlug;

        public PlugAdapter(ThreePinPLug plug)
        {
            ThreeInputPlug = plug;
        }

        public void Connect(FemalePLug plug)
        {
            base.Connect(plug);
            ThreeInputPlug.Connected = this.Connected;
        }
    }
}
