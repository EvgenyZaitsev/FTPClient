namespace HW_5_LINQ_to_XML
{
    public class CityWithEfficiency
    {
        public string City { get; set; }
        public double AverageSum { get; set; }
        public double AverageIntencity { get; set; }
        public CityWithEfficiency(string city, double avSum, double avInt)
        {
            this.City = city;
            this.AverageSum = avSum;
            this.AverageIntencity = avInt;
        }
        public override string ToString()
        {
            return $"{City.PadRight(15)}  Average sum is {AverageSum.ToString("0.00").PadRight(10)}, Average Intencity is {AverageIntencity.ToString("0.00")}";
        }
    }
}
