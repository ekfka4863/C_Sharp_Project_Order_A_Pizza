using Pizza.Model;
using Pizza.Enums;
using Pizza.PizzaStores;
using Pizza.Biz.Service;

namespace Pizza.Factory
{
    public class BasicPizzaStoreFactory
    {
        // 어떤 피자브랜드에서 피자를 만들지를 결정해주는 ... 피자 브랜드별 피자 가게를 찍어내는 공장 만들기
        // ============================================================

        public BasicPizzaStore createPizzaStore(StoreInfo storeInfo, PizzaInfo orderInfo)
        {
            BasicPizzaStore store = null;

            if (storeInfo.brand.Equals("1"))
                store = new Domino();
            else if (storeInfo.brand.Equals("2"))
                store = new PizzaHut();
            else if (storeInfo.brand.Equals("3"))
                store = new PizzaSchool();
            else if (storeInfo.brand.Equals("4"))
                store = new MrPizza();


            store.makeDough(orderInfo.dough);
            store.putSauce(orderInfo.sauce);
            store.putIngredients(orderInfo.ingredients);
            store.serve();

            return store;
        }
    }
}
