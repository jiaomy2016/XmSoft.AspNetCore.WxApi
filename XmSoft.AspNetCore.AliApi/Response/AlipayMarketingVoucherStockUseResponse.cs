using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingVoucherStockUseResponse.
    /// </summary>
    public class AlipayMarketingVoucherStockUseResponse : AliApiResponse
    {
        /// <summary>
        /// 返回如果为空，说明没有核销成功；如果不为空，长度一定是28，表示的是核销序号。该值唯一对应一个券码，即入参中的entity_no
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
