using Application.Common;
using Application.Dtos.Role;
using Application.Exceptions;
using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    //[Authorize(Policy = Policies.EndpointAccess)]
    public class RoleController(IRoleService roleService, IFunctionService functionService) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(GetListRoleRequest request)
        {
            if (!ModelState.IsValid)
            {
                var errorMessage = ModelState.Values
                    .SelectMany(v => v.Errors).FirstOrDefault()?.ErrorMessage;

                TempData["ErrorToast"] = errorMessage ?? "Dữ liệu tìm kiếm không hợp lệ";
                return View(new PaginatedList<RoleVm>(0, new List<RoleVm>()));
            }

            var listRole = await roleService.GetList(request);
            return View(listRole);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.AllFunctions = await functionService.GetAllFunctionsGroupedByCategory();
            return PartialView("_CreateRoleForm");

        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRoleRequest request)
        {
            if (!ModelState.IsValid)
            {

                ViewBag.AllFunctions = await functionService.GetAllFunctionsGroupedByCategory();
                return PartialView("_CreateRoleForm", request);
            }

            try
            {
                await roleService.Create(request);
                TempData["SuccessToast"] = "Tạo thành công vai trò mới";
                return RedirectToAction("Index");
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                ViewBag.AllFunctions = await functionService.GetAllFunctionsGroupedByCategory();
                return PartialView("_CreateRoleForm", request);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.AllFunctions = await functionService.GetAllFunctionsGroupedByCategory();
            var role = await roleService.GetRoleForEdit(id);

            if (role == null)
            {
                TempData["ErrorToast"] = "Không tìm thấy nhóm quyền này!";
                return RedirectToAction("Index");
            }
            return PartialView("_EditRoleForm", role);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateRoleRequest request)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AllFunctions = await functionService.GetAllFunctionsGroupedByCategory();
                return PartialView("_EditRoleForm", request);
            }

            try
            {
                await roleService.Update(request);
                TempData["SuccessToast"] = $"Cập nhật thành công thông tin của vai trò {request.Name}";
                return RedirectToAction("Index");
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                ViewBag.AllFunctions = await functionService.GetAllFunctionsGroupedByCategory();
                return PartialView("_EditRoleForm", request);
            }

        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteRoleRequest request)
        {
            try
            {
                await roleService.Delete(request);
                TempData["SuccessToast"] = $"Xóa thành công!";
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;

            }
            return RedirectToAction("Index");
        }
    }
}
