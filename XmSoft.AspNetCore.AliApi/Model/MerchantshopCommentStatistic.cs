using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MerchantshopCommentStatistic Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantshopCommentStatistic : AliApiObject
    {
        /// <summary>
        /// 评论总数
        /// </summary>
        [XmlElement("comment_count")]
        public long CommentCount { get; set; }

        /// <summary>
        /// 评分（平均分），两位小数
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }
    }
}
