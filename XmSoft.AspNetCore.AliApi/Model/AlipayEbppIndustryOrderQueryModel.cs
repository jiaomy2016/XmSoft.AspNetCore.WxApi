using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppIndustryOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryOrderQueryModel : AliApiObject
    {
        /// <summary>
        /// ISV流水号，用于控制幂等，须确保全局唯一
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}