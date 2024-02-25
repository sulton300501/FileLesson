using FileAPILesson.Domain.Entities.DTOs;
using FileAPILesson.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileApiLesson.Application.Service.UserProfilService
{
    public interface IUserProfilService
    {
        public Task<string> CreateUserProfileAsync(UserProfileDTO userDTO,string picturePath);
        public Task<List<UserProfile>> GetAllUserProfileAsync();
        public Task<UserProfile> GetByIdUserprofileAsyn();
        public Task<bool> DeleteUserProfileAsync(int id);
        public Task<UserProfile> UpdateUserProfileAsync(int id , UserProfileDTO modelDto);
    }
}
