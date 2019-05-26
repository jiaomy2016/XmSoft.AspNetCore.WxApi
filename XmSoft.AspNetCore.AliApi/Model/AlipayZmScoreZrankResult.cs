using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayZmScoreZrankResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayZmScoreZrankResult : AliApiObject
    {
        /// <summary>
        /// 芝麻分分段 Z0-Z7
        /// </summary>
        [XmlElement("zrank")]
        public string Zrank { get; set; }
    }
}
