/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.AspNetCore.Html;
using ZKEACMS.Event;
using ZKEACMS.Setting;

namespace ZKEACMS.Animation.Service
{
    public sealed class AnimationScriptsService : IEventHandler
    {
        private readonly IApplicationContextAccessor _applicationContextAccessor;
        private readonly IApplicationSettingService _applicationSettingService;

        public AnimationScriptsService(IApplicationContextAccessor applicationContextAccessor,
            IApplicationSettingService applicationSettingService)
        {
            _applicationContextAccessor = applicationContextAccessor;
            _applicationSettingService = applicationSettingService;
        }

        public void Handle(object entity, EventArg e)
        {
            if (_applicationSettingService.Get("Animation_Widget_FadeInUp", "false") == "true")
            {
                CMSApplicationContext applicationContext = _applicationContextAccessor.Current;
                HtmlContentBuilder styleBuilder = new HtmlContentBuilder();
                HtmlContentBuilder scriptBuilder = new HtmlContentBuilder();
#if DEBUG
                styleBuilder.AppendHtml("<link type=\"text/css\" async rel=\"stylesheet\" href=\"/Plugins/ZKEACMS.Animation/Content/animate.css\" />");
                scriptBuilder.AppendHtml("<script type=\"text/javascript\" src=\"/Plugins/ZKEACMS.Animation/Scripts/animate.js\"></script>");
#else
                styleBuilder.AppendHtml("<link type=\"text/css\" async rel=\"stylesheet\" href=\"/Plugins/ZKEACMS.Animation/Content/animate.min.css\" />");
                scriptBuilder.AppendHtml("<script type=\"text/javascript\" src=\"/Plugins/ZKEACMS.Animation/Scripts/animate.min.js\" ></script>");
#endif
                applicationContext.HeaderPart.Add(styleBuilder);
                applicationContext.FooterPart.Add(scriptBuilder);
            }
        }
    }
}
