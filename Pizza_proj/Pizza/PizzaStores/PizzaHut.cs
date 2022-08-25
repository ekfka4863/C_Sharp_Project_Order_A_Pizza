using Pizza.Enums;
using Pizza.Biz.Service;

namespace Pizza.PizzaStores
{
    public class PizzaHut : BasicPizzaStore
    {
        public override void makeDough(string doughType)
        {
            Console.WriteLine("A {0} pizza is being baked at the Domino store", doughType);
        }

        public override void putSauce(string sauceType)
        {
            Console.WriteLine("Putting {0} sauce to pizza at the Domino store", sauceType);
        }

        public override void putIngredients(string[] ingredients)
        {
            Console.WriteLine("Putting extra ingredients onto the pizza: ");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine("- {0}", (Ingredients)Enum.Parse(typeof(Ingredients), ingredient));
            }
        }

        public override void serve()
        {
            Console.WriteLine("A pizza is finally served... Enjoy your meal!");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
        }
    }
}
