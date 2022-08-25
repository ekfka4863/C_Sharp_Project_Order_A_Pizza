using Pizza.Biz.Interface;

namespace Pizza.Biz.Service
{
    public abstract class BasicPizzaStore : IBasicPizzaStore
    {
        public abstract void makeDough(string doughType);

        public abstract void putSauce(string sauceType);

        public abstract void putIngredients(string[] ingredients);

        public abstract void serve();
    }
}
