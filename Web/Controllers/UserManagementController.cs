using Application.Common;
using Application.Dtos.UserManagement;
using Application.Exceptions;
using Application.Interfaces;
using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserManagementController(IUserManagementService userManagementService, IRoleRepository roleRepository) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(GetListUserRequest request)
        {
            if (!ModelState.IsValid)
            {
                var errorMessage = ModelState.Values
                    .SelectMany(v => v.Errors).FirstOrDefault()?.ErrorMessage;

                TempData["ErrorToast"] = errorMessage ?? "Dữ liệu tìm kiếm không hợp lệ";
                return View(new PaginatedList<UserVm>(0, new List<UserVm>()));
            }

            var listUsers = await userManagementService.GetList(request);
            ViewBag.AllRoles = await roleRepository.GetAllRolesAsync();
            return View(listUsers);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            try
            {
                var userEdit = await userManagementService.GetUserForEdit(id);
                ViewBag.AllRoles = await roleRepository.GetAllRolesAsync();
                return PartialView("_EditUserForm", userEdit);
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateUserRequest request)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AllRoles = await roleRepository.GetAllRolesAsync();
                return PartialView("_EditUserForm", request);
            }

            try
            {
                var currentUserIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(currentUserIdStr) || !Guid.TryParse(currentUserIdStr, out Guid currentUserId))
                {
                    TempData["ErrorToast"] = "Phiên làm việc không hợp lệ";
                    return RedirectToAction("Index");
                }

                await userManagementService.Update(request, currentUserId);
                TempData["SuccessToast"] = $"Cập nhật thành công thông tin người dùng {request.Username}";
                return RedirectToAction("Index");
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                ViewBag.AllRoles = await roleRepository.GetAllRolesAsync();
                return PartialView("_EditUserForm", request);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.AllRoles = await roleRepository.GetAllRolesAsync();
            return PartialView("_CreateUserForm", new CreateUserRequest());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserRequest request)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AllRoles = await roleRepository.GetAllRolesAsync();
                return PartialView("_CreateUserForm", request);
            }

            try
            {
                var currentUserIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(currentUserIdStr) || !Guid.TryParse(currentUserIdStr, out Guid currentUserId))
                {
                    TempData["ErrorToast"] = "Phiên làm việc không hợp lệ";
                    return RedirectToAction("Index");
                }

                await userManagementService.Create(request, currentUserId);
                TempData["SuccessToast"] = $"Tạo thành công tài khoản người dùng {request.Username}";
                return RedirectToAction("Index");
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                ViewBag.AllRoles = await roleRepository.GetAllRolesAsync();
                return PartialView("_CreateUserForm", request);
            }
        }
    }
}
