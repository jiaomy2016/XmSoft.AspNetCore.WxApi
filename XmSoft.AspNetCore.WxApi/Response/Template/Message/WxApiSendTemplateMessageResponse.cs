﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Template.Message
{
    public class WxApiSendTemplateMessageResponse : WxApiResponse
    {
       public string msgid { get; set; }
    }
}
