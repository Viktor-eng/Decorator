namespace Decorator
{
    class ItalianPizza : BasePizza
    {
        public ItalianPizza() : base("Итальянская пицца")
        { }


        public override int GetCost()
        {
            return 10;
        }
    }
}
