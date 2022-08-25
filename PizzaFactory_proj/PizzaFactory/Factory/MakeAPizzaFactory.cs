using PizzaFactory.Enums;
using PizzaFactory.Model;
using PizzaFactory.Products;

namespace PizzaFactory.Factory
{
    public class MakeAPizzaFactory
    {
        // readline으로 받아온 값들을 토대로 ... 여기서 어떤 브랜드의, 어떤 피자를 만들지 validate 하고 결정 ... 그리고 create pizza ... 
        public void createPizza(ArgumentContext context) 
        {
            Console.WriteLine("=================================================================");
            Console.WriteLine("Start to make a pizza!");

            string brand = Enum.GetName(typeof(Brand), Int32.Parse(context.pizzaInfo.brand));
            string menu = Enum.GetName(typeof(PizzaType), Int32.Parse(context.pizzaInfo.menu));
            string dough = Enum.GetName(typeof(DoughType), Int32.Parse(context.pizzaInfo.dough));
            string sauce = Enum.GetName(typeof(SauceType), Int32.Parse(context.pizzaInfo.sauce));
            string[] ingredientList = new string[3];
            //int ctn = ingredients.Length;
            int idx = 0;
            
            foreach (string ingredient in context.pizzaInfo.ingredients)
            {
                ingredientList[idx] = Enum.GetName(typeof(Ingredients), Int32.Parse(ingredient));
                idx++;
            }

            int basePrice = (int)Enum.Parse(typeof(BasePrice), brand);
            int extraCharge = (int)Enum.Parse(typeof(ExtraCharge), ingredientList[0]) + (int)Enum.Parse(typeof(ExtraCharge), ingredientList[1]) + (int)Enum.Parse(typeof(ExtraCharge), ingredientList[2]);
            int totalPrice = basePrice + extraCharge;


            // 들어온 값에 따라 피자 업체 정하기 & 각 메서드에 파라미터 전달
            if (brand == "Domino")
            {
                DominoPizza dominoPizza = new DominoPizza();
                dominoPizza.checkOrder(brand, menu, dough, sauce, ingredientList);
                dominoPizza.makeDough(dough);
                dominoPizza.putSauce(sauce);
                dominoPizza.putIngredients(ingredientList);
                dominoPizza.getPaid(totalPrice);
                dominoPizza.serve();
            }
            else if (brand == "PizzaHut")
            {
                PizzaHutPizza pizzaHutPizza = new PizzaHutPizza();
                pizzaHutPizza.checkOrder(brand, menu, dough, sauce, ingredientList);
                pizzaHutPizza.makeDough(dough);
                pizzaHutPizza.putSauce(sauce);
                pizzaHutPizza.putIngredients(ingredientList);
                pizzaHutPizza.getPaid(totalPrice);
                pizzaHutPizza.serve();
            }
            else if (brand == "PizzaSchool")
            {
                PizzaSchoolPizza pizzaSchoolPizza = new PizzaSchoolPizza();
                pizzaSchoolPizza.checkOrder(brand, menu, dough, sauce, ingredientList);
                pizzaSchoolPizza.makeDough(dough);
                pizzaSchoolPizza.putSauce(sauce);
                pizzaSchoolPizza.putIngredients(ingredientList);
                pizzaSchoolPizza.getPaid(totalPrice);
                pizzaSchoolPizza.serve();
            }
            else if (brand == "MrPizza")
            {
                MrPizzaPizza mrPizzaPizza = new MrPizzaPizza();
                mrPizzaPizza.checkOrder(brand, menu, dough, sauce, ingredientList);
                mrPizzaPizza.makeDough(dough);
                mrPizzaPizza.putSauce(sauce);
                mrPizzaPizza.putIngredients(ingredientList);
                mrPizzaPizza.getPaid(totalPrice);
                mrPizzaPizza.serve();
            }
        }

    }
}
