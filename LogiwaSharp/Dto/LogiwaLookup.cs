using Newtonsoft.Json;

namespace LogiwaSharp.Dto
{
    public class LogiwaLookups
    {
        [JsonProperty("UserId")]
        public long UserId { get; set; }

        [JsonProperty("CompanyId")]
        public long CompanyId { get; set; }

        [JsonProperty("LookupList")]
        public object LookupList { get; set; }

        [JsonProperty("Lookup")]
        public LogiwaLookup Lookup { get; set; }

        [JsonProperty("LastModifiedDate_Start")]
        public object LastModifiedDateStart { get; set; }

        [JsonProperty("LastModifiedDate_End")]
        public object LastModifiedDateEnd { get; set; }

        [JsonProperty("Errors")]
        public object[] Errors { get; set; }

        [JsonProperty("Success")]
        public bool Success { get; set; }

        [JsonProperty("SuccessMessage")]
        public object SuccessMessage { get; set; }

        [JsonProperty("PageSize")]
        public object PageSize { get; set; }

        [JsonProperty("SelectedPageIndex")]
        public object SelectedPageIndex { get; set; }

        [JsonProperty("PageCount")]
        public object PageCount { get; set; }

        [JsonProperty("RecordCount")]
        public object RecordCount { get; set; }
    }

    public class LogiwaLookup
    {
        [JsonProperty("ClientList")]
        public Lookup[] ClientList { get; set; }

        [JsonProperty("InventorySiteList")]
        public Lookup[] InventorySiteList { get; set; }

        [JsonProperty("WarehouseList")]
        public Lookup[] WarehouseList { get; set; }

        [JsonProperty("ItemMainCategoryList")]
        public object[] ItemMainCategoryList { get; set; }

        [JsonProperty("ShipmentOrderStatusList")]
        public Lookup[] ShipmentOrderStatusList { get; set; }

        [JsonProperty("CarrierList")]
        public Lookup[] CarrierList { get; set; }

        [JsonProperty("ChannelList")]
        public Lookup[] ChannelList { get; set; }

        [JsonProperty("ItemTypeList")]
        public Lookup[] ItemTypeList { get; set; }

        [JsonProperty("ItemStatusList")]
        public Lookup[] ItemStatusList { get; set; }

        [JsonProperty("PartyAddressTypeList")]
        public Lookup[] PartyAddressTypeList { get; set; }

        [JsonProperty("CarrierAddressTypeList")]
        public Lookup[] CarrierAddressTypeList { get; set; }

        [JsonProperty("ShipmentMethodList")]
        public Lookup[] ShipmentMethodList { get; set; }

        [JsonProperty("PurchaseOrderTypeList")]
        public Lookup[] PurchaseOrderTypeList { get; set; }

        [JsonProperty("ReceiptOrderTypeList")]
        public Lookup[] ReceiptOrderTypeList { get; set; }

        [JsonProperty("ShipmentOrderTypeList")]
        public Lookup[] ShipmentOrderTypeList { get; set; }

        [JsonProperty("DocumentTypeList")]
        public Lookup[] DocumentTypeList { get; set; }

        [JsonProperty("DangerousItemTypeList")]
        public Lookup[] DangerousItemTypeList { get; set; }

        [JsonProperty("HazmatIdendificationNumberList")]
        public Lookup[] HazmatIdendificationNumberList { get; set; }

        [JsonProperty("AdjusmentTypeList")]
        public Lookup[] AdjusmentTypeList { get; set; }

        [JsonProperty("OrderCancelReasonList")]
        public Lookup[] OrderCancelReasonList { get; set; }
    }

    public class Lookup
    {
        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("LastModifiedDate")]
        public string LastModifiedDate { get; set; }
    }
}
