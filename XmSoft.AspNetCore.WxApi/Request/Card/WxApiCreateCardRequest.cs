﻿using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request
{
    /// <summary>
    /// 创建卡券
    /// </summary>
    public class WxApiCreateCardRequest : IWxApiRequest<WxApiCreateCardResponse>
    {
        /// <summary>
        /// 创建卡券 -- 公众平台
        /// </summary>
        public WxApiCreateCardRequest()
        {
           
        }
        public string AccessToken { get; set; }
       
        public CardGroupon groupon { get; set; }

        public CardCash cash { get; set; }

        public CardDiscount discount { get; set; }

        public CardGeneralCoupon generalCoupon { get; set; }

        public CardGift gift { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/card/create";
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "card",groupon != null ? JsonConvert.SerializeObject(groupon)
                :gift != null ? JsonConvert.SerializeObject(gift)
                :cash != null ? JsonConvert.SerializeObject(cash)
                :discount != null ? JsonConvert.SerializeObject(discount)
                :JsonConvert.SerializeObject(generalCoupon) }
            };
            return parameters;
        }
        /// <summary>
        /// 请求方式 Post Or Get
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
}