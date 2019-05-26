using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayUserAuthUserinfoApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAuthUserinfoApplyModel : AliApiObject
    {
        /// <summary>
        /// 业务号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展数据
        /// </summary>
        [XmlElement("ext_data")]
        public string ExtData { get; set; }
    }
}
