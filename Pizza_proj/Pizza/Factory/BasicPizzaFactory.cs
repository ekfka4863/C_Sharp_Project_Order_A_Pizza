using Pizza.Model;
using Pizza.Enums;
using Pizza.Products;
using Pizza.Biz.Service;

namespace Pizza.Factory
{
    public class BasicPizzaFactory
    {
        // 어떤 피자를 만들지 공장에서 들어온 값에 따라 결정 ... !
        // ============================================================
        public BasicPizza createPizza(ArgumentContext context)
        {
            BasicPizza pizza = null;

            if (context.orderInfo.menu.Equals("1"))
                pizza = new CheesePizza();
            else if (context.orderInfo.menu.Equals("2"))
                pizza = new ChickenPizza();
            else if (context.orderInfo.menu.Equals("3"))
                pizza = new VeggiePizza();

            // ============================================================
            // Enum 에서 정의한 key값으로 치환
            // menu
            context.orderInfo.menu = Enum.GetName(typeof(PizzaType), Int32.Parse(context.orderInfo.menu));

            // dough 
            context.orderInfo.dough = Enum.GetName(typeof(DoughType), Int32.Parse(context.orderInfo.dough));

            // sauce
            context.orderInfo.sauce = Enum.GetName(typeof(SauceType), Int32.Parse(context.orderInfo.sauce));

            pizza.checkOrder(context);
  
            return pizza;
        }


    }
}
