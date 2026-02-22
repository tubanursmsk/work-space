using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MVC.Dto.UserDto;
using MVC.Models;
using MVC.Services;

namespace MVC.Pages.Account
{
    public class RegisterModel : PageModel //İş mantığı ve sayfa verisi (daha az eylem (action) ve daha çok sayfa odağı için) bu PageModel sınıfı içinde tutulur.
    {
        [BindProperty] //[BindProperty] ile formdan gelen veriler, doğrudan PageModel üzerindeki bir özelliğe bağlanır.
        public UserRegisterDto UserRegisterDto { get; set; } = new();

        private readonly UserService _userService;
        public RegisterModel(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            User user = _userService.UserRegister(UserRegisterDto);
            if (user != null)
            {
                return RedirectToPage("/Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Registration failed.");
                return Page();
            }
        }
    }
}
