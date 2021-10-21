using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UserProject.Business.Abstract;
using UserProject.WebUI.ViewModels;
namespace UserProject.WebUI.Controllers
{
    public class HomeController:Controller
    {
        private IWorkService workService;
         public HomeController(IWorkService workService)
         {
             this.workService=workService;
         }
        public IActionResult Index(){
              var workViewModel=new WorkViewModel(){
                  works = workService.GetAllEntities()
              };
            return View(workViewModel);
        }
        public IActionResult Daily(){
            var workViewModel=new WorkViewModel(){
                  works = workService.GetDailyWorks()
              };
            return View(workViewModel);
        }
        public IActionResult Weekly(){
            var workViewModel=new WorkViewModel(){
                  works = workService.GetWeeklyWorks()
              };
            return View(workViewModel);
        }
        public IActionResult Monthly(){
            var workViewModel=new WorkViewModel(){
                  works = workService.GetMonthlyWorks()
              };
            return View(workViewModel);
        }
    }
}