using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using zippersale.Models;
using zippersale.Repositories;

namespace zippersale.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ILogger<RegisterController> _logger;
        private readonly IUserRegisterRepository _userRegisterRepository;

        public RegisterController(ILogger<RegisterController> logger, IUserRegisterRepository userRegisterRepository)
        {
            _logger = logger;
            _userRegisterRepository = userRegisterRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        public IActionResult RegisterUserIntoDB(UserRegister userRegister)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Email = userRegister.Email;
            userLogin.Password = userRegister.Password;

            var result = _userRegisterRepository.RegisterUserRegister(userRegister, userLogin);

            return View("Index");

        }
    }
}