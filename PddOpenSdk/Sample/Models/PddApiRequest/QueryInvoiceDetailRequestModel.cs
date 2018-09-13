using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class QueryInvoiceDetailRequestModel : PddRequestModel
    {
        /// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// 发票流水号
/// </summary>
[JsonProperty("serial_no")]
public string SerialNo {get;set;}
}
}
