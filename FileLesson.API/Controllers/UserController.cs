using FileApiLesson.Application.Service.UserProfilService;
using FileAPILesson.Domain.Entities.DTOs;
using FileLesson.API.ExternalService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FileLesson.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IWebHostEnvironment _env;
        private readonly IUserProfilService _userService;

        public UserController(IUserProfilService userProfilService, IWebHostEnvironment env)
        {
            _userService = userProfilService;
            _env= env;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromForm] UserProfileDTO userProfileDTO,IFormFile picture)
        {
            UserProfileExternalService service = new UserProfileExternalService(_env);
         //   var path = service.AddPictureAndGetPath(userProfileDTO.Picture);
            string picturePath = await service.AddPictureAndGetPath(userProfileDTO.Picture);


                var result = _userService.CreateUserProfileAsync(userProfileDTO , picturePath);
            return Ok(result);
        }

      
        [HttpPost]
        public IActionResult PostForm([FromForm] string value ,IFormFile file)
        {
            return Ok(value);
        }

      
    
    }
}
