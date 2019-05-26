using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayBossFncInvoiceBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoiceBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 开票申请ID，唯一标识开票申请表的ID
        /// </summary>
        [XmlElement("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 买方发票抬头，用于打印在发票上
        /// </summary>
        [XmlElement("buyer_invoice_title")]
        public string BuyerInvoiceTitle { get; set; }

        /// <summary>
        /// 对应发票商户的ipId，在主站标示mid，在其他环境标示ip_id。
        /// </summary>
        [XmlElement("buyer_ipid")]
        public string BuyerIpid { get; set; }

        /// <summary>
        /// 购方商户ID集合
        /// </summary>
        [XmlArray("buyer_ipids")]
        [XmlArrayItem("string")]
        public List<string> BuyerIpids { get; set; }

        /// <summary>
        /// 商户结算的ipRoleId，表示商户的结算对象，在主站表示pid。
        /// </summary>
        [XmlElement("buyer_iprole_id")]
        public string BuyerIproleId { get; set; }

        /// <summary>
        /// 购方PID集合
        /// </summary>
        [XmlArray("buyer_iprole_ids")]
        [XmlArrayItem("string")]
        public List<string> BuyerIproleIds { get; set; }

        /// <summary>
        /// 对应发票所在OU的id，用于标示该发票所述的OU。
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 开票渠道 01 线上;02 线下
        /// </summary>
        [XmlElement("invoice_channel")]
        public string InvoiceChannel { get; set; }

        /// <summary>
        /// 发票代码，税务部门给予发票的编码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票创建日期【起始日期，格式yyyyMMdd】
        /// </summary>
        [XmlElement("invoice_create_date_begin")]
        public string InvoiceCreateDateBegin { get; set; }

        /// <summary>
        /// 发票创建日期【结束日期，格式yyyyMMdd】
        /// </summary>
        [XmlElement("invoice_create_date_end")]
        public string InvoiceCreateDateEnd { get; set; }

        /// <summary>
        /// 发票ID集合，发票ID，唯一标示一张发票的ID
        /// </summary>
        [XmlArray("invoice_ids")]
        [XmlArrayItem("string")]
        public List<string> InvoiceIds { get; set; }

        /// <summary>
        /// 开票介质 01电子 02纸质
        /// </summary>
        [XmlElement("invoice_material")]
        public string InvoiceMaterial { get; set; }

        /// <summary>
        /// 发票号码，税务部门给予发票的编码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票开票日期【起始日期，格式yyyyMMdd】
        /// </summary>
        [XmlElement("invoice_open_date_begin")]
        public string InvoiceOpenDateBegin { get; set; }

        /// <summary>
        /// 发票开票日期【结束日期，格式yyyyMMdd】
        /// </summary>
        [XmlElement("invoice_open_date_end")]
        public string InvoiceOpenDateEnd { get; set; }

        /// <summary>
        /// 发票状态：用于标示发票当前的状态，状态类型以及相关含义：01 待开票;02 开票中;03 已开票;04 作废中;05 已作废;06 红冲中;07 已红冲;08 部分红冲;09 无效
        /// </summary>
        [XmlArray("invoice_status")]
        [XmlArrayItem("string")]
        public List<string> InvoiceStatus { get; set; }

        /// <summary>
        /// 发票类型,01专票 02普票 03营业税发票 04国际形式发票 05其它发票
        /// </summary>
        [XmlArray("invoice_types")]
        [XmlArrayItem("string")]
        public List<string> InvoiceTypes { get; set; }

        /// <summary>
        /// 是否能在线开票 Y能 N不能
        /// </summary>
        [XmlElement("is_online")]
        public string IsOnline { get; set; }

        /// <summary>
        /// 是否红字 Y红字 N蓝字
        /// </summary>
        [XmlElement("is_red")]
        public string IsRed { get; set; }

        /// <summary>
        /// 邮寄状态 01 待邮寄;02 已邮寄;03 退回中;04 已退回
        /// </summary>
        [XmlArray("mail_status")]
        [XmlArrayItem("string")]
        public List<string> MailStatus { get; set; }

        /// <summary>
        /// 月账单号
        /// </summary>
        [XmlElement("monthly_bill_no")]
        public string MonthlyBillNo { get; set; }

        /// <summary>
        /// 起始页，分页时必须提供
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页显示数，分页时必须提供
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("tracking_no")]
        public string TrackingNo { get; set; }
    }
}
