using PizzaFactory.Biz.Service;

namespace PizzaFactory.Products
{
    public class DominoPizza: MakeAPizza
    {
        public override void checkOrder(string brand, string menu, string dough, string sauce, string[] ingredients)
        {
            Console.WriteLine("The pizza ordered: ");
            Console.WriteLine("-> A {0} {1} pizza with {2} and extra toppings are as follows...", dough, brand, sauce);
            foreach (string ingredient in ingredients)
            {
                Console.WriteLine("- {0}", ingredient);
            }
        }
        public override void makeDough(string doughType)
        {
            Console.WriteLine("Making {0} dough...", doughType);
        }
        public override void putSauce(string sauceType)
        { 
            Console.WriteLine("Putting {0} sauce onto the pizza...", sauceType);
        }
        public override void putIngredients(string[] ingredients)
        {
            Console.WriteLine("Additional toppings are: ");
            foreach (string ingredient in ingredients)
            { 
                Console.WriteLine("- {0}", ingredient);
            }
        }
        public override void getPaid(int totalPrice)
        {
            Console.WriteLine("The total price is: {0}", totalPrice);
        }
        public override void serve()
        {
            Console.WriteLine("Enjoy your meal!");
            Console.WriteLine("=================================================================");
        }
    }
}
