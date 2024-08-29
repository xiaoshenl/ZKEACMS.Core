/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.MetaData;

namespace ZKEACMS.Common.Models
{
    public class Robots
    {
        public string Content { get; set; }
    }
    class RobotsMetaData : ViewMetaData<Robots>
    {
        protected override void ViewConfigure()
        {
            ViewConfig(m => m.Content).AsTextArea();
        }
    }
}
