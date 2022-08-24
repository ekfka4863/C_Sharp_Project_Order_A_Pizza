using Pizza.Model;
using Pizza.Biz.Service;
using Pizza.Enums;

namespace Pizza.Products
{
    public class CheesePizza : BasicPizza
    {
        public override void checkOrder(ArgumentContext context)
        {
            Console.WriteLine("Start to bake a cheese pizza!");
            Console.WriteLine("The information of your order is: ");
            Console.WriteLine("==================================");
            Console.WriteLine("A {0} pizza with {1} dough and {2} sauce.", context.orderInfo.menu, context.orderInfo.dough, context.orderInfo.sauce);
            Console.WriteLine("Extra ingredients are: ");

            foreach (var info in context.orderInfo.ingredients)
            {
                Console.WriteLine("- {0}", (Ingredients)Enum.Parse(typeof(Ingredients), info));
            }
            Console.WriteLine("==================================");
        }
    }
}
