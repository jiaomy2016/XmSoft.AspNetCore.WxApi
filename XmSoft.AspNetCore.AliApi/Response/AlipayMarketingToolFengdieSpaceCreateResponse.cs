using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSpaceCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSpaceCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 创建成功后返回空间的基本信息，包含空间 ID、标题、创建时间与可用域名列表
        /// </summary>
        [XmlElement("data")]
        public FengdieSpaceDetailModel Data { get; set; }
    }
}
