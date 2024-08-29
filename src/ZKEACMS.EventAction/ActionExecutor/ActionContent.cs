﻿/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using Fluid;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace ZKEACMS.EventAction.ActionExecutor
{
    public class ActionContent
    {
        private ConcurrentDictionary<string, IFluidTemplate> _templates = new ConcurrentDictionary<string, IFluidTemplate>();

        [YamlMember(Alias = "name")]
        public string Name { get; set; }

        [YamlMember(Alias = "description")]
        public string Description { get; set; }

        [YamlMember(Alias = "uses")]
        public string Uses { get; set; }

        [YamlMember(Alias = "with")]
        public Dictionary<string, string> With { get; set; }

        public Dictionary<string, string> GetRendedWith(object model)
        {
            var renderedArgs = new Dictionary<string, string>();
            if (With == null) return renderedArgs;

            foreach (var item in With)
            {
                var templateResult = ParseTemplate(item.Key, item.Value).Result;
                if (templateResult == null)
                {
                    renderedArgs[item.Key] = item.Value;
                    continue;
                }

                renderedArgs[item.Key] = templateResult.Render(model);
            }
            return renderedArgs;
        }
        public ServiceResult<IFluidTemplate> ParseTemplate(string key, string template)
        {
            var result = new ServiceResult<IFluidTemplate>();
            try
            {
                var templateResult = _templates.GetOrAdd(key, key =>
                {
                    if (!FluidTemplateHelper.TryParse(template, out var result, out var error)) throw new Exception(error);
                    return result;
                });
                result.Result = templateResult;
            }
            catch (Exception ex)
            {
                result.AddRuleViolation("With", ex.Message);
            }
            return result;
        }
        public ServiceResult ValidateWith()
        {
            var result = new ServiceResult();
            if (With == null) return result;

            foreach (var item in With)
            {
                var template = ParseTemplate(item.Key, item.Value);
                if (!template.HasViolation) continue;

                result.AddRuleViolation(template.ErrorMessage);
                break;
            }
            return result;
        }
    }
}
