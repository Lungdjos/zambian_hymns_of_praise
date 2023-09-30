namespace LocalHymns.Models
{

    public class Root
    {
        [JsonProperty("hymns")]
        public List<Hymn> Hymns { get; set; }

        [JsonIgnore]
        public Categories Categories { get; set; }
    }

}