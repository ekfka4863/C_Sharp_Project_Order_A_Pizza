using Pizza.Biz.Interface;
using Pizza.Model; 

namespace Pizza.Biz.Service
{
    public abstract class BasicPizza: IBasicPizza
    {
        public abstract void checkOrder(ArgumentContext context);  
    }
}
