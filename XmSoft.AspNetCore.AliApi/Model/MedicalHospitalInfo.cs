using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MedicalHospitalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalHospitalInfo : AliApiObject
    {
        /// <summary>
        /// 医院唯一标识，编码开发者生成并保证唯一
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 医院联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}