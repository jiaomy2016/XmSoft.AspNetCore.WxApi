using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppMerchantConfigGetResponse.
    /// </summary>
    public class AlipayEbppMerchantConfigGetResponse : AliApiResponse
    {
        /// <summary>
        /// 商户机构配置信息
        /// </summary>
        [XmlArray("inst_configs")]
        [XmlArrayItem("merchant_inst_config")]
        public List<MerchantInstConfig> InstConfigs { get; set; }

        /// <summary>
        /// 商户的用户ID
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }
    }
}
