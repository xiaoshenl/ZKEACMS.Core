/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace ZKEACMS.Updater.Models
{
    public class ReleaseVersion
    {
        public string Version { get; set; }
        public VersionInfo[] Versions { get; set; }
    }
}
