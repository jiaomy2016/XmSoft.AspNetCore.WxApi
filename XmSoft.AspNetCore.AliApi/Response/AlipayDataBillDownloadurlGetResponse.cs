using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDataBillDownloadurlGetResponse.
    /// </summary>
    public class AlipayDataBillDownloadurlGetResponse : AliApiResponse
    {
        /// <summary>
        /// 账单下载地址链接，获取连接后30秒后未下载，链接地址失效。
        /// </summary>
        [XmlElement("bill_download_url")]
        public string BillDownloadUrl { get; set; }
    }
}
