﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.NearbyPoi
{
    public class WxApiSetShowStatusNearbyPoiResponse : WxApiResponse
    {

        [JsonProperty(PropertyName = "errcode")]
        public int ErrCode { get; set; }

        [JsonProperty(PropertyName = "errmsg")]
        public string Errmsg { get; set; }
    }
    
}