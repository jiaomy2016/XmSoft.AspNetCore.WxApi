using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// CardDomainVO Data Structure.
    /// </summary>
    [Serializable]
    public class CardDomainVO : AliApiObject
    {
        /// <summary>
        /// 值域域名的描述值，固定为”金融”
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 值域域名，固定为“FINANCE”
        /// </summary>
        [XmlElement("domain_name")]
        public string DomainName { get; set; }
    }
}
