using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PromoteDateModel Data Structure.
    /// </summary>
    [Serializable]
    public class PromoteDateModel : AliApiObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 推广数据
        /// </summary>
        [XmlElement("promote_data")]
        public PromoteDataModel PromoteData { get; set; }
    }
}