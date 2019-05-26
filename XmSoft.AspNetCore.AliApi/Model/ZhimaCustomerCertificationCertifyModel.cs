using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhimaCustomerCertificationCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerCertificationCertifyModel : AliApiObject
    {
        /// <summary>
        /// 一次认证的唯一标识，在完成芝麻认证初始化后可以获取
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
