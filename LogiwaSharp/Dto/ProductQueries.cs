using Newtonsoft.Json;

namespace LogiwaSharp.Dto
{
    public class GetAllProducts
    {
        [JsonProperty("Data")]
        public LogiwaProduct[] Data { get; set; }
    }

    public class LogiwaProduct
    {
        [JsonProperty("ID")]
        public long Id { get; set; }

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("DepositorID")]
        public long? DepositorId { get; set; }

        [JsonProperty("DepositorDescription")]
        public string DepositorDescription { get; set; }

        [JsonProperty("InventItemGroupID")]
        public long? InventItemGroupId { get; set; }

        [JsonProperty("InventItemGroupDescription")]
        public string InventItemGroupDescription { get; set; }

        [JsonProperty("BarcodeSearch")]
        public string BarcodeSearch { get; set; }

        [JsonProperty("ItemTypeID")]
        public long? ItemTypeId { get; set; }

        [JsonProperty("ItemTypeDescription")]
        public string ItemTypeDescription { get; set; }

        [JsonProperty("SecondaryCode")]
        public string SecondaryCode { get; set; }

        [JsonProperty("IntegrationKey")]
        public string IntegrationKey { get; set; }

        [JsonProperty("ItemMainCategoryID")]
        public long? ItemMainCategoryId { get; set; }

        [JsonProperty("ItemMainCategoryDescripton")]
        public string ItemMainCategoryDescripton { get; set; }

        [JsonProperty("ItemSubCategoryID")]
        public long? ItemSubCategoryId { get; set; }

        [JsonProperty("ItemSubCategoryDescripton")]
        public string ItemSubCategoryDescripton { get; set; }

        [JsonProperty("ItemDetailCategoryID")]
        public long? ItemDetailCategoryId { get; set; }

        [JsonProperty("ItemDetailCategoryDescripton")]
        public string ItemDetailCategoryDescripton { get; set; }

        [JsonProperty("BarcodeInfo")]
        public object BarcodeInfo { get; set; }

        [JsonProperty("ComponentInfo")]
        public object ComponentInfo { get; set; }

        [JsonProperty("LOTPropertyInfo")]
        public object LotPropertyInfo { get; set; }

        [JsonProperty("Notes")]
        public string Notes { get; set; }

        [JsonProperty("PurchaseUnitPrice")]
        public string PurchaseUnitPrice { get; set; }

        [JsonProperty("FNSKU")]
        public string Fnsku { get; set; }

        [JsonProperty("DangerousItemTypeID")]
        public long? DangerousItemTypeId { get; set; }

        [JsonProperty("DangerousItemTypeDescription")]
        public string DangerousItemTypeDescription { get; set; }

        [JsonProperty("IsLoadBatch")]
        public object IsLoadBatch { get; set; }

        [JsonProperty("HazmatIdentificationNumberID")]
        public long? HazmatIdentificationNumberId { get; set; }

        [JsonProperty("HazmatIdentificationNumber")]
        public string HazmatIdentificationNumber { get; set; }

        [JsonProperty("CuUnitID")]
        public long? CuUnitId { get; set; }

        [JsonProperty("Weight")]
        public long? Weight { get; set; }

        [JsonProperty("Volume")]
        public long? Volume { get; set; }

        [JsonProperty("InventoryItemStatusID")]
        public long? InventoryItemStatusId { get; set; }

        [JsonProperty("MinimumOrderQty")]
        public long? MinimumOrderQty { get; set; }

        [JsonProperty("InventoryItemStatusDescription")]
        public string InventoryItemStatusDescription { get; set; }

        [JsonProperty("InventItemGroupDescripton")]
        public string InventItemGroupDescripton { get; set; }

        [JsonProperty("Brand")]
        public string Brand { get; set; }

        [JsonProperty("SafetyStockCu")]
        public long? SafetyStockCu { get; set; }

        [JsonProperty("IsKitItem")]
        public object IsKitItem { get; set; }

        [JsonProperty("IsPackingItem")]
        public bool IsPackingItem { get; set; }

        [JsonProperty("ProductImages")]
        public object ProductImages { get; set; }

        [JsonProperty("ProductImage2")]
        public string ProductImage2 { get; set; }

        [JsonProperty("ProductImage3")]
        public string ProductImage3 { get; set; }

        [JsonProperty("ShelfLife")]
        public long? ShelfLife { get; set; }

        [JsonProperty("IsOverSized")]
        public object IsOverSized { get; set; }

        [JsonProperty("AbcCodeID")]
        public long? AbcCodeId { get; set; }

        [JsonProperty("Size")]
        public string Size { get; set; }

        [JsonProperty("Origin")]
        public string Origin { get; set; }

        [JsonProperty("Season")]
        public string Season { get; set; }

        [JsonProperty("IsTemporaryItem")]
        public object IsTemporaryItem { get; set; }

        [JsonProperty("IsFragile")]
        public object IsFragile { get; set; }

        [JsonProperty("QualityPolicyID")]
        public long? QualityPolicyId { get; set; }

        [JsonProperty("ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("ImageUrl2")]
        public string ImageUrl2 { get; set; }

        [JsonProperty("ImageUrl3")]
        public string ImageUrl3 { get; set; }

        [JsonProperty("IsTrackTemperature")]
        public object IsTrackTemperature { get; set; }

        [JsonProperty("ScrapFactor")]
        public long? ScrapFactor { get; set; }

        [JsonProperty("CycleTime")]
        public long? CycleTime { get; set; }

        [JsonProperty("ItemProperty")]
        public string ItemProperty { get; set; }

        [JsonProperty("AbcCodeDescription")]
        public string AbcCodeDescription { get; set; }

        [JsonProperty("QualityPolicyDescription")]
        public string QualityPolicyDescription { get; set; }

        [JsonProperty("SalesUnitPrice")]
        public long? SalesUnitPrice { get; set; }

        [JsonProperty("ItemDisplayMember")]
        public string ItemDisplayMember { get; set; }

        [JsonProperty("BarcodeText")]
        public string BarcodeText { get; set; }

        [JsonProperty("CreditSalesUnitPrice")]
        public long? CreditSalesUnitPrice { get; set; }

        [JsonProperty("MaxTemperature")]
        public long? MaxTemperature { get; set; }

        [JsonProperty("MinTemperature")]
        public long? MinTemperature { get; set; }

        [JsonProperty("ConditionalMaxTemp")]
        public long? ConditionalMaxTemp { get; set; }

        [JsonProperty("ConditionalMinTemp")]
        public long? ConditionalMinTemp { get; set; }

        [JsonProperty("CustomsDescription")]
        public string CustomsDescription { get; set; }

        [JsonProperty("HsCode")]
        public string HsCode { get; set; }

        [JsonProperty("CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("UOM")]
        public string Uom { get; set; }

        [JsonProperty("ReOrderQTY")]
        public long? ReOrderQty { get; set; }

        [JsonProperty("LastModifiedDate")]
        public string LastModifiedDate { get; set; }

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
        public int? PageSize { get; set; }

        [JsonProperty("SelectedPageIndex")]
        public int? SelectedPageIndex { get; set; }

        [JsonProperty("PageCount")]
        public int? PageCount { get; set; }

        [JsonProperty("RecordCount")]
        public int? RecordCount { get; set; }
    }
}