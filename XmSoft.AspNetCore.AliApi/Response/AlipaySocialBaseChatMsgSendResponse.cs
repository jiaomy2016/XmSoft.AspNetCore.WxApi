using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySocialBaseChatMsgSendResponse.
    /// </summary>
    public class AlipaySocialBaseChatMsgSendResponse : AliApiResponse
    {
        /// <summary>
        /// 消息索引号 会话ID_消息ID
        /// </summary>
        [XmlElement("msg_index")]
        public string MsgIndex { get; set; }
    }
}
