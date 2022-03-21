namespace Market
{
    public class Shose : BaseShop, ICategory, IGender, ISeasons
    {
        public Shose(decimal price, int size) : base(price, size)
        {

        }

        //Category
        public string Sport { get; set; }
        public string Classic { get; set; }
        public string NoClassic { get; set; }
        
        //Gender
        public bool IsFemale { get; set; }
        public bool IsBaby { get; set; }
        public bool IsMale { get; set; }
        
        //Season
        public string Season { get; set; }

        public override decimal GetPrice()
        {
            return Price * 495;
        }

        public override int GetSize()
        {
            return Size * 2;
        }

    }
}