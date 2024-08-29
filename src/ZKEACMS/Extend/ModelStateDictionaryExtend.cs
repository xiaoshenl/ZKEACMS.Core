/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ZKEACMS
{
    public static class ModelStateDictionaryExtend
    {
        public static void Merge<T>(this ModelStateDictionary modelState, ServiceResult<T> serviceResult)
        {
            foreach (var item in serviceResult.RuleViolations)
            {
                modelState.AddModelError(item.ParameterName, item.ErrorMessage);
            }
        }
        public static void AddUnknownError(this ModelStateDictionary modelState, string message)
        {
            modelState.AddModelError("Unknown", message);
        }
    }
}
