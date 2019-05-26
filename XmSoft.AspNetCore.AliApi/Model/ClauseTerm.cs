using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ClauseTerm Data Structure.
    /// </summary>
    [Serializable]
    public class ClauseTerm : AliApiObject
    {
        /// <summary>
        /// 说明描述内容
        /// </summary>
        [XmlArray("descriptions")]
        [XmlArrayItem("string")]
        public List<string> Descriptions { get; set; }

        /// <summary>
        /// 说明title
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
