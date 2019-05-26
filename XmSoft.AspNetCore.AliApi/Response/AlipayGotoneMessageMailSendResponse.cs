using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayGotoneMessageMailSendResponse.
    /// </summary>
    public class AlipayGotoneMessageMailSendResponse : AliApiResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
