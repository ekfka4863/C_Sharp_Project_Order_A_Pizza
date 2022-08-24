using Pizza.Model;
using Pizza.Factory;

namespace Pizza
{
    public class Program
    {

        public static void Main(string[] args)
        {
            // PizzaInfo 그리고 StoreInfo 객체 생성
            PizzaInfo orderInfo = new PizzaInfo();
            StoreInfo storeInfo = new StoreInfo();

            // ====================================
            Console.WriteLine("Please choose brand: 1.Domino, 2.Pizzahut, 3.PizzaSchool, 4.MrPizza");
            storeInfo.brand = Console.ReadLine();

            if (Int32.TryParse(storeInfo.brand, out int result))
            {
                // cf. http://daplus.net/c-%EC%88%AB%EC%9E%90%EA%B0%80-%EB%B2%94%EC%9C%84-%EB%82%B4%EC%97%90-%EC%9E%88%EB%8A%94%EC%A7%80-%EC%9A%B0%EC%95%84%ED%95%98%EA%B2%8C-%ED%99%95%EC%9D%B8%ED%95%98%EB%8A%94-%EB%B0%A9%EB%B2%95%EC%9D%80/
                if (Enumerable.Range(1, 4).Contains(result))
                {
                    storeInfo.isOrdered = true;
                }
                else
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
                // return;
            }
            // ====================================

            Console.WriteLine("What can I get for you? Please choose menu entering a number.");
            Console.WriteLine("Menu: 1.cheese pizza, 2.chicken pizza, 3.veggie pizza");
            orderInfo.menu = Console.ReadLine();

            Console.WriteLine("Dough: 1.thin, 2.thick");
            orderInfo.dough = Console.ReadLine();

            Console.WriteLine("Sauce: 1.tomato, 2.cream");
            orderInfo.sauce = Console.ReadLine();

            var ingredientsArr = new string[3];
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
                orderInfo = orderInfo
            };
            

            // Factory
            BasicPizzaFactory customizedPizza = new BasicPizzaFactory();
            customizedPizza.createPizza(context);

            BasicPizzaStoreFactory chosenPizzaStore = new BasicPizzaStoreFactory();
            //chosenPizzaStore.createPizzaStore(storeInfo, context);
            chosenPizzaStore.createPizzaStore(storeInfo, orderInfo);
        }
    }
}