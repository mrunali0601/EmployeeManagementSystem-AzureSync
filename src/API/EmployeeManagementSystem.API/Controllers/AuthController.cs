using EmployeeManagementSystem.Application.Dtos.LoginDto;
using EmployeeManagementSystem.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user == null)
                return Unauthorized(new { success = false, message = "Invalid credentials" });

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (result.Succeeded)
            {
                return Ok(new
                {
                    success = true,
                    message = "Login successful",
                    user = new { user.UserName, user.Email }
                    // you can add more user info or JWT token here if needed
                });
            }

            return Unauthorized(new { success = false, message = "Invalid credentials" });
        }

    }
}
