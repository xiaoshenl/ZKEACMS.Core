/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.MetaData;
using System.Collections.Generic;

namespace ZKEACMS.GlobalScripts.Models
{
    public class LiveChatScript : GlobalScript
    {
    }
    class LiveChatScriptMetaData : ViewMetaData<LiveChatScript>
    {
        protected override void ViewConfigure()
        {
            ViewConfig(m => m.Location).AsDropDownList().DataSource(() =>
            {
                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add(ScriptLocation.Footer.ToString("D"), "Head");
                data.Add(ScriptLocation.Header.ToString("D"), "Foot");
                return data;
            });
            ViewConfig(m => m.Script).AsTextArea();
        }
    }
}
