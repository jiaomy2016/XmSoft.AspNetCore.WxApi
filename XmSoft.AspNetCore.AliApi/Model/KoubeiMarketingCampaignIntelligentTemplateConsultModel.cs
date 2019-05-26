using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentTemplateConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignIntelligentTemplateConsultModel : AliApiObject
    {
        /// <summary>
        /// 根据不同场景,过滤不同的门店数据,可参考值:CREATE_NORMAL:正常创建;RENEWAL_OLD:原方案续期;RENEWAL_NEW:新方案续期
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [XmlElement("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 结合biz_scene一起使用,值为RENEWAL_OLD:原方案续期、RENEWAL_NEW:新方案续期,要求必传
        /// </summary>
        [XmlElement("promo_id")]
        public string PromoId { get; set; }

        /// <summary>
        /// 默认(不传shop_ids门店)使用待体验门店匹配适用模板，指定门店列表(shop_ids)后根据入参匹配适用模板
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
