/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.RepositoryPattern;
using Easy.Serializer;
using System;
using System.Collections.Generic;
using ZKEACMS.FormGenerator.Models;

namespace ZKEACMS.FormGenerator.Service
{
    public class FormService : ServiceBase<Form, CMSDbContext>, IFormService
    {
        public FormService(IApplicationContext applicationContext, CMSDbContext dbContext) : base(applicationContext, dbContext)
        {
        }

        public override ServiceResult<Form> Add(Form item)
        {
            item.ID = Guid.NewGuid().ToString("N");
            item.FieldsData = JsonConverter.Serialize(item.FormFields);
            return base.Add(item);
        }
        public override ServiceResult<Form> Update(Form item)
        {
            item.FieldsData = JsonConverter.Serialize(item.FormFields);
            return base.Update(item);
        }
        public override Form Get(params object[] primaryKey)
        {
            var form = base.Get(primaryKey);
            if (form != null)
            {
                form.FormFields = JsonConverter.Deserialize<List<FormField>>(form.FieldsData);
            }
            return form;
        }
    }

}
