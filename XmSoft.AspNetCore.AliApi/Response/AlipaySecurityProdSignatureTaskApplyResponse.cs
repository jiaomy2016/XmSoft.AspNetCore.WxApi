using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityProdSignatureTaskApplyResponse.
    /// </summary>
    public class AlipaySecurityProdSignatureTaskApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 签约订单id，关联了若干个签约任务id。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 签约认证任务列表
        /// </summary>
        [XmlArray("task_list")]
        [XmlArrayItem("sign_task_result")]
        public List<SignTaskResult> TaskList { get; set; }
    }
}
