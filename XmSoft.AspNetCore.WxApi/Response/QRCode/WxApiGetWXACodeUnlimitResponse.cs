﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.QRCode
{
    public class WxApiGetWXACodeUnlimitResponse : WxApiResponse
    {

        [JsonProperty(PropertyName = "buffer")]
        public byte[] Buffer { get; set; }


        [JsonProperty(PropertyName = "errcode")]
        public int ErrCode { get; set; }

        [JsonProperty(PropertyName = "errmsg")]
        public string Errmsg { get; set; }
    }
}