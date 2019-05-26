using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// CaseInfoCode Data Structure.
    /// </summary>
    [Serializable]
    public class CaseInfoCode : AliApiObject
    {
        /// <summary>
        /// 情报代码，具体见《案件情报类型代码V1》
        /// </summary>
        [XmlElement("info_code")]
        public string InfoCode { get; set; }

        /// <summary>
        /// 情报描述信息
        /// </summary>
        [XmlElement("info_code_desc")]
        public string InfoCodeDesc { get; set; }
    }
}
