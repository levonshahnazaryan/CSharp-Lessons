namespace Market
{
    public class BaseShop
    {
        public decimal Price { get; set; }
        public int Size { get; set; }
        public BaseShop(decimal price, int size)
        {
            Size = size;
            Price = price;
        }

        public virtual decimal GetPrice()
        {
            return Price * 485;
        }

        public virtual int GetSize()
        {
            return Size;
        }
    }
}