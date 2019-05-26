using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayUserPrincipalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPrincipalInfo : AliApiObject
    {
        /// <summary>
        /// 用户电子邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 用户的手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
