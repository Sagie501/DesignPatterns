namespace FinalTest.Question1
{
    internal class Lose : GameStatusBase
    {
        public Lose(Context ctx) : base(ctx)
        {
        }

        public override void NextState(ShipStatusBase shipStatusBase)
        {
            System.Console.WriteLine("Game finished you lose");
        }
    }
}