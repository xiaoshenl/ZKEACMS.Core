/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.Cache;
using Easy.Extend;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Linq;
using ZKEACMS.Article.Models;
using ZKEACMS.Article.ViewModel;
using ZKEACMS.Widget;

namespace ZKEACMS.Article.Service
{
    public class ArticleTypeWidgetService : WidgetService<ArticleTypeWidget>
    {
        private const string ArticleTypeWidgetRelatedPageUrls = "ArticleTypeWidgetRelatedPageUrls";
        private readonly ICacheManager<ArticleTypeWidgetService> _cacheManager;
        private readonly IArticleTypeService _articleTypeService;
        private readonly ISignals _signals;
        public ArticleTypeWidgetService(IWidgetBasePartService widgetService,
            IArticleTypeService articleTypeService,
            IApplicationContext applicationContext,
            ICacheManager<ArticleTypeWidgetService> cacheManager,
            CMSDbContext dbContext,
            ISignals signals)
            : base(widgetService, applicationContext, dbContext)
        {
            _articleTypeService = articleTypeService;
            _cacheManager = cacheManager;
            _signals = signals;
        }
        private void DismissRelatedPageUrls()
        {
            _cacheManager.Remove(ArticleTypeWidgetRelatedPageUrls);
        }
        public override void AddWidget(WidgetBase widget)
        {
            base.AddWidget(widget);
            DismissRelatedPageUrls();
        }

        public override void DeleteWidget(string widgetId)
        {
            base.DeleteWidget(widgetId);
            DismissRelatedPageUrls();
        }

        public override object Display(WidgetDisplayContext widgetDisplayContext)
        {
            ArticleTypeWidget currentWidget = widgetDisplayContext.Widget as ArticleTypeWidget;
            var types = _articleTypeService.Get(m => m.ParentID == currentWidget.ArticleTypeID);
            var actionContext = widgetDisplayContext.ActionContext;
            int ac = actionContext.RouteData.GetCategory();
            ArticleType articleType = null;
            if (ac > 0)
            {
                articleType = _articleTypeService.Get(ac);
            }
            if (actionContext.RouteData.GetCategoryUrl().IsNullOrEmpty() && articleType != null)
            {
                if (articleType.Url.IsNotNullAndWhiteSpace())
                {
                    actionContext.RedirectTo($"{actionContext.RouteData.GetPath()}/{articleType.Url}", true);
                }
            }
            if (articleType != null && articleType.SEOTitle.IsNotNullAndWhiteSpace())
            {
                var layout = widgetDisplayContext.PageLayout;
                if (layout != null && layout.Page != null)
                {
                    layout.Page.ConfigSEO(articleType.SEOTitle, articleType.SEOKeyWord, articleType.SEODescription);
                }
            }
            return new ArticleTypeWidgetViewModel
            {
                Widget = currentWidget,
                ArticleTypes = types,
                ArticleTypeID = ac
            };
        }

        public string[] GetRelatedPageUrls()
        {
            return _cacheManager.GetOrCreate(ArticleTypeWidgetRelatedPageUrls, factory =>
            {
                factory.AddExpirationToken(_signals.When(CacheSignals.PageUrlChanged));

                var pages = WidgetBasePartService.Get(w => Get().Select(m => m.ID).Contains(w.ID)).Select(m => m.PageId).ToArray();
                return DbContext.Page.Where(p => pages.Contains(p.ID)).Select(m => m.Url.Replace("~/", "/")).Distinct().ToArray();
            });
        }
    }
}