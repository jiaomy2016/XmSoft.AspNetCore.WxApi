using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// IpAddrLbsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IpAddrLbsInfo : AliApiObject
    {
        /// <summary>
        /// IP地址归属地所以城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// IP归属地所在的省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
