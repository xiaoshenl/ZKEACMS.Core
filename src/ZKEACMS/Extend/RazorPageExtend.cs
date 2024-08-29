/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace ZKEACMS
{
    public static class RazorPageExtend
    {
        public static CMSApplicationContext WorkContext<T>(this Easy.Mvc.RazorPages.EasyRazorPage<T> page)
        {
            return page.ApplicationContext.CurrentAppContext();
        }
    }
}
