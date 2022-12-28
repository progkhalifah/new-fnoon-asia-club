using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using fnoonasiaclub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace fnoonasiaclub.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {

            [Required(ErrorMessage = "You Have to Enter First Name")]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "You Have to Enter Second Name")]
            [Display(Name = "Second Name")]
            public string SecondName { get; set; }

            [Required(ErrorMessage = "You Have to Enter Third Name")]
            [Display(Name = "Third Name")]
            public string ThirdName { get; set; }

            [Required(ErrorMessage = "You Have to Enter Last Name")]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required(ErrorMessage = "You Have to Enter Nationality")]
            [Display(Name = "Nationality")]
            public string Nationality { get; set; }

            [Required(ErrorMessage = "You Have to Enter Choose Game")]
            [Display(Name = "Choose Game")]
            public string Game { get; set; }

            [Required(ErrorMessage = "You Have to Enter Another Game")]
            [Display(Name = "Duration Month")]
            public string DurationMonth { get; set; }

            [Required(ErrorMessage = "You Have to Enter Another Game")]
            [Display(Name = "Another Game")]
            public string AnotherGame { get; set; }

            [Required(ErrorMessage = "You Have to Enter Duration Month")]
            [Display(Name = "Duration Month")]
            public string AnotherDurationMonth { get; set; }

            [Required(ErrorMessage = "You Have to Enter Birthday")]
            [Display(Name = "Birthday")]
            public string Birthday { get; set; }

            [Required(ErrorMessage = "You Have to Enter Identification")]
            [Display(Name = "Identification")]
            public string Identification { get; set; }

            [Required(ErrorMessage = "You Have to Enter Parent's Job")]
            [Display(Name = "Parent's Job")]
            public string ParentsJob { get; set; }

            [Required(ErrorMessage = "You Have to Enter Company or Location")]
            [Display(Name = "Name of Company or Location")]
            public string Nameofcompany { get; set; }

            [Required(ErrorMessage = "You Have to Enter Address")]
            [Display(Name = "Address")]
            public string Addres { get; set; }

            [Required(ErrorMessage = "You Have to Enter Phone Number")]
            [StringLength(10, ErrorMessage = "Please Enter Valid Phone Number that start with 05. ex. 05555555", MinimumLength = 10 )]
            [DataType(DataType.PhoneNumber)]
            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; set; }

            [Required(ErrorMessage = "You Have to Enter Phone Number")]
            [StringLength(10, ErrorMessage = "Please Enter Valid Phone Number that start with 05. ex. 05555555", MinimumLength = 10 )]
            [DataType(DataType.PhoneNumber)]
            [Display(Name = "Another Phone Number")]
            public string AnotherPhoneNumber { get; set; }

            [Required(ErrorMessage = "You Have to Enter Branch")]
            [Display(Name = "Branch")]
            public string Branch { get; set; }

            [Required(ErrorMessage = "You Have to Enter Email")]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "You Have to Enter Password")]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }


        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new TblRegistrationUser
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    NameA = Input.FirstName + " " + Input.SecondName + " " + Input.ThirdName + " " + Input.LastName,
                    Game = Input.Game,
                    DurationMonth = Input.DurationMonth,
                    DateBirth = Input.Birthday,
                    Nationality = Input.Nationality,
                    Identification = Input.Identification,
                    Cellphone = Input.PhoneNumber,
                    Cellphone2 = Input.AnotherPhoneNumber,
                    Address = Input.Addres,
                    GuardianWork = Input.ParentsJob,
                    Place = Input.Branch,
                    AddAnotherGame = Input.AnotherGame,
                    DurationAnotherGame = Input.AnotherDurationMonth

                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
