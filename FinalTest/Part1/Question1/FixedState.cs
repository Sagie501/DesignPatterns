namespace FinalTest.Question1
{
    internal class FixedState : ShipStatusBase
    {
        public FixedState(Context ctx) : base(ctx)
        {
        }

        public override string getShipStatus()
        {
            return "FIX";
        }
    }
}