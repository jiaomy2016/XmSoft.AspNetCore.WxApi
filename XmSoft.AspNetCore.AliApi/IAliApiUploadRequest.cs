﻿using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Util;

namespace XmSoft.AspNetCore.AliApi
{
    /// <summary>
    /// AliApi上传请求接口，支持同时上传多个文件。
    /// </summary>
    public interface IAliApiUploadRequest<T> : IAliApiRequest<T> where T : AliApiResponse
    {
        /// <summary>
        /// 获取所有的Key-Value形式的文件请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 文件对象
        /// </summary>
        /// <returns>文件请求参数字典</returns>
        IDictionary<string, FileItem> GetFileParameters();
    }
}