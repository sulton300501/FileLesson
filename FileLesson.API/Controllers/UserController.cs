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
        public async Task<IActionResult> CreateUser([FromForm] UserProfileDTO userProfileDTO)
        {
            UserProfileExternalService service = new UserProfileExternalService(_env);

            var picture = userProfileDTO.Picture;
            
            var path = service.AddPictureAndGetPath(picture);

            string picturePath = await service.AddPictureAndGetPath(picture);


            var result = await _userService.CreateUserProfileAsync(userProfileDTO, picturePath);


            return Ok(result);
        }

      
        [HttpPost]
        public IActionResult PostForm([FromForm] string value ,IFormFile file)
        {
            return Ok(value);
        }

      
    
    }
}
