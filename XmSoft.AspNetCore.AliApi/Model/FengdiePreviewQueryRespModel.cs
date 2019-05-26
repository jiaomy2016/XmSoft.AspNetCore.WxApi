using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// FengdiePreviewQueryRespModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdiePreviewQueryRespModel : AliApiObject
    {
        /// <summary>
        /// 云凤蝶页面预览数据列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("fengdie_preview_pages_model")]
        public List<FengdiePreviewPagesModel> List { get; set; }
    }
}
