namespace hww
{
    public class CountryModel
    {
       
            public string Country { get; set; }
            public string Capital { get; set; }
            public double Population { get; set; }
            public double Square { get; set; }
            public virtual Continent Continent { get; set; }


        public CountryModel() { }


    }
}
