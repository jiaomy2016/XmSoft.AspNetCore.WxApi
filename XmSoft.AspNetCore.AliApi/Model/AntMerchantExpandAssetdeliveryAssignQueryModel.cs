using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AntMerchantExpandAssetdeliveryAssignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetdeliveryAssignQueryModel : AliApiObject
    {
        /// <summary>
        /// 每次拉取最大记录数量，可选值为[1,200] ;
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
