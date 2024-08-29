/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using Newtonsoft.Json;
using System;

namespace ZKEACMS.DataArchived
{
    public interface IDataArchivedService : IService<DataArchived>
    {
        JsonConverter[] JsonConverters { get; set; }
        T Get<T>(string key, Func<T> fun) where T : class;
        T Get<T>(string key) where T : class;
        void Archive<T>(string key, T obj);
    }
}