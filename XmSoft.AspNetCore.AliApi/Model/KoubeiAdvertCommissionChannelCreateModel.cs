using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionChannelCreateModel : AliApiObject
    {
        /// <summary>
        /// 新增渠道列表
        /// </summary>
        [XmlArray("channels")]
        [XmlArrayItem("kb_advert_add_channel_request")]
        public List<KbAdvertAddChannelRequest> Channels { get; set; }
    }
}
