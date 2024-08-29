/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.Extend;
using Easy.RepositoryPattern;
using System.Collections.Generic;
using ZKEACMS.Common.Service;
using ZKEACMS.Extend;
using ZKEACMS.MetaData;
using ZKEACMS.Widget;

namespace ZKEACMS.Common.Models
{
    [DataTable("NavigationWidget")]
    public class NavigationWidget : BasicWidget
    {
        public string Logo { get; set; }
        public string CustomerClass { get; set; }
        public string AlignClass { get; set; }
        public bool? IsTopFix { get; set; }
        public string RootID { get; set; }
        public bool? ShowBasket { get; set; }
    }
    class NavigationWidgetMetaData : WidgetMetaData<NavigationWidget>
    {
        protected override void ViewConfigure()
        {
            base.ViewConfigure();
            ViewConfig(m => m.Title).AsHidden();
            ViewConfig(m => m.CustomerClass).AsDropDownList().DataSource(() =>
            {
                return new Dictionary<string, string>
                {
                     {"container","container"},
                     {"container-fluid","container-fluid"}
                };
            }).Order(NextOrder());
            ViewConfig(m => m.AlignClass).AsDropDownList().DataSource(() =>
            {
                return new Dictionary<string, string>
                {
                     {"navbar-left","navbar-left"},
                     {"navbar-right","navbar-right"}
                };
            }).Order(NextOrder());
            ViewConfig(m => m.IsTopFix).AsHidden();
            ViewConfig(m => m.Logo).AsTextBox().Order(NextOrder()).MediaSelector();
            ViewConfig(m => m.RootID).AsDropDownList().Order(NextOrder()).AddClass("select").AddProperty("data-url", "/admin/Navigation/Select").DataSource(() =>
            {
                Dictionary<string, string> navigations = new Dictionary<string, string>();
                navigations.Add("root", "Navigation");
                ServiceLocator.GetService<INavigationService>().Get().Each(navigation =>
                {
                    navigations.Add(navigation.ID, navigation.Title);
                });
                return navigations;
            });
        }
    }

}