using Application.Common;
using Application.Dtos.TeacherEvaluation;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Authorize(Roles = "Admin,Manager")]
    [Route("manager/teacher-evaluations")]
    public class TeacherEvaluationController : Controller
    {
        private readonly ITeacherEvaluationService _evaluationService;

        public TeacherEvaluationController(ITeacherEvaluationService evaluationService)
        {
            _evaluationService = evaluationService;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index([FromQuery] TeacherEvaluationFilterRequest request)
        {
            request ??= new TeacherEvaluationFilterRequest();

            try
            {
                var teachers = await _evaluationService.GetTeacherOverviewsAsync(request);
                var stats = await _evaluationService.GetSystemStatsAsync();

                ViewBag.SystemStats = stats ?? new TeacherEvaluationStatsDto();
                ViewBag.FilterRequest = request;

                return View(teachers ?? new PaginatedList<TeacherOverviewDto>(0, new List<TeacherOverviewDto>()));
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = "An error occurred while loading teacher evaluations: " + ex.Message;
                ViewBag.SystemStats = new TeacherEvaluationStatsDto();
                ViewBag.FilterRequest = request;
                return View(new PaginatedList<TeacherOverviewDto>(0, new List<TeacherOverviewDto>()));
            }
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Detail(Guid id, [FromQuery] TeacherReviewFilterRequest reviewRequest)
        {
            reviewRequest ??= new TeacherReviewFilterRequest();

            try
            {
                var teacherDetail = await _evaluationService.GetTeacherDetailAsync(id);
                if (teacherDetail == null)
                {
                    TempData["ErrorToast"] = "Teacher details not found.";
                    return RedirectToAction(nameof(Index));
                }

                var reviews = await _evaluationService.GetTeacherReviewsAsync(id, reviewRequest);

                ViewBag.Reviews = reviews ?? new PaginatedList<TeacherReviewDetailDto>(0, new List<TeacherReviewDetailDto>());
                ViewBag.ReviewRequest = reviewRequest;

                return View(teacherDetail);
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = "An error occurred while loading evaluation details: " + ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
