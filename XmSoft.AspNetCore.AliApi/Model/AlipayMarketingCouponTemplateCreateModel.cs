using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingCouponTemplateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCouponTemplateCreateModel : AliApiObject
    {
        /// <summary>
        /// 创建红包模板时录入的品牌信息，由商户自定义，在通用模板中展示在红包LOGO下方。根据红包使用场景的不同，该信息的展示位置可能会有不同。
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 扩展字段,JSON字符串。目前支持使用模式扩展：{"coupon_AppActiveUrl":"http://www.yourdomain.com"},yourdomain.com需要添加白名单
        /// </summary>
        [XmlElement("extension_info")]
        public string ExtensionInfo { get; set; }

        /// <summary>
        /// 最低额度。设置红包使用门槛，只有订单金额大于等于最低额度时红包才能使用。币种为人民币，单位为元。该数值不能小于等于0，小数点以后最多保留两位，没有则设置为0。
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 出资人登录账号。用于发红包的资金会从该账号划拨到发红包专用账户上。当调用创建接口成功后，会返回付款订单页面，仅当前传入资金账号可进行付款，付款完成后红包变更为激活状态，可进行发放。
        /// </summary>
        [XmlElement("fund_account")]
        public string FundAccount { get; set; }

        /// <summary>
        /// 红包变动异步通知地址，传入此字段后，红包的核销将会进行异步通知，通知具体内容见下方触发异步通知字段描述
        /// </summary>
        [XmlElement("notify_uri")]
        public string NotifyUri { get; set; }

        /// <summary>
        /// 外部业务单号。用作幂等控制。同一个pid下相同的外部业务单号作唯一键，参数不变的情况下，再次请求返回同样的模板id。请求成功后，修改参数再次提交，需要更换订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 发放结束时间，晚于该时间不能发红包。红包的发放结束时间和发放开始时间跨度不能大于90天。发放结束时间必须晚于发放开始时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 发放开始时间，早于该时间不能发红包。发放开始时间不能大于当前时间15天。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 重定向地址。支付成功后需要重定向的地址，如果为空则不做重定向。
        /// </summary>
        [XmlElement("redirect_uri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// 规则配置，JSON字符串，格式为K-V模式，当同一个KEY下规则为多个值时，用英文逗号进行分隔。目前支持的规则KEY有：核销商户ID(PID),核销内部门店ID(STORE),指定收款账户(payeeUserId),子产品交易码(bizProduct),缴费机构/类型(CUSTOMBUSINESS),缴费户号(EBPPUSERNUM)。一旦商户设置了规则，当前红包实例必须满足指定规则才能进行核销。
        /// </summary>
        [XmlElement("rule_conf")]
        public string RuleConf { get; set; }

        /// <summary>
        /// 模板总金额。本次发放模板设置的总金额。币种为人民币，单位为元。该数值不能小于1.00元，小数点以后最多保留两位。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 红包使用说明。JSON数组字符串，最多可以有10条，每条最多50字。如果未传入该字段，将填充为默认描述
        /// </summary>
        [XmlElement("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 类型。可枚举，暂时只支持"红包"(COUPON)，使用示例voucher_type=COUPON。红包可以拆分多次使用，比如：1元红包，可以先用掉0.5元，剩余的0.5元可以继续使用；可以多个红包叠加使用，一笔支付最多叠加10个红包；红包被使用后发生退款，如果红包有效期还在，会退还给用户红包，如果有效期已过，就会将资金退回原红包模板出资账户。
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 红包使用场景。可枚举，目前支持“支付宝通用全场红包”(ALIPAY_COUPON_ALL) ，该场景设置后，使用规则字段允许为空，只要支付宝支付产品支持核销此类型的红包，用户红包就可以核销。“花呗还款红包”(HUABEI_COUPON_REPAYMENT) ，该场景设置后，会自动填充花呗还款对应的规则，无需填入rule_conf，代表仅花呗还款场景可以核销此红包。“支付宝普通红包”(ALIPAY_COUPON_COMMON) 该场景下必须设置一条规则rule_conf。场景值会关联当前红包的展示模板，默认描述等信息。
        /// </summary>
        [XmlElement("voucher_use_scene")]
        public string VoucherUseScene { get; set; }

        /// <summary>
        /// "ABSOLUTE", "start": "2017-01-10 00:00:00", "end": "2017-01-13 23:59:59"}。相对时间有3个key：type、duration、unit，type取值固定为"RELATIVE"，duration表示从发红包时间开始到往后推duration个单位时间为止作为红包的使用有效期，unit表示有效时间单位，有效时间单位可枚举：MINUTE, HOUR, DAY。示例：{"type": "RELATIVE", "duration": 1 , "unit": "DAY" }，如果此刻发红包，那么该红包从现在开始生效1(duration)天(unit)后失效。
        /// </summary>
        [XmlElement("voucher_valid_period")]
        public string VoucherValidPeriod { get; set; }
    }
}
