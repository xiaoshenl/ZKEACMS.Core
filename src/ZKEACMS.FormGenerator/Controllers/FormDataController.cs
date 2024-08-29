/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.Extend;
using Easy.Mvc.Authorize;
using Easy.Mvc.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZKEACMS.Filter;
using ZKEACMS.FormGenerator.Models;
using ZKEACMS.FormGenerator.Service;

namespace ZKEACMS.FormGenerator.Controllers
{
    [DefaultAuthorize(Policy = PermissionKeys.ViewFormData)]
    public class FormDataController : BasicController<FormData, int, IFormDataService>
    {
        private const string ExcelContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        private readonly ILocalize _localize;
        public FormDataController(IFormDataService service, ILocalize localize) : base(service)
        {
            _localize = localize;
        }

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken, RenderRefererPage]
        public IActionResult Submit(string FormId)
        {
            if (FormId.IsNullOrWhiteSpace()) return BadRequest();

            var result = Service.SaveForm(Request.Form, FormId);
            ModelState.Merge(result);
            if (!result.HasViolation)
            {
                TempData["Message"] = _localize.Get("Form have submited");
            }
            return View(result.Result.Form);
        }

        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ManageFormData)]
        public override IActionResult Delete(int id)
        {
            return base.Delete(id);
        }
        [DefaultAuthorize(Policy = PermissionKeys.ExportFormData)]
        public IActionResult Export(int id)
        {
            return File(Service.Export(id), ExcelContentType);
        }
        [DefaultAuthorize(Policy = PermissionKeys.ExportFormData)]
        public IActionResult ExportForm(string id)
        {
            return File(Service.ExportByForm(id), ExcelContentType);
        }
    }
}
