using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorScriptQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorScriptQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 脚本内容，智能卡中心自定义的脚本格式内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 脚本更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }
    }
}
