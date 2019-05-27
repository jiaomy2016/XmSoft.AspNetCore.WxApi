using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// Advert Data Structure.
    /// </summary>
    [Serializable]
    public class Advert : AliApiObject
    {
        /// <summary>
        /// 广告位id
        /// </summary>
        [XmlElement("advert_id")]
        public string AdvertId { get; set; }

        /// <summary>
        /// 广告位轮播内容列表
        /// </summary>
        [XmlArray("advert_items")]
        [XmlArrayItem("advert_item")]
        public List<AdvertItem> AdvertItems { get; set; }
    }
}