using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// Contract Data Structure.
    /// </summary>
    [Serializable]
    public class Contract : AliApiObject
    {
        /// <summary>
        /// 合约文本内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 合约标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 合约类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}