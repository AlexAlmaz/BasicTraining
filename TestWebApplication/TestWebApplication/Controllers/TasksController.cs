using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApplication.Extentions;
using TestWebApplication.Models.Tasks;

namespace TestWebApplication.Controllers
{
    public class TasksController : Controller
    {
        private IWorkItemRepository _workItemRepository { get; set; }
        public TasksController(IWorkItemRepository workItemRepository)
        {
            _workItemRepository = workItemRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _workItemRepository.GetWorkItems();
            return View(model.Select(m => m.ToDomain()).ToList());
        }

        [HttpPost]
        public IActionResult Add(WorkItemModel model)
        {
            if(ModelState.IsValid)
            {
                _workItemRepository.AddWorkItem(model.ToCore());
            }
            return RedirectToAction("Index", "Tasks");
        }
    }
}
