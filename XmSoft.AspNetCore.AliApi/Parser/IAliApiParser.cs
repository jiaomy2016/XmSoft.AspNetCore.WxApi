﻿using System;
using XmSoft.AspNetCore.AliApi.Request;

namespace XmSoft.AspNetCore.AliApi.Parser
{
    /// <summary>
    /// AliApi API响应解释器接口。响应格式可以是XML, JSON等等。
    /// </summary>
    /// <typeparam name="T">领域对象</typeparam>
    public interface IAliApiParser<T> where T : AliApiResponse
    {        
        /// <summary>
        /// 把响应字符串解释成相应的领域对象。
        /// </summary>
        /// <param name="body">响应字符串</param>
        /// <returns>领域对象</returns>
        T Parse(string body,string charset);

        /// <summary>
        /// 解析签名内容
        /// </summary>
        /// <param name="request"></param>
        /// <param name="responseBody"></param>
        /// <returns></returns>
        SignItem GetSignItem(IAliApiRequest<T> request, string responseBody);


        /// <summary>
        /// 将响应串解密
        /// </summary>
        /// <param name="request"></param>
        /// <param name="body"></param>
        /// <param name="encryptType"></param>
        /// <param name="encryptKey"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        string EncryptSourceData(IAliApiRequest<T> request, string body, string encryptType, string encryptKey, string charset);
    }
}
