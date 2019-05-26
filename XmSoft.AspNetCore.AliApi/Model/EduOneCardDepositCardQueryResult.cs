using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// EduOneCardDepositCardQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class EduOneCardDepositCardQueryResult : AliApiObject
    {
        /// <summary>
        /// 校园一卡通机构代码
        /// </summary>
        [XmlElement("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 校园一卡通机构姓名
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 校园一卡通余额
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 校园一卡通姓名
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 校园一卡通卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 余额最后更新时间
        /// </summary>
        [XmlElement("last_update_time")]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// 校园一卡通待领金额
        /// </summary>
        [XmlElement("pound_amount")]
        public string PoundAmount { get; set; }
    }
}
