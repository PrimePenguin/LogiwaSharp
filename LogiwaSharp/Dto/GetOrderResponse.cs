using Newtonsoft.Json;

namespace LogiwaSharp.Dto
{
    public class GetOrderResponse
    {
        [JsonProperty("Data")]
        public Order[] Data { get; set; }

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

    public class Order
    {
        [JsonProperty("ID")]
        public long Id { get; set; }

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("PriorityID")]
        public string PriorityId { get; set; }

        [JsonProperty("CustomerRefCode")]
        public string CustomerRefCode { get; set; }

        [JsonProperty("DepositorRefCode")]
        public string DepositorRefCode { get; set; }

        [JsonProperty("CustomerOrderNo")]
        public string CustomerOrderNo { get; set; }

        [JsonProperty("DepositorOrderNo")]
        public string DepositorOrderNo { get; set; }

        [JsonProperty("WarehouseOrderStatusID")]
        public long[] WarehouseOrderStatusId { get; set; }

        [JsonProperty("WarehouseOrderStatusCode")]
        public string WarehouseOrderStatusCode { get; set; }

        [JsonProperty("CustomerID")]
        public long CustomerId { get; set; }
        [JsonProperty("CustomerCode")]
        public string CustomerCode { get; set; }

        [JsonProperty("CustomerDescription")]
        public string CustomerDescription { get; set; }

        [JsonProperty("InventorySiteID")]
        public long InventorySiteId { get; set; }

        [JsonProperty("InventorySiteCode")]
        public string InventorySiteCode { get; set; }

        [JsonProperty("WarehouseID")]
        public long WarehouseId { get; set; }

        [JsonProperty("WarehouseCode")]

        public string WarehouseCode { get; set; }

        [JsonProperty("WarehouseDescription")]
        public string WarehouseDescription { get; set; }

        [JsonProperty("DepositorID")]
        public long DepositorId { get; set; }

        [JsonProperty("DepositorCode")]
        public string DepositorCode { get; set; }

        [JsonProperty("DepositorDescription")]
        public string DepositorDescription { get; set; }

        [JsonProperty("IsPrintCarrierLabelPackListAsLabel")]
        public bool? IsPrintCarrierLabelPackListAsLabel { get; set; }

        [JsonProperty("IsPrintCarrierLabelPackListOnSamePage")]
        public bool? IsPrintCarrierLabelPackListOnSamePage { get; set; }

        [JsonProperty("CarrierTrackingNumber")]
        public string CarrierTrackingNumber { get; set; }

        [JsonProperty("WarehouseOrderTypeID")]
        public long WarehouseOrderTypeId { get; set; }

        [JsonProperty("WarehouseOrderTypeCode")]
        public string WarehouseOrderTypeCode { get; set; }

        [JsonProperty("OrderDate")]
        public string OrderDate { get; set; }

        [JsonProperty("OrderDate_Start")]
        public object OrderDateStart { get; set; }

        [JsonProperty("OrderDate_End")]
        public object OrderDateEnd { get; set; }

        [JsonProperty("PlannedDeliveryDate")]
        public string PlannedDeliveryDate { get; set; }

        [JsonProperty("PlannedDeliveryDate_Start")]
        public object PlannedDeliveryDateStart { get; set; }

        [JsonProperty("PlannedDeliveryDate_End")]
        public object PlannedDeliveryDateEnd { get; set; }

        [JsonProperty("PlannedShipDate")]
        public string PlannedShipDate { get; set; }

        [JsonProperty("PlannedShipDate_Start")]
        public object PlannedShipDateStart { get; set; }

        [JsonProperty("PlannedShipDate_End")]
        public object PlannedShipDateEnd { get; set; }

        [JsonProperty("Notes")]
        public string Notes { get; set; }

        [JsonProperty("PurchaseOrderID")]
        public long? PurchaseOrderId { get; set; }

        [JsonProperty("PurchaseOrderCode")]
        public string PurchaseOrderCode { get; set; }

        [JsonProperty("IsImported")]
        public object IsImported { get; set; }

        [JsonProperty("IsExported")]
        public object IsExported { get; set; }

        [JsonProperty("IsBackorder")]
        public object IsBackorder { get; set; }

        [JsonProperty("NofShipmentLabel")]
        public long? NofShipmentLabel { get; set; }

        [JsonProperty("IsAllocated")]
        public bool? IsAllocated { get; set; }

        [JsonProperty("IsPickingStarted")]
        public bool? IsPickingStarted { get; set; }

        [JsonProperty("IsPickingCompleted")]
        public bool? IsPickingCompleted { get; set; }

        [JsonProperty("InvoiceCustomerID")]
        public long? InvoiceCustomerId { get; set; }

        [JsonProperty("InvoiceCustomerPartyID")]
        public long? InvoiceCustomerPartyId { get; set; }

        [JsonProperty("InvoiceCustomerDescription")]
        public string InvoiceCustomerDescription { get; set; }

        [JsonProperty("InvoiceCustomerAddressID")]
        public long? InvoiceCustomerAddressId { get; set; }

        [JsonProperty("InvoiceCustomerAddressDescription")]
        public string InvoiceCustomerAddressDescription { get; set; }

        [JsonProperty("CustomerBillingAddressDescription")]
        public string CustomerBillingAddressDescription { get; set; }

        [JsonProperty("CustomerBillingAddressCountryDescription")]
        public string CustomerBillingAddressCountryDescription { get; set; }

        [JsonProperty("CustomerBillingAddressCityDescription")]
        public string CustomerBillingAddressCityDescription { get; set; }

        [JsonProperty("CustomerBillingAddressTownDescription")]
        public string CustomerBillingAddressTownDescription { get; set; }

        [JsonProperty("CustomerBillingAddressPostalCode")]
        public string CustomerBillingAddressPostalCode { get; set; }

        [JsonProperty("CustomerBillingAddressEmail")]
        public string CustomerBillingAddressEmail { get; set; }

        [JsonProperty("CustomerBillingAddressPhone")]
        public string CustomerBillingAddressPhone { get; set; }

        [JsonProperty("CustomerBillingAddressAdressText")]
        public string CustomerBillingAddressAdressText { get; set; }

        [JsonProperty("CustomerBillingAddressAddressDirections")]
        public string CustomerBillingAddressAddressDirections { get; set; }

        [JsonProperty("CustomerBillingAddressPostalCodeDescription")]
        public string CustomerBillingAddressPostalCodeDescription { get; set; }

        [JsonProperty("CustomerBillingAddressStateDescription")]
        public string CustomerBillingAddressStateDescription { get; set; }

        [JsonProperty("CustomerBillingAddressCarrierAddressTypeDescription")]
        public string CustomerBillingAddressCarrierAddressTypeDescription { get; set; }

        [JsonProperty("CustomerBillingAddressIsAddressVerified")]
        public bool CustomerBillingAddressIsAddressVerified { get; set; }

        [JsonProperty("CustomerBillingAddressExtraInformation")]
        public string CustomerBillingAddressExtraInformation { get; set; }

        [JsonProperty("CustomerShippingAddressDescription")]
        public string CustomerShippingAddressDescription { get; set; }

        [JsonProperty("CustomerShippingAddressCountryDescription")]
        public string CustomerShippingAddressCountryDescription { get; set; }

        [JsonProperty("CustomerShippingAddressCityDescription")]
        public string CustomerShippingAddressCityDescription { get; set; }

        [JsonProperty("CustomerShippingAddressTownDescription")]
        public string CustomerShippingAddressTownDescription { get; set; }

        [JsonProperty("CustomerShippingAddressPostalCode")]
        public string CustomerShippingAddressPostalCode { get; set; }

        [JsonProperty("CustomerShippingAddressEmail")]
        public string CustomerShippingAddressEmail { get; set; }

        [JsonProperty("CustomerShippingAddressPhone")]
        public string CustomerShippingAddressPhone { get; set; }

        [JsonProperty("CustomerShippingAddressText")]
        public string CustomerShippingAddressText { get; set; }

        [JsonProperty("CustomerShippingAddressDirections")]
        public string CustomerShippingAddressDirections { get; set; }

        [JsonProperty("CustomerShippingAddressPostalCodeDescription")]
        public string CustomerShippingAddressPostalCodeDescription { get; set; }

        [JsonProperty("CustomerShippingAddressStateDescription")]
        public string CustomerShippingAddressStateDescription { get; set; }

        [JsonProperty("CustomerShippingAddressCarrierAddressTypeDescription")]
        public string CustomerShippingAddressCarrierAddressTypeDescription { get; set; }

        [JsonProperty("CustomerShippingAddressIsAddressVerified")]
        public bool CustomerShippingAddressIsAddressVerified { get; set; }

        [JsonProperty("TotalSalesGrossPrice")]
        public long? TotalSalesGrossPrice { get; set; }

        [JsonProperty("TotalSalesVat")]
        public long? TotalSalesVat { get; set; }

        [JsonProperty("TotalSalesDiscount")]
        public long? TotalSalesDiscount { get; set; }

        [JsonProperty("Instructions")]
        public string Instructions { get; set; }

        [JsonProperty("Driver")]
        public string Driver { get; set; }

        [JsonProperty("Platenumber")]
        public string Platenumber { get; set; }

        [JsonProperty("BillingTypeID")]
        public long? BillingTypeId { get; set; }

        [JsonProperty("BillingTypeDescription")]
        public string BillingTypeDescription { get; set; }

        [JsonProperty("RouteID")]
        public long? RouteId { get; set; }

        [JsonProperty("RouteDescription")]
        public string RouteDescription { get; set; }

        [JsonProperty("ChannelID")]
        public object[] ChannelId { get; set; }

        [JsonProperty("ChannelDescription")]
        public string ChannelDescription { get; set; }

        [JsonProperty("IsCancelRequested")]
        public object IsCancelRequested { get; set; }

        [JsonProperty("CarrierID")]
        public object[] CarrierId { get; set; }

        [JsonProperty("CarrierDescription")]
        public string CarrierDescription { get; set; }

        [JsonProperty("IntegrationKey")]
        public string IntegrationKey { get; set; }

        [JsonProperty("EnteredBy")]
        public string EnteredBy { get; set; }

        [JsonProperty("CanceledBy")]
        public string CanceledBy { get; set; }

        [JsonProperty("CarrierShippingOptionsID")]
        public long? CarrierShippingOptionsId { get; set; }

        [JsonProperty("NofProducts")]
        public long? NofProducts { get; set; }

        [JsonProperty("StoreName")]
        public string StoreName { get; set; }

        [JsonProperty("LinkedChannelID")]
        public object LinkedChannelId { get; set; }

        [JsonProperty("LinkedChannelDescription")]
        public string LinkedChannelDescription { get; set; }

        [JsonProperty("CarrierRate")]
        public long? CarrierRate { get; set; }

        [JsonProperty("CarrierMarkupRate")]
        public long? CarrierMarkupRate { get; set; }

        [JsonProperty("DetailInfo")]
        public DetailInfo[] DetailInfo { get; set; }

        [JsonProperty("CustomerAddressID")]
        public long? CustomerAddressId { get; set; }

        [JsonProperty("CustomerAddressDescription")]
        public string CustomerAddressDescription { get; set; }

        [JsonProperty("PlannedPickDate")]
        public string PlannedPickDate { get; set; }

        [JsonProperty("ActualPickDate")]
        public string ActualPickDate { get; set; }

        [JsonProperty("ActualDeliveryDate")]
        public string ActualDeliveryDate { get; set; }

        [JsonProperty("ProjectID")]
        public object ProjectId { get; set; }

        [JsonProperty("ProjectDescription")]
        public string ProjectDescription { get; set; }

        [JsonProperty("WarehouseReceiptID")]
        public object WarehouseReceiptId { get; set; }

        [JsonProperty("WarehouseReceiptCode")]
        public string WarehouseReceiptCode { get; set; }

        [JsonProperty("BackWarehouseOrderID")]
        public object BackWarehouseOrderId { get; set; }

        [JsonProperty("BackWarehouseOrderCode")]
        public string BackWarehouseOrderCode { get; set; }

        [JsonProperty("DropShipMasterOrderID")]
        public object DropShipMasterOrderId { get; set; }

        [JsonProperty("DropShipWarehouseOrderCode")]
        public string DropShipWarehouseOrderCode { get; set; }

        [JsonProperty("DropShipNotes")]
        public object DropShipNotes { get; set; }

        [JsonProperty("IsWaybillPrinted")]
        public object IsWaybillPrinted { get; set; }

        [JsonProperty("InvoiceNo")]
        public string InvoiceNo { get; set; }

        [JsonProperty("DeliveryNoteNo")]
        public string DeliveryNoteNo { get; set; }

        [JsonProperty("IsCarrierLabelPrinted")]
        public object IsCarrierLabelPrinted { get; set; }

        [JsonProperty("ChannelOrderCode")]
        public string ChannelOrderCode { get; set; }

        [JsonProperty("CarrierWeight")]
        public string CarrierWeight { get; set; }

        [JsonProperty("ClientPartyID")]
        public object ClientPartyId { get; set; }

        [JsonProperty("POWindowWarehouseID")]
        public object PoWindowWarehouseId { get; set; }

        [JsonProperty("WareOrderCancelReasonID")]
        public object WareOrderCancelReasonId { get; set; }

        [JsonProperty("WareOrderCancelReasonDescription")]
        public string WareOrderCancelReasonDescription { get; set; }

        [JsonProperty("Document")]
        public object Document { get; set; }

        [JsonProperty("IsGift")]
        public object IsGift { get; set; }

        [JsonProperty("GiftNote")]
        public string GiftNote { get; set; }

        [JsonProperty("OrderItems")]
        public string OrderItems { get; set; }

        [JsonProperty("ExtraNotes")]
        public string ExtraNotes { get; set; }

        [JsonProperty("ExtraNotes1")]
        public string ExtraNotes1 { get; set; }

        [JsonProperty("ExtraNotes2")]
        public string ExtraNotes2 { get; set; }

        [JsonProperty("ExtraNotes3")]
        public string ExtraNotes3 { get; set; }

        [JsonProperty("ExtraNotes4")]
        public string ExtraNotes4 { get; set; }

        [JsonProperty("ExtraNotes5")]
        public string ExtraNotes5 { get; set; }

        [JsonProperty("FraudRecommendationID")]
        public long? FraudRecommendationId { get; set; }

        [JsonProperty("FraudRecommendationCode")]
        public object FraudRecommendationCode { get; set; }

        [JsonProperty("FraudRecommendationDescription")]
        public string FraudRecommendationDescription { get; set; }

        [JsonProperty("OrderRiskScore")]
        public long? OrderRiskScore { get; set; }

        [JsonProperty("IsExported2")]
        public object IsExported2 { get; set; }

        [JsonProperty("ShipmentMethodID")]
        public long ShipmentMethodId { get; set; }

        [JsonProperty("ShipmentMethodDescription")]
        public string ShipmentMethodDescription { get; set; }

        [JsonProperty("IsAddressVerified")]
        public object IsAddressVerified { get; set; }

        [JsonProperty("AvaliableStockQuantity")]
        public object AvaliableStockQuantity { get; set; }

        [JsonProperty("Store")]
        public string Store { get; set; }

        [JsonProperty("ChannelDepositorParameterID")]
        public long? ChannelDepositorParameterId { get; set; }

        [JsonProperty("CarrierBillingTypeID")]
        public long? CarrierBillingTypeId { get; set; }

        [JsonProperty("CarrierBillingTypeDescription")]
        public string CarrierBillingTypeDescription { get; set; }

        [JsonProperty("IsPickListPrinted")]
        public object IsPickListPrinted { get; set; }

        [JsonProperty("IsPrimeOrder")]
        public object IsPrimeOrder { get; set; }

        [JsonProperty("InvoiceDate")]
        public string InvoiceDate { get; set; }

        [JsonProperty("EntryDateTime")]
        public string EntryDateTime { get; set; }

        [JsonProperty("EntryDateTime_Start")]
        public object EntryDateTimeStart { get; set; }

        [JsonProperty("EntryDateTime_End")]
        public object EntryDateTimeEnd { get; set; }

        [JsonProperty("CargoDiscount")]
        public long? CargoDiscount { get; set; }

        [JsonProperty("WarehouseOrdReturnReasonId")]
        public long? WarehouseOrdReturnReasonId { get; set; }

        [JsonProperty("WarehouseOrdReturnReasonDescription")]
        public string WarehouseOrdReturnReasonDescription { get; set; }

        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("TotalMarkupRate")]
        public long? TotalMarkupRate { get; set; }

        [JsonProperty("TotalCarrierRate")]
        public long? TotalCarrierRate { get; set; }

        [JsonProperty("ActualShipDate")]
        public string ActualShipDate { get; set; }

        [JsonProperty("ActualShipDate_Start")]
        public object ActualShipDateStart { get; set; }

        [JsonProperty("ActualShipDate_End")]
        public object ActualShipDateEnd { get; set; }

        [JsonProperty("PlannedPickupDate")]
        public string PlannedPickupDate { get; set; }

        [JsonProperty("PlannedPickupDate_Start")]
        public object PlannedPickupDateStart { get; set; }

        [JsonProperty("PlannedPickupDate_End")]
        public object PlannedPickupDateEnd { get; set; }

        [JsonProperty("CarrierShippingDescription")]
        public string CarrierShippingDescription { get; set; }

        [JsonProperty("IsGetOrderDetails")]
        public bool? IsGetOrderDetails { get; set; }

        [JsonProperty("Errors")]
        public object[] Errors { get; set; }

        [JsonProperty("Success")]
        public bool? Success { get; set; }

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

    public class DetailInfo
    {
        [JsonProperty("ID")]
        public long Id { get; set; }

        [JsonProperty("Code")]
        public object Code { get; set; }

        [JsonProperty("InventoryItemID")]
        public long? InventoryItemId { get; set; }

        [JsonProperty("InventoryItemDescription")]
        public string InventoryItemDescription { get; set; }

        [JsonProperty("InventoryItemInfo")]
        public string InventoryItemInfo { get; set; }

        [JsonProperty("Barcode")]
        public string Barcode { get; set; }

        [JsonProperty("DisplayMember")]
        public string DisplayMember { get; set; }

        [JsonProperty("InventoryItemPackTypeID")]
        public long? InventoryItemPackTypeId { get; set; }

        [JsonProperty("InventoryItemPackTypeDescription")]
        public string InventoryItemPackTypeDescription { get; set; }

        [JsonProperty("PackQuantity")]
        public long? PackQuantity { get; set; }

        [JsonProperty("WarehouseOrderID")]
        public long? WarehouseOrderId { get; set; }

        [JsonProperty("UnitWeight")]
        public long? UnitWeight { get; set; }

        [JsonProperty("UnitVolume")]
        public long? UnitVolume { get; set; }

        [JsonProperty("AllocatedCuQuantity")]
        public long? AllocatedCuQuantity { get; set; }

        [JsonProperty("PickedCuQuantity")]
        public int? PickedCuQuantity { get; set; }

        [JsonProperty("LoadedCuQuantity")]
        public long? LoadedCuQuantity { get; set; }

        [JsonProperty("ShippedCuQuantity")]
        public int? ShippedCuQuantity { get; set; }

        [JsonProperty("PlannedPackQuantity")]
        public long? PlannedPackQuantity { get; set; }

        [JsonProperty("PlannedCuQuantity")]
        public long? PlannedCuQuantity { get; set; }

        [JsonProperty("SortedCUQuantity")]
        public long? SortedCuQuantity { get; set; }

        [JsonProperty("PackedCUQuantity")]
        public long? PackedCuQuantity { get; set; }

        [JsonProperty("CancelledCuQuantity")]
        public long? CancelledCuQuantity { get; set; }

        [JsonProperty("FreeAttr1")]
        public string FreeAttr1 { get; set; }

        [JsonProperty("FreeAttr2")]
        public string FreeAttr2 { get; set; }

        [JsonProperty("FreeAttr3")]
        public string FreeAttr3 { get; set; }

        [JsonProperty("CurrencyPrice")]
        public long? CurrencyPrice { get; set; }

        [JsonProperty("TaxRate")]
        public long? TaxRate { get; set; }

        [JsonProperty("NetCurrencyPrice")]
        public long? NetCurrencyPrice { get; set; }

        [JsonProperty("TotalWeight")]
        public long? TotalWeight { get; set; }

        [JsonProperty("TotalVolume")]
        public long? TotalVolume { get; set; }

        [JsonProperty("SupplierID")]
        public long? SupplierId { get; set; }

        [JsonProperty("SupplierDescription")]
        public string SupplierDescription { get; set; }

        [JsonProperty("Notes1")]
        public string Notes1 { get; set; }

        [JsonProperty("SalesUnitPrice")]
        public long? SalesUnitPrice { get; set; }
    }
}
