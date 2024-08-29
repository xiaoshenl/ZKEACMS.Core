/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace ZKEACMS
{
    public interface IApplicationContextAccessor
    {
        CMSApplicationContext Current { get; }
    }
}
