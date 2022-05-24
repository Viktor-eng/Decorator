namespace Decorator
{
    class BulgerianPizza : BasePizza
    {
        public BulgerianPizza() : base("Болгарская пицца")
        { }


        public override int GetCost()
        {
            return 8;
        }
    }
}
