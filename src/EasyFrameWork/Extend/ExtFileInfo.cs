/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.IO;

namespace Easy.Extend
{
    public static class ExtFileInfo
    {
        public static byte[] ReadAllBytes(this FileInfo fileInfo)
        {
            using (FileStream fs = fileInfo.OpenRead())
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    fs.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }
    }
}
