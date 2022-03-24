using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuizDemo.Datas;
using QuizDemo.Datas.Entities;
using QuizDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _logger = logger;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var users = unitOfWork.UserRepostorys.GetAll();
            List<UserViewModel> userViewModel = new();

            users.ToList().ForEach(s =>
            {
                userViewModel.Add(mapper.Map<UserViewModel>(s));
            });

            return View(userViewModel);
        }

        public IActionResult Create()
        {
            var user = new UserViewModel();
            return PartialView("_AddModal", user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                User _user = mapper.Map<User>(user);

                unitOfWork.UserRepostorys.Add(_user);
                unitOfWork.Complete();
            }

            return PartialView("_AddModal", user);
        }

        public IActionResult Edit(long id)
        {
            var user = unitOfWork.UserRepostorys.GetById(id);
            UserViewModel _user = mapper.Map<UserViewModel>(user);
            return PartialView("_EditModal", _user);
        }

        [HttpPost]
        public IActionResult Edit(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                User _user = mapper.Map<User>(user);

                unitOfWork.UserRepostorys.Update(_user);
                unitOfWork.Complete();
            }

            return PartialView("_EditModal", user);
        }

        [HttpPost]
        public IActionResult Delete(long id)
        {
            var user = unitOfWork.UserRepostorys.GetById(id);
            unitOfWork.UserRepostorys.Delete(user);
            unitOfWork.Complete();
            return PartialView("_EditModal", mapper.Map<UserViewModel>(user));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
