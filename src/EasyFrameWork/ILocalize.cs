/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace Easy
{
    public interface ILocalize
    {
        string Get(string content);
        string Get(string content, string culture);

        string GetOrNull(string content);
        string GetOrNull(string content, string culture);
    }
}
