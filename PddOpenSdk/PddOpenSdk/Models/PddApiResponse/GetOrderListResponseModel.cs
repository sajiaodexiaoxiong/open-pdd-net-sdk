using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetOrderListResponseModel : PddResponseModel
    {
        /// <summary>
/// 请求response
/// </summary>
[JsonProperty("order_list_get_response")]
public object OrderListGetResponse {get;set;}
/// <summary>
/// 订单总数
/// </summary>
[JsonProperty("total_count")]
public object TotalCount {get;set;}
/// <summary>
/// 订单信息列表
/// </summary>
[JsonProperty("order_list")]
public object OrderList {get;set;}
/// <summary>
/// 售后状态 0：无售后 2：买家申请退款，待商家处理 3：退货退款，待商家处理 4：商家同意退款，退款中 5：平台同意退款，退款中 6：驳回退款， 待买家处理 7：已同意退货退款,待用户发货 8：平台处理中 9：平台拒 绝退款，退款关闭 10：退款成功 11：买家撤销 12：买家逾期未处 理，退款失败 13：买家逾期，超过有效期 14 : 换货补寄待商家处理 15:换货补寄待用户处理 16:换货补寄成功 17:换货补寄失败 18:换货补寄待用户确认完成
/// </summary>
[JsonProperty("after_sales_status")]
public int AfterSalesStatus {get;set;}
/// <summary>
/// 是否为预售商品 1表示是 0表示否
/// </summary>
[JsonProperty("is_pre_sale")]
public object IsPreSale {get;set;}
/// <summary>
/// 预售时间
/// </summary>
[JsonProperty("pre_sale_time")]
public object PreSaleTime {get;set;}
/// <summary>
/// 1代表有 0代表无
/// </summary>
[JsonProperty("invoice_status")]
public int InvoiceStatus {get;set;}
/// <summary>
/// 买家留言信息
/// </summary>
[JsonProperty("buyer_memo")]
public object BuyerMemo {get;set;}
/// <summary>
/// 支付申报订单号
/// </summary>
[JsonProperty("inner_transaction_id")]
public object InnerTransactionId {get;set;}
/// <summary>
/// 商品一级分类
/// </summary>
[JsonProperty("cat_id_1")]
public int CatId1 {get;set;}
/// <summary>
/// 商品二级分类
/// </summary>
[JsonProperty("cat_id_2")]
public int CatId2 {get;set;}
/// <summary>
/// 商品三级分类
/// </summary>
[JsonProperty("cat_id_3")]
public int CatId3 {get;set;}
/// <summary>
/// 商品四级分类
/// </summary>
[JsonProperty("cat_id_4")]
public int CatId4 {get;set;}
/// <summary>
/// 缺货处理状态
/// </summary>
[JsonProperty("stock_out_handle_status")]
public int StockOutHandleStatus {get;set;}
/// <summary>
/// 是否缺货
/// </summary>
[JsonProperty("is_stock_out")]
public int IsStockOut {get;set;}
/// <summary>
/// 国家编码
/// </summary>
[JsonProperty("country_id")]
public int CountryId {get;set;}
/// <summary>
/// 省份编码
/// </summary>
[JsonProperty("province_id")]
public int ProvinceId {get;set;}
/// <summary>
/// 城市编码
/// </summary>
[JsonProperty("city_id")]
public int CityId {get;set;}
/// <summary>
/// 区县编码
/// </summary>
[JsonProperty("town_id")]
public int TownId {get;set;}
/// <summary>
/// 确认收货时间
/// </summary>
[JsonProperty("receive_time")]
public object ReceiveTime {get;set;}
/// <summary>
/// 成团时间
/// </summary>
[JsonProperty("confirm_time")]
public object ConfirmTime {get;set;}
/// <summary>
/// 收件人姓名
/// </summary>
[JsonProperty("receiver_name")]
public object ReceiverName {get;set;}
/// <summary>
/// 订单创建时间
/// </summary>
[JsonProperty("created_time")]
public object CreatedTime {get;set;}
/// <summary>
/// 国家
/// </summary>
[JsonProperty("country")]
public object Country {get;set;}
/// <summary>
/// 省份
/// </summary>
[JsonProperty("province")]
public object Province {get;set;}
/// <summary>
/// 城市
/// </summary>
[JsonProperty("city")]
public object City {get;set;}
/// <summary>
/// 区，乡镇
/// </summary>
[JsonProperty("town")]
public object Town {get;set;}
/// <summary>
/// 详细地址
/// </summary>
[JsonProperty("address")]
public object Address {get;set;}
/// <summary>
/// 收件人电话，仅订单状态=待发货状态下返回明文，其他状态下返回脱敏手机号，例如“1387677****”
/// </summary>
[JsonProperty("receiver_phone")]
public object ReceiverPhone {get;set;}
/// <summary>
/// 支付金额，单位：元，支付金额=商品金额-折扣金额+邮费
/// </summary>
[JsonProperty("pay_amount")]
public object PayAmount {get;set;}
/// <summary>
/// 商品金额，单位：元，商品金额=商品销售价格*商品数量-改价金额（接口暂无该字段）
/// </summary>
[JsonProperty("goods_amount")]
public object GoodsAmount {get;set;}
/// <summary>
/// 折扣金额，单位：元，折扣金额=平台优惠+商家优惠+团长免单优惠金额
/// </summary>
[JsonProperty("discount_amount")]
public object DiscountAmount {get;set;}
/// <summary>
/// 邮费，单位：元
/// </summary>
[JsonProperty("postage")]
public object Postage {get;set;}
/// <summary>
/// 支付单号
/// </summary>
[JsonProperty("pay_no")]
public object PayNo {get;set;}
/// <summary>
/// 支付类型
/// </summary>
[JsonProperty("pay_type")]
public object PayType {get;set;}
/// <summary>
/// 身份证号
/// </summary>
[JsonProperty("id_card_num")]
public object IdCardNum {get;set;}
/// <summary>
/// 身份证姓名
/// </summary>
[JsonProperty("id_card_name")]
public object IdCardName {get;set;}
/// <summary>
/// 快递公司在拼多多的代码
/// </summary>
[JsonProperty("logistics_id")]
public int LogisticsId {get;set;}
/// <summary>
/// 快递单号
/// </summary>
[JsonProperty("tracking_number")]
public object TrackingNumber {get;set;}
/// <summary>
/// 发货时间
/// </summary>
[JsonProperty("shipping_time")]
public object ShippingTime {get;set;}
/// <summary>
/// 订单状态
/// </summary>
[JsonProperty("order_status")]
public int OrderStatus {get;set;}
/// <summary>
/// 是否是抽奖订单，1否，2是
/// </summary>
[JsonProperty("is_lucky_flag")]
public int IsLuckyFlag {get;set;}
/// <summary>
/// 售后状态
/// </summary>
[JsonProperty("refund_status")]
public int RefundStatus {get;set;}
/// <summary>
/// 订单的更新时间
/// </summary>
[JsonProperty("updated_at")]
public object UpdatedAt {get;set;}
/// <summary>
/// 订单承诺发货时间
/// </summary>
[JsonProperty("last_ship_time")]
public object LastShipTime {get;set;}
/// <summary>
/// 订单备注
/// </summary>
[JsonProperty("remark")]
public object Remark {get;set;}
/// <summary>
/// 订单商品列表
/// </summary>
[JsonProperty("item_list")]
public object ItemList {get;set;}
/// <summary>
/// 平台优惠金额，单位：元
/// </summary>
[JsonProperty("platform_discount")]
public object PlatformDiscount {get;set;}
/// <summary>
/// 商家优惠金额，单位：元
/// </summary>
[JsonProperty("seller_discount")]
public object SellerDiscount {get;set;}
/// <summary>
/// 团长免单金额，单位：元
/// </summary>
[JsonProperty("capital_free_discount")]
public object CapitalFreeDiscount {get;set;}
/// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}
/// <summary>
/// 商品图片
/// </summary>
[JsonProperty("goods_img")]
public object GoodsImg {get;set;}
/// <summary>
/// 商品规格
/// </summary>
[JsonProperty("goods_spec")]
public object GoodsSpec {get;set;}
/// <summary>
/// 商品数量
/// </summary>
[JsonProperty("goods_count")]
public int GoodsCount {get;set;}
/// <summary>
/// 商品编码
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}
/// <summary>
/// 商品sku编码
/// </summary>
[JsonProperty("sku_id")]
public int SkuId {get;set;}
/// <summary>
/// sku维度商家外部编码，注意：编辑商品后必须等待商品审核通过后方可生效，订单中商品信息为交易快照的商品信息。
/// </summary>
[JsonProperty("outer_id")]
public object OuterId {get;set;}
/// <summary>
/// 商品维度外部编码，注意：编辑商品后必须等待商品审核通过后方可生效，订单中商品信息为交易快照的商品信息。
/// </summary>
[JsonProperty("outer_goods_id")]
public object OuterGoodsId {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}
/// <summary>
/// 商品单件
/// </summary>
[JsonProperty("goods_price")]
public object GoodsPrice {get;set;}

    public partial class OrderListGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 订单信息列表
/// </summary>
[JsonProperty("order_list")]
public object OrderList {get;set;}

}

    public partial class OrderListResponseModel : PddResponseModel
    {
        /// <summary>
/// 售后状态 0：无售后 2：买家申请退款，待商家处理 3：退货退款，待商家处理 4：商家同意退款，退款中 5：平台同意退款，退款中 6：驳回退款， 待买家处理 7：已同意退货退款,待用户发货 8：平台处理中 9：平台拒 绝退款，退款关闭 10：退款成功 11：买家撤销 12：买家逾期未处 理，退款失败 13：买家逾期，超过有效期 14 : 换货补寄待商家处理 15:换货补寄待用户处理 16:换货补寄成功 17:换货补寄失败 18:换货补寄待用户确认完成
/// </summary>
[JsonProperty("after_sales_status")]
public int AfterSalesStatus {get;set;}
/// <summary>
/// 是否为预售商品 1表示是 0表示否
/// </summary>
[JsonProperty("is_pre_sale")]
public object IsPreSale {get;set;}
/// <summary>
/// 预售时间
/// </summary>
[JsonProperty("pre_sale_time")]
public object PreSaleTime {get;set;}
/// <summary>
/// 1代表有 0代表无
/// </summary>
[JsonProperty("invoice_status")]
public int InvoiceStatus {get;set;}
/// <summary>
/// 买家留言信息
/// </summary>
[JsonProperty("buyer_memo")]
public object BuyerMemo {get;set;}
/// <summary>
/// 支付申报订单号
/// </summary>
[JsonProperty("inner_transaction_id")]
public object InnerTransactionId {get;set;}
/// <summary>
/// 商品一级分类
/// </summary>
[JsonProperty("cat_id_1")]
public int CatId1 {get;set;}
/// <summary>
/// 商品二级分类
/// </summary>
[JsonProperty("cat_id_2")]
public int CatId2 {get;set;}
/// <summary>
/// 商品三级分类
/// </summary>
[JsonProperty("cat_id_3")]
public int CatId3 {get;set;}
/// <summary>
/// 商品四级分类
/// </summary>
[JsonProperty("cat_id_4")]
public int CatId4 {get;set;}
/// <summary>
/// 缺货处理状态
/// </summary>
[JsonProperty("stock_out_handle_status")]
public int StockOutHandleStatus {get;set;}
/// <summary>
/// 是否缺货
/// </summary>
[JsonProperty("is_stock_out")]
public int IsStockOut {get;set;}
/// <summary>
/// 国家编码
/// </summary>
[JsonProperty("country_id")]
public int CountryId {get;set;}
/// <summary>
/// 省份编码
/// </summary>
[JsonProperty("province_id")]
public int ProvinceId {get;set;}
/// <summary>
/// 城市编码
/// </summary>
[JsonProperty("city_id")]
public int CityId {get;set;}
/// <summary>
/// 区县编码
/// </summary>
[JsonProperty("town_id")]
public int TownId {get;set;}
/// <summary>
/// 确认收货时间
/// </summary>
[JsonProperty("receive_time")]
public object ReceiveTime {get;set;}
/// <summary>
/// 成团时间
/// </summary>
[JsonProperty("confirm_time")]
public object ConfirmTime {get;set;}
/// <summary>
/// 收件人姓名
/// </summary>
[JsonProperty("receiver_name")]
public object ReceiverName {get;set;}
/// <summary>
/// 订单创建时间
/// </summary>
[JsonProperty("created_time")]
public object CreatedTime {get;set;}
/// <summary>
/// 国家
/// </summary>
[JsonProperty("country")]
public object Country {get;set;}
/// <summary>
/// 省份
/// </summary>
[JsonProperty("province")]
public object Province {get;set;}
/// <summary>
/// 城市
/// </summary>
[JsonProperty("city")]
public object City {get;set;}
/// <summary>
/// 区，乡镇
/// </summary>
[JsonProperty("town")]
public object Town {get;set;}
/// <summary>
/// 详细地址
/// </summary>
[JsonProperty("address")]
public object Address {get;set;}
/// <summary>
/// 收件人电话，仅订单状态=待发货状态下返回明文，其他状态下返回脱敏手机号，例如“1387677****”
/// </summary>
[JsonProperty("receiver_phone")]
public object ReceiverPhone {get;set;}
/// <summary>
/// 支付金额，单位：元，支付金额=商品金额-折扣金额+邮费
/// </summary>
[JsonProperty("pay_amount")]
public object PayAmount {get;set;}
/// <summary>
/// 商品金额，单位：元，商品金额=商品销售价格*商品数量-改价金额（接口暂无该字段）
/// </summary>
[JsonProperty("goods_amount")]
public object GoodsAmount {get;set;}
/// <summary>
/// 折扣金额，单位：元，折扣金额=平台优惠+商家优惠+团长免单优惠金额
/// </summary>
[JsonProperty("discount_amount")]
public object DiscountAmount {get;set;}
/// <summary>
/// 邮费，单位：元
/// </summary>
[JsonProperty("postage")]
public object Postage {get;set;}
/// <summary>
/// 支付单号
/// </summary>
[JsonProperty("pay_no")]
public object PayNo {get;set;}
/// <summary>
/// 支付类型
/// </summary>
[JsonProperty("pay_type")]
public object PayType {get;set;}
/// <summary>
/// 身份证号
/// </summary>
[JsonProperty("id_card_num")]
public object IdCardNum {get;set;}
/// <summary>
/// 身份证姓名
/// </summary>
[JsonProperty("id_card_name")]
public object IdCardName {get;set;}
/// <summary>
/// 快递公司在拼多多的代码
/// </summary>
[JsonProperty("logistics_id")]
public int LogisticsId {get;set;}
/// <summary>
/// 快递单号
/// </summary>
[JsonProperty("tracking_number")]
public object TrackingNumber {get;set;}
/// <summary>
/// 发货时间
/// </summary>
[JsonProperty("shipping_time")]
public object ShippingTime {get;set;}
/// <summary>
/// 订单状态
/// </summary>
[JsonProperty("order_status")]
public int OrderStatus {get;set;}
/// <summary>
/// 是否是抽奖订单，1否，2是
/// </summary>
[JsonProperty("is_lucky_flag")]
public int IsLuckyFlag {get;set;}
/// <summary>
/// 售后状态
/// </summary>
[JsonProperty("refund_status")]
public int RefundStatus {get;set;}
/// <summary>
/// 订单的更新时间
/// </summary>
[JsonProperty("updated_at")]
public object UpdatedAt {get;set;}
/// <summary>
/// 订单承诺发货时间
/// </summary>
[JsonProperty("last_ship_time")]
public object LastShipTime {get;set;}
/// <summary>
/// 订单备注
/// </summary>
[JsonProperty("remark")]
public object Remark {get;set;}
/// <summary>
/// 订单商品列表
/// </summary>
[JsonProperty("item_list")]
public object ItemList {get;set;}
/// <summary>
/// 平台优惠金额，单位：元
/// </summary>
[JsonProperty("platform_discount")]
public object PlatformDiscount {get;set;}
/// <summary>
/// 商家优惠金额，单位：元
/// </summary>
[JsonProperty("seller_discount")]
public object SellerDiscount {get;set;}
/// <summary>
/// 团长免单金额，单位：元
/// </summary>
[JsonProperty("capital_free_discount")]
public object CapitalFreeDiscount {get;set;}
/// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}

}

    public partial class ItemListResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品图片
/// </summary>
[JsonProperty("goods_img")]
public object GoodsImg {get;set;}
/// <summary>
/// 商品规格
/// </summary>
[JsonProperty("goods_spec")]
public object GoodsSpec {get;set;}
/// <summary>
/// 商品数量
/// </summary>
[JsonProperty("goods_count")]
public int GoodsCount {get;set;}
/// <summary>
/// 商品编码
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}
/// <summary>
/// 商品sku编码
/// </summary>
[JsonProperty("sku_id")]
public int SkuId {get;set;}
/// <summary>
/// sku维度商家外部编码，注意：编辑商品后必须等待商品审核通过后方可生效，订单中商品信息为交易快照的商品信息。
/// </summary>
[JsonProperty("outer_id")]
public object OuterId {get;set;}
/// <summary>
/// 商品维度外部编码，注意：编辑商品后必须等待商品审核通过后方可生效，订单中商品信息为交易快照的商品信息。
/// </summary>
[JsonProperty("outer_goods_id")]
public object OuterGoodsId {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}
/// <summary>
/// 商品单件
/// </summary>
[JsonProperty("goods_price")]
public object GoodsPrice {get;set;}

}

}
}