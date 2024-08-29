/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace ZKEACMS.Safety
{
    public interface IHtmlSanitizer
    {
        string Sanitize(string html);
    }
}
