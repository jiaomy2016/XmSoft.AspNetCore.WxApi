using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobilePublicAccountResetResponse.
    /// </summary>
    public class AlipayMobilePublicAccountResetResponse : AliApiResponse
    {
        /// <summary>
        /// 这是新账户绑定成功后产生的协议号
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
