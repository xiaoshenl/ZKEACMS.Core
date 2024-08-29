/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.AspNetCore.Mvc.ModelBinding;
using ZKEACMS.Widget;

namespace ZKEACMS.ModelBinder
{
    public class WidgetTypeModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (typeof(BasicWidget).IsAssignableFrom(context.Metadata.ModelType))
            {
                return new WidgetTypeModelBinder(context);
            }
            return null;
        }
    }
}
