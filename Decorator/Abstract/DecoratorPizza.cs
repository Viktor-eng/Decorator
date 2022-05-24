namespace Decorator
{
    abstract class DecoratorPizza : BasePizza
    {
        protected BasePizza _pizza;


        public DecoratorPizza(string name, BasePizza pizza) : base(name)
        {
            _pizza = pizza;
        }
    }
}
