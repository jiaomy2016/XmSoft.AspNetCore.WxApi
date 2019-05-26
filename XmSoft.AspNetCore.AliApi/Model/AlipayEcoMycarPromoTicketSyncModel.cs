using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoMycarPromoTicketSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarPromoTicketSyncModel : AliApiObject
    {
        /// <summary>
        /// 营销活动ID
        /// </summary>
        [XmlElement("active_id")]
        public string ActiveId { get; set; }

        /// <summary>
        /// 需要同步的卡券信息
        /// </summary>
        [XmlArray("code_no_list")]
        [XmlArrayItem("code_n_o_list")]
        public List<CodeNOList> CodeNoList { get; set; }

        /// <summary>
        /// 卡券来源
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }
    }
}
