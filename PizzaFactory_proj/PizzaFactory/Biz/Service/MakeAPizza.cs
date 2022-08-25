using PizzaFactory.Biz.Interface;

namespace PizzaFactory.Biz.Service
{
    public abstract class MakeAPizza: IMakeAPizza
    {
        //public string brand { get; set; }
        //public string menu { get; set; }
        //public string dough { get; set; }
        //public string sauce { get; set; }
        //public string[] ingredients { get; set; }

        public abstract void checkOrder(string brand, string menu, string dough, string sauce, string[] ingredients);
        public abstract void makeDough(string doughType);
        public abstract void putSauce(string sauceType);
        public abstract void putIngredients(string[] ingredients);
        public abstract void getPaid(int totalPrice);
        public abstract void serve();
    }
}
