using FileAPILesson.Domain.Entities.DTOs;
using FileAPILesson.Domain.Entities.Models;
using FileAPILesson.Infrastructure.Persistance;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileApiLesson.Application.Service.UserProfilService
{
    public class UserProfileService : IUserProfilService
    {
        private readonly ApplicationDbContext _context;
       
        public UserProfileService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> CreateUserProfileAsync(UserProfileDTO userDTO,string picturePath)
        {
         
            var model = new UserProfile
            {
                FullName = userDTO.FullName,
                Phone = userDTO.Phone,
                UserRole =Convert.ToInt32(userDTO.UserRole),
                Login = userDTO.Login,
                Password = userDTO.Password,
                PicturePath = picturePath
            };

            _context.Users.AddAsync(model);
            await _context.SaveChangesAsync();

            return "yaratildi";
        }


        public Task<bool> DeleteUserProfileAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserProfile>> GetAllUserProfileAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> GetByIdUserprofileAsyn()
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> UpdateUserProfileAsync(int id, UserProfileDTO modelDto)
        {
            throw new NotImplementedException();
        }
    }
}
