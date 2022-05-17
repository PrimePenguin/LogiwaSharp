using Newtonsoft.Json;

namespace LogiwaSharp.Dto
{
    public class ProductRequestFilter
    {
        [JsonProperty("DepositorDescription")]
        public string DepositorDescription { get; set; }

        [JsonProperty("BarcodeSearch")]
        public string BarcodeSearch { get; set; }

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("LastModifiedDate_Start")]
        public string LastModifiedDateStart { get; set; }

        [JsonProperty("LastModifiedDate_End")]
        public string LastModifiedDateEnd { get; set; }

        [JsonProperty("PageSize")]
        public long PageSize { get; set; }

        [JsonProperty("SelectedPageIndex")]
        public long SelectedPageIndex { get; set; }
    }
}
