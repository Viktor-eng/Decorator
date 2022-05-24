namespace Decorator
{
    abstract class BasePizza
    {
        public BasePizza(string name)
        {
            this.Name = name;
        }


        public string Name { get; protected set; }

        public abstract int GetCost();
    }
}
