namespace Decorator
{
    class CheesePizza : DecoratorPizza
    {
        public CheesePizza(BasePizza p) : base(p.Name + ", с сыром", p)
        { }


        public override int GetCost()
        {
            return _pizza.GetCost() + 5;
        }
    }
}
