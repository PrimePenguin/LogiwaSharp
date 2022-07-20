using Newtonsoft.Json;

namespace LogiwaSharp.Dto
{
    public partial class GetReceiptOrderResponse
    {
        [JsonProperty("LAClassInfo")]
        public LaClassInfo LaClassInfo { get; set; }

        [JsonProperty("Data")]
        public ReceiptOrder[] Data { get; set; }

        [JsonProperty("Errors")]
        public object[] Errors { get; set; }

        [JsonProperty("Columns")]
        public object[] Columns { get; set; }

        [JsonProperty("Success")]
        public bool Success { get; set; }

        [JsonProperty("SuccessMessage")]
        public object SuccessMessage { get; set; }

        [JsonProperty("LAClassName")]
        public object LaClassName { get; set; }

        [JsonProperty("EventPlannedFinishDateTime")]
        public string EventPlannedFinishDateTime { get; set; }

        [JsonProperty("EventAssessment")]
        public object EventAssessment { get; set; }

        [JsonProperty("EventuserId")]
        public long EventuserId { get; set; }
    }

    public partial class ReceiptOrder
    {
        [JsonProperty("ID")]
        public long Id { get; set; }

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("ReceiptID")]
        public long ReceiptId { get; set; }

        [JsonProperty("ReceiptDescription")]
        public string ReceiptDescription { get; set; }

        [JsonProperty("Barcode")]
        public string Barcode { get; set; }

        [JsonProperty("InventorySiteID")]
        public long InventorySiteId { get; set; }

        [JsonProperty("InventorySiteDescription")]
        public string InventorySiteDescription { get; set; }

        [JsonProperty("WarehouseID")]
        public long WarehouseId { get; set; }

        [JsonProperty("WarehouseDescription")]
        public string WarehouseDescription { get; set; }

        [JsonProperty("DepositorID")]
        public long DepositorId { get; set; }

        [JsonProperty("DepositorDescription")]
        public string DepositorDescription { get; set; }

        [JsonProperty("SupplierID")]
        public long SupplierId { get; set; }

        [JsonProperty("SupplierDescription")]
        public string SupplierDescription { get; set; }

        [JsonProperty("WaorCode")]
        public string WaorCode { get; set; }

        [JsonProperty("PurchaseOrderCode")]
        public string PurchaseOrderCode { get; set; }

        [JsonProperty("ReceiptDateTime")]
        public string ReceiptDateTime { get; set; }

        [JsonProperty("ReceiptDateTime_Start")]
        public object ReceiptDateTimeStart { get; set; }

        [JsonProperty("ReceiptDateTime_End")]
        public object ReceiptDateTimeEnd { get; set; }

        [JsonProperty("InventoryItemID")]
        public long InventoryItemId { get; set; }

        [JsonProperty("InventoryItemDescription")]
        public string InventoryItemDescription { get; set; }

        [JsonProperty("InventoryItemPackTypeID")]
        public long InventoryItemPackTypeId { get; set; }

        [JsonProperty("InventoryItemPackTypeDescription")]
        public string InventoryItemPackTypeDescription { get; set; }

        [JsonProperty("PackQuantity")]
        public long PackQuantity { get; set; }

        [JsonProperty("CUQuantity")]
        public long CuQuantity { get; set; }

        [JsonProperty("LocationID")]
        public long LocationId { get; set; }

        [JsonProperty("LocationDescription")]
        public string LocationDescription { get; set; }

        [JsonProperty("EntryDateTime")]
        public string EntryDateTime { get; set; }

        [JsonProperty("EntryDateTime_Start")]
        public string EntryDateTimeStart { get; set; }

        [JsonProperty("EntryDateTime_End")]
        public string EntryDateTimeEnd { get; set; }

        [JsonProperty("WarehouseReceiptID")]
        public long WarehouseReceiptId { get; set; }

        [JsonProperty("WarehouseReceiptCode")]
        public string WarehouseReceiptCode { get; set; }

        [JsonProperty("ProjectID")]
        public long ProjectId { get; set; }

        [JsonProperty("ProjectDescription")]
        public string ProjectDescription { get; set; }

        [JsonProperty("SSCC")]
        public string Sscc { get; set; }

        [JsonProperty("Temperature")]
        public long Temperature { get; set; }

        [JsonProperty("FreeAttr1")]
        public string FreeAttr1 { get; set; }

        [JsonProperty("FreeAttr2")]
        public string FreeAttr2 { get; set; }

        [JsonProperty("FreeAttr3")]
        public string FreeAttr3 { get; set; }

        [JsonProperty("InitCode")]
        public string InitCode { get; set; }

        [JsonProperty("LotBatchNo")]
        public string LotBatchNo { get; set; }

        [JsonProperty("ExpireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("ExpireDate_Start")]
        public object ExpireDateStart { get; set; }

        [JsonProperty("ExpireDate_End")]
        public object ExpireDateEnd { get; set; }

        [JsonProperty("ProductionDate")]
        public string ProductionDate { get; set; }

        [JsonProperty("ProductionDate_Start")]
        public object ProductionDateStart { get; set; }

        [JsonProperty("ProductionDate_End")]
        public object ProductionDateEnd { get; set; }

        [JsonProperty("SuitabilityReasonID")]
        public string SuitabilityReasonId { get; set; }

        [JsonProperty("SuitabilityReasonCode")]
        public string SuitabilityReasonCode { get; set; }

        [JsonProperty("QuarantineReasonID")]
        public string QuarantineReasonId { get; set; }

        [JsonProperty("QuarantineReasonCode")]
        public string QuarantineReasonCode { get; set; }

        [JsonProperty("UnitWeight")]
        public long UnitWeight { get; set; }

        [JsonProperty("UnitVolume")]
        public long UnitVolume { get; set; }

        [JsonProperty("EnteredBy")]
        public string EnteredBy { get; set; }

        [JsonProperty("WarehouseOrdReturnReasonID")]
        public long WarehouseOrdReturnReasonId { get; set; }

        [JsonProperty("WarehouseOrdReturnReasonDescription")]
        public string WarehouseOrdReturnReasonDescription { get; set; }

        [JsonProperty("ItemDisplayMember")]
        public string ItemDisplayMember { get; set; }

        [JsonProperty("IsReturn")]
        public bool IsReturn { get; set; }

        [JsonProperty("LocationGroupID")]
        public long LocationGroupId { get; set; }

        [JsonProperty("LocationGroupDescription")]
        public string LocationGroupDescription { get; set; }

        [JsonProperty("LocationZoneID")]
        public long LocationZoneId { get; set; }

        [JsonProperty("LocationZoneDescription")]
        public string LocationZoneDescription { get; set; }

        [JsonProperty("ItemGroupID")]
        public object[] ItemGroupId { get; set; }

        [JsonProperty("ItemGroupDescription")]
        public string ItemGroupDescription { get; set; }

        [JsonProperty("WarehouseReceiptStatusID")]
        public object[] WarehouseReceiptStatusId { get; set; }

        [JsonProperty("WarehouseReceiptStatusDescription")]
        public string WarehouseReceiptStatusDescription { get; set; }

        [JsonProperty("StockKitCode")]
        public string StockKitCode { get; set; }

        [JsonProperty("ReferanceNo")]
        public string ReferanceNo { get; set; }

        [JsonProperty("IntegrationKey")]
        public string IntegrationKey { get; set; }

        [JsonProperty("CustomerDescription")]
        public string CustomerDescription { get; set; }

        [JsonProperty("CustomerOrderNo")]
        public string CustomerOrderNo { get; set; }

        [JsonProperty("PageSize")]
        public long PageSize { get; set; }

        [JsonProperty("SelectedPageIndex")]
        public long SelectedPageIndex { get; set; }

        [JsonProperty("PageCount")]
        public long PageCount { get; set; }

        [JsonProperty("RecordCount")]
        public long RecordCount { get; set; }

        [JsonProperty("LocationDisplayMember")]
        public string LocationDisplayMember { get; set; }
    }

    public partial class LaClassInfo
    {
        [JsonProperty("ClassName")]
        public string ClassName { get; set; }

        [JsonProperty("PrimaryKey")]
        public string PrimaryKey { get; set; }

        [JsonProperty("TypeId")]
        public string TypeId { get; set; }
    }
}
