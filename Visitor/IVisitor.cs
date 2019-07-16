namespace Visitor
{
    public interface IVisitor
    {
        double Visit(Liquor liquor);
        double Visit(Tabacoo tabacoo);
        double Visit(Chocolate chocolate);
        double Visit(Perfume perfume);
        double Visit(Shoprent shoprent);
    }
}