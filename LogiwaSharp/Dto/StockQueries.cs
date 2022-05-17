using Newtonsoft.Json;

namespace LogiwaSharp.Dto
{
    public class StockRequest
    {
        [JsonProperty("ChannelID")]
        public long? ChannelId { get; set; }

        [JsonProperty("DepositorID")]
        public long? DepositorId { get; set; }

        [JsonProperty("DamagedQuantity")]
        public long? DamagedQuantity { get; set; }

        [JsonProperty("PageSize")]
        public long? PageSize { get; set; }

        [JsonProperty("SelectedPageIndex")]
        public long? SelectedPageIndex { get; set; }
    }

    public class StockResponse
    {
        [JsonProperty("Data")]
        public Stock[] Data { get; set; }

        [JsonProperty("Errors")]
        public string[] Errors { get; set; }

        [JsonProperty("Success")]
        public bool Success { get; set; }

        [JsonProperty("SuccessMessage")]
        public string SuccessMessage { get; set; }

        [JsonProperty("EventPlannedFinishDateTime")]
        public string EventPlannedFinishDateTime { get; set; }

        [JsonProperty("EventuserId")]
        public long? EventuserId { get; set; }
    }
    public class Stock
    {
        [JsonProperty("ID")]
        public long? Id { get; set; }

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Brand")]
        public string Brand { get; set; }

        [JsonProperty("ChannelID")]
        public long? ChannelId { get; set; }

        [JsonProperty("ChannelDescription")]
        public string ChannelDescription { get; set; }

        [JsonProperty("DepositorID")]
        public long? DepositorId { get; set; }

        [JsonProperty("DepositorDescription")]
        public string DepositorDescription { get; set; }

        [JsonProperty("MainCategoryDescription")]
        public string MainCategoryDescription { get; set; }

        [JsonProperty("ChannelItemNumber")]
        public string ChannelItemNumber { get; set; }

        [JsonProperty("ChannelSellerSku")]
        public string ChannelSellerSku { get; set; }

        [JsonProperty("ChannelIsActive")]
        public bool ChannelIsActive { get; set; }

        [JsonProperty("ChannelIsDropShip")]
        public object ChannelIsDropShip { get; set; }

        [JsonProperty("ChannelInventoryAmount")]
        public long? ChannelInventoryAmount { get; set; }

        [JsonProperty("ChannelUnitPrice")]
        public long? ChannelUnitPrice { get; set; }

        [JsonProperty("MasterChannelItemNumber")]
        public string MasterChannelItemNumber { get; set; }

        [JsonProperty("ChannelMasterSellerSku")]
        public string ChannelMasterSellerSku { get; set; }

        [JsonProperty("ChannelIsExported")]
        public object ChannelIsExported { get; set; }

        [JsonProperty("ChannelIsNotIncludeInOrder")]
        public object ChannelIsNotIncludeInOrder { get; set; }

        [JsonProperty("UsableStock")]
        public int? UsableStock { get; set; }

        [JsonProperty("OrderQty")]
        public long? OrderQty { get; set; }

        [JsonProperty("AvailableStockQty")]
        public int? AvailableStockQty { get; set; }

        [JsonProperty("SellableStock")]
        public int? SellableStock { get; set; }

        [JsonProperty("IsOutOfStock")]
        public bool IsOutOfStock { get; set; }

        [JsonProperty("FnSku")]
        public string FnSku { get; set; }

        [JsonProperty("CloseToSaleQuantity")]
        public long? CloseToSaleQuantity { get; set; }

        [JsonProperty("DamagedQuantity")]
        public long? DamagedQuantity { get; set; }

        [JsonProperty("LastQuantitySynced")]
        public long? LastQuantitySynced { get; set; }

        [JsonProperty("IsKitItem")]
        public bool IsKitItem { get; set; }

        [JsonProperty("LastQuantitySyncedDate")]
        public string LastQuantitySyncedDate { get; set; }

        [JsonProperty("LastQuantitySyncedDate_Start")]
        public object LastQuantitySyncedDateStart { get; set; }

        [JsonProperty("LastQuantitySyncedDate_End")]
        public object LastQuantitySyncedDateEnd { get; set; }

        [JsonProperty("ShareableQty")]
        public long? ShareableQty { get; set; }

        [JsonProperty("InventorySharingPercentage")]
        public long? InventorySharingPercentage { get; set; }

        [JsonProperty("StoreName")]
        public string StoreName { get; set; }

        [JsonProperty("PageSize")]
        public object PageSize { get; set; }

        [JsonProperty("SelectedPageIndex")]
        public object SelectedPageIndex { get; set; }

        [JsonProperty("PageCount")]
        public object PageCount { get; set; }

        [JsonProperty("RecordCount")]
        public object RecordCount { get; set; }
    }
}
