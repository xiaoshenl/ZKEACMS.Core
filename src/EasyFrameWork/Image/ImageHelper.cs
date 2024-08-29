/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace Easy.Image
{
    public class ImageHelper
    {
        public static bool IsImage(string extension)
        {
            return Mvc.Common.IsImage(extension);
        }
    }
}
