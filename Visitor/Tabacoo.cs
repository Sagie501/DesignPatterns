namespace Visitor
{
    public class Tabacoo : ProductBase, IVisitable
    {
        public Tabacoo(double price) : base(price)
        {
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"Tabacoo price: {price}";
        }
    }
}