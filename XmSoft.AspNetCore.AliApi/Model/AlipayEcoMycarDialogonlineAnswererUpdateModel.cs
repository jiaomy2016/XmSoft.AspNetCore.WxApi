using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoMycarDialogonlineAnswererUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDialogonlineAnswererUpdateModel : AliApiObject
    {
        /// <summary>
        /// 技师ID
        /// </summary>
        [XmlElement("answer_id")]
        public string AnswerId { get; set; }

        /// <summary>
        /// 技师状态，0：可用，1：停用
        /// </summary>
        [XmlElement("answer_status")]
        public string AnswerStatus { get; set; }
    }
}
