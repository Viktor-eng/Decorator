namespace Decorator
{
    class TomatoPizza : DecoratorPizza
    {
        public TomatoPizza(BasePizza p) : base(p.Name + ", с томатами", p)
        { }


        public override int GetCost()
        {
            return _pizza.GetCost() + 3;
        }
    }
}
