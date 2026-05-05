using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.OrdersV20260101
{
    /// <summary>
    /// Indicates that the selling price is a special price that is only available for Amazon Business orders. For more information about the Amazon Business Seller Program, refer to the Amazon Business website.
    /// 
    /// Note: Official Amazon API documentation (as of 2025) states only BUSINESS_PRICE is possible,
    /// but the API actually returns additional values like QUANTITY_PRICE for tiered pricing.
    /// See: https://developer-docs.amazon.com/sp-api/docs/orders-api-v0-reference
    /// </summary>
    /// <value>Indicates that the selling price is a special price that is only available for Amazon Business orders. For more information about the Amazon Business Seller Program, refer to the Amazon Business website.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PriceDesignationEnum
    {
        /// <summary>
        /// Enum value for type BUSINESS_PRICE
        /// </summary>
        [EnumMember(Value = "BUSINESS_PRICE")]
        BUSINESS_PRICE = 1,

        /// <summary>
        /// Enum value for type QUANTITY_PRICE (tiered/quantity-based pricing)
        /// Note: This value is returned by the API but not documented in the official API reference as of 2025.
        /// </summary>
        [EnumMember(Value = "QUANTITY_PRICE")]
        QUANTITY_PRICE = 2
    }

}
