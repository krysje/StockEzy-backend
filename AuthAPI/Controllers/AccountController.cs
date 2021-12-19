using AuthAPI.Entities;
using AuthAPI.Models;
using AuthAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly ITokenService tokenService;

        public AccountController(IUserService userService, ITokenService tokenService)
        {
            this.userService = userService;
            this.tokenService = tokenService;
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(User user)
        {
            try
            {
                string userResult = userService.Register(user);
                return Created("api/created", userResult);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(Login login)
        {
            try
            {
                AuthUser authUser = null;
                User user = userService.Login(login);

                if (user != null)
                {
                    authUser = new AuthUser()
                    {
                        UserId = user.UserId,
                        Token = tokenService.GenerateToken(user),
                        UserType = user.UserType
                    };
                }

                if (authUser != null)
                    return Created("api/Created", authUser);

                else
                    throw new Exception("User not found");

            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
