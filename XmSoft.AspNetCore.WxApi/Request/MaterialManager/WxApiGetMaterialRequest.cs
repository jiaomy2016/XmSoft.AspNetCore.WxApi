﻿using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.MaterialManager;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request.MaterialManager
{
    /// <summary>
    /// 获取永久素材
    /// </summary>
    public class WxApiGetMaterialRequest : IWxApiRequest<WxApiGetMaterialResponse>
    {
        /// <summary>
        ///获取永久素材 - 公众平台
        /// </summary>
        public WxApiGetMaterialRequest()
        {

        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 素材ID
        /// </summary>
        public string Media_id { get; set; }
       


        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/material/get_material";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "media_id", Media_id }
               

            };
            return parameters;
        }

        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
    

}
