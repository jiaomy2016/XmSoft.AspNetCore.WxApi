using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicMatchuserLabelCreateResponse.
    /// </summary>
    public class AlipayOpenPublicMatchuserLabelCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 用户打标失败数量
        /// </summary>
        [XmlElement("error_count")]
        public long ErrorCount { get; set; }

        /// <summary>
        /// 出错的匹配器列表
        /// </summary>
        [XmlArray("error_matchers")]
        [XmlArrayItem("error_matcher")]
        public List<ErrorMatcher> ErrorMatchers { get; set; }
    }
}