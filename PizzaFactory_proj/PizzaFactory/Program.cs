using PizzaFactory.Model;
using PizzaFactory.Factory;

namespace PizzaFactory
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            // create a base pizza object 
            PizzaInfo orderInfo = new PizzaInfo();

            Console.WriteLine("Please choose brand: 1.Domino, 2.Pizzahut, 3.PizzaSchool, 4.MrPizza");
            orderInfo.brand = Console.ReadLine();

            if (Int32.TryParse(orderInfo.brand, out int num))
            {
                if (!Enumerable.Range(1, 4).Contains(num))
                {
                    Console.WriteLine("Error::: Please enter number in accordance with the options.");
                    Console.WriteLine("Your order has been rejected. Please try again!");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Error::: Please enter number only in accordance with the options.");
                Console.WriteLine("Your order has been rejected. Please try again!");
                Environment.Exit(0);
            }

            Console.WriteLine("What can I get for you? Please choose menu entering a number.");
            Console.WriteLine("Menu: 1.cheese pizza, 2.chicken pizza, 3.veggie pizza");
            orderInfo.menu = Console.ReadLine();

            Console.WriteLine("Dough: 1.thin, 2.thick");
            orderInfo.dough = Console.ReadLine();

            Console.WriteLine("Sauce: 1.tomato, 2.cream");
            orderInfo.sauce = Console.ReadLine();

            string[] ingredientsArr = new string[3];
            int cnt = ingredientsArr.Length;
            for (int i = 0; i < ingredientsArr.Length; i++)
            {
                Console.WriteLine("Choose {0} more ingredients: 1.onion, 2.pineapple, 3.shrimp, 4.olive, 5.corn, 6.chicken, 7.paprica, 8.mushroom", cnt);
                ingredientsArr[i] = Console.ReadLine();
                cnt--;
            }
            orderInfo.ingredients = ingredientsArr;

            ArgumentContext context = new ArgumentContext()
            {
                pizzaInfo = orderInfo
            };

            //// Factory
            MakeAPizzaFactory factory = new MakeAPizzaFactory();
            factory.createPizza(context);
        }
    }
}