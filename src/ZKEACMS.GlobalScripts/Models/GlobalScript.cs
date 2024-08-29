/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace ZKEACMS.GlobalScripts.Models
{
    public class GlobalScript
    {
        public int Location { get; set; }
        public string Script { get; set; }
    }
    public enum ScriptLocation
    {
        Header = 1,
        Footer = 2
    }
}
