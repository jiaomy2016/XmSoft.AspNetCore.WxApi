using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorShopQueryResponse.
    /// </summary>
    public class KoubeiMerchantOperatorShopQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 操作员关联的门店模型列表
        /// </summary>
        [XmlArray("city_shop_models")]
        [XmlArrayItem("city_shop_model")]
        public List<CityShopModel> CityShopModels { get; set; }
    }
}
