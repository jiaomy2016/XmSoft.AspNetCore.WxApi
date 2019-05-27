using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// BrandLevelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BrandLevelInfo : AliApiObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 当前品牌所属级别
        /// </summary>
        [XmlElement("brand_level")]
        public long BrandLevel { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }
    }
}