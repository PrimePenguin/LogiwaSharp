﻿using Newtonsoft.Json;

namespace LogiwaSharp.Dto
{
    public class OrderRequestFilter
    {
        [JsonProperty("WarehouseID")]
        public long WarehouseId { get; set; }

        [JsonProperty("IsGetOrderDetails")]
        public bool IsGetOrderDetails { get; set; }

        [JsonProperty("IsGetCustomerAddressInfo")]
        public bool IsGetCustomerAddressInfo { get; set; }

        [JsonProperty("PageSize")]
        public long PageSize { get; set; }

        [JsonProperty("SelectedPageIndex")]
        public long SelectedPageIndex { get; set; }

        [JsonProperty("LastModifiedDate_Start")]
        public string LastModifiedDateStart { get; set; }

        [JsonProperty("LastModifiedDate_End")]
        public string LastModifiedDateEnd { get; set; }

        [JsonProperty("ID")]
        public long? Id { get; set; }

        [JsonProperty("Code")]
        public string Code { get; set; }
    }
}
