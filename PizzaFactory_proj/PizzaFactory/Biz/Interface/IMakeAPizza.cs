namespace PizzaFactory.Biz.Interface
{
    public interface IMakeAPizza
    {
        //public string brand { get; set; }
        //public string menu { get; set; }
        //public string dough { get; set; }
        //public string sauce { get; set; }
        //public string[] ingredients { get; set; }

        public void checkOrder(string brand, string menu, string dough, string sauce, string[] ingredients);
        public void makeDough(string doughType);
        public void putSauce(string sauceType);
        public void putIngredients(string[] ingredients);
        public void getPaid(int totalPrice);
        public void serve();
    }
}
