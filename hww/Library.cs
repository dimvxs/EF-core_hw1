namespace hww
{
    public class CountryModel
    {
            public int Id { get; set; }
            public string Country { get; set; }
            public string Capital { get; set; }
            public double Population { get; set; }
            public double Square { get; set; }
            public Continent Continent { get; set; }
            public int ContinentId { get; set; }



        public CountryModel() { }


    }
}
