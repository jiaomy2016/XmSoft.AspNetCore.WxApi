using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcapiprodDrawndnFeerecordQueryResponse.
    /// </summary>
    public class AlipayEcapiprodDrawndnFeerecordQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 费用交易流水
        /// </summary>
        [XmlArray("fee_records")]
        [XmlArrayItem("fee_records")]
        public List<FeeRecords> FeeRecords { get; set; }

        /// <summary>
        /// 唯一标识这次请求
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
