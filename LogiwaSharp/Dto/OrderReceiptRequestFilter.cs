using Newtonsoft.Json;

namespace LogiwaSharp.Dto
{
    public class OrderReceiptRequestFilter
    {
        [JsonProperty("WarehouseID")]
        public long WarehouseId { get; set; }

        [JsonProperty("IsReturn")]
        public bool IsReturn { get; set; }

        [JsonProperty("PageSize")]
        public long PageSize { get; set; }

        [JsonProperty("SelectedPageIndex")]
        public long SelectedPageIndex { get; set; }

        [JsonProperty("ReceiptDateTime_Start")]
        public string ReceiptDateTimeStart { get; set; }

        [JsonProperty("ReceiptDateTime_End")]
        public string ReceiptDateTimeEnd { get; set; }
    }
}
