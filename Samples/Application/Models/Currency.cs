namespace Models
{
    public struct Currency
    {
        public string Name { get; set; }
        public string CurrencyCode { get; set; }
        public Currency(string name, string currencyCode)
        {
            Name = name;
            CurrencyCode = currencyCode;
        }
    }
}
