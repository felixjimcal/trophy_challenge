using System.Text.Json.Serialization;

namespace HelloWorld
{
    public class CountryModel
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("data")]
        public List<Datum> Data { get; set; }
    }

    public class Datum
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nativeName")]
        public string NativeName { get; set; }

        [JsonPropertyName("topLevelDomain")]
        public List<string> TopLevelDomain { get; set; }

        [JsonPropertyName("alpha2Code")]
        public string Alpha2Code { get; set; }

        [JsonPropertyName("numericCode")]
        public string NumericCode { get; set; }

        [JsonPropertyName("alpha3Code")]
        public string Alpha3Code { get; set; }

        [JsonPropertyName("currencies")]
        public List<string> Currencies { get; set; }

        [JsonPropertyName("callingCodes")]
        public List<string> CallingCodes { get; set; }

        [JsonPropertyName("capital")]
        public string Capital { get; set; }

        [JsonPropertyName("altSpellings")]
        public List<string> AltSpellings { get; set; }

        [JsonPropertyName("relevance")]
        public string Relevance { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("subregion")]
        public string Subregion { get; set; }

        [JsonPropertyName("language")]
        public List<string> Language { get; set; }

        [JsonPropertyName("languages")]
        public List<string> Languages { get; set; }

        [JsonPropertyName("translations")]
        public Translations Translations { get; set; }

        [JsonPropertyName("population")]
        public int Population { get; set; }

        [JsonPropertyName("latlng")]
        public List<int> Latlng { get; set; }

        [JsonPropertyName("demonym")]
        public string Demonym { get; set; }

        [JsonPropertyName("borders")]
        public List<string> Borders { get; set; }

        [JsonPropertyName("area")]
        public int Area { get; set; }

        [JsonPropertyName("gini")]
        public double Gini { get; set; }

        [JsonPropertyName("timezones")]
        public List<string> Timezones { get; set; }
    }

    public class Translations
    {
        [JsonPropertyName("de")]
        public string De { get; set; }

        [JsonPropertyName("es")]
        public string Es { get; set; }

        [JsonPropertyName("fr")]
        public string Fr { get; set; }

        [JsonPropertyName("it")]
        public string It { get; set; }

        [JsonPropertyName("ja")]
        public string Ja { get; set; }

        [JsonPropertyName("nl")]
        public string Nl { get; set; }

        [JsonPropertyName("hr")]
        public string Hr { get; set; }
    }
}