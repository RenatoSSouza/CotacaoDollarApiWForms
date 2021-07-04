using Newtonsoft.Json;

namespace CotacaoDollar
{
    public class Market
    {
        public Market()
        {
            Currency = new Currency();
        }
        [JsonProperty(propertyName: "currencies")]
        public Currency Currency { get; set; }
    }
}
