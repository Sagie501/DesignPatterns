namespace FinalTest.Question1
{
    public class Win : GameStatusBase
    {
        public Win(Context ctx) : base(ctx)
        {
        }

        public override void NextState(ShipStatusBase shipStatusBase)
        {
            System.Console.WriteLine("Game finish you win");
        }
    }
}