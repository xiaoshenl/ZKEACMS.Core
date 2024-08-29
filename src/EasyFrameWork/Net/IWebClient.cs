/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System;
using System.IO;
using System.Threading.Tasks;

namespace Easy.Net
{
    public interface IWebClient : IDisposable
    {
        void SetHeader(string name, string value);
        void RemoveHeader(string name, string value);
        Task<byte[]> DownloadDataAsync(string requestUri);
        Task<string> DownloadStringAsync(string requestUri);
        Task<Stream> GetStreamAsync(string requestUri);
    }
}
