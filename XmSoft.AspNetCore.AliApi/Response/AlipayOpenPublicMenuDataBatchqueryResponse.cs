using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicMenuDataBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicMenuDataBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 菜单分析数据列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("menu_analysis_data")]
        public List<MenuAnalysisData> DataList { get; set; }
    }
}
