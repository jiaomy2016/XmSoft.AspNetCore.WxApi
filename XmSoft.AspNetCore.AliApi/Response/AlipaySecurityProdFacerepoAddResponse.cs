using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityProdFacerepoAddResponse.
    /// </summary>
    public class AlipaySecurityProdFacerepoAddResponse : AliApiResponse
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 对此次插入人脸库分组的人脸id标识
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }
    }
}