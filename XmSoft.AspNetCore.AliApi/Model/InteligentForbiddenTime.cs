using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// InteligentForbiddenTime Data Structure.
    /// </summary>
    [Serializable]
    public class InteligentForbiddenTime : AliApiObject
    {
        /// <summary>
        /// 不可用日期区间，仅支持到天  不可用区间起止日期用逗号分隔，多个区间之间用^分隔  如"2016-05-01,2016-05-03^2016-10-01,2016-10-07"表示2016年5月1日至5月3日，10月1日至10月7日券不可用
        /// </summary>
        [XmlElement("days")]
        public string Days { get; set; }
    }
}
