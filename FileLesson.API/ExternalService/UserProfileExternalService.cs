namespace FileLesson.API.ExternalService
{
    public  class UserProfileExternalService
    {
        private readonly IWebHostEnvironment _env;

        public UserProfileExternalService(IWebHostEnvironment env)
        {
            _env = env;
        }
      


        public  async Task<string> AddPictureAndGetPath(IFormFile file)
        {
            string path = Path.Combine(_env.WebRootPath, "images", Guid.NewGuid().ToString());//windows. c  windows\c   windows/c

            Directory.CreateDirectory(path);

            using(var stream = File.Create(Path.Combine(path, file.FileName)))
            {
               await  file.CopyToAsync(stream);
            }

            return path;
        
        }
    }
}
