using FileAPILesson.Domain.Entities.DTOs;
using FileAPILesson.Domain.Entities.Models;
using FileAPILesson.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
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



        public async Task<bool> DeleteUserProfileAsync(int id)
        {
            var userToDelete = await _context.Users.FindAsync(id);

            if (userToDelete == null)
            {
                return false; // User not found
            }

            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();

            return true; // User deleted successfully
        }

        public async Task<List<UserProfile>> GetAllUserProfileAsync()
        {
            return await _context.Users.ToListAsync();
        }


       

        public Task<UserProfile> GetByIdUserprofileAsyn()
        {
            throw new NotImplementedException();
        }

        public async Task<UserProfile> UpdateUserProfileAsync(int id, UserProfileDTO modelDto)
        {
            var userToUpdate = await _context.Users.FindAsync(id);

            if (userToUpdate == null)
            {
                return null; // User not found
            }

            // Update user properties based on the DTO
            userToUpdate.FullName = modelDto.FullName;
            userToUpdate.Phone = modelDto.Phone;
            userToUpdate.UserRole = Convert.ToInt32(modelDto.UserRole);
            userToUpdate.Login = modelDto.Login;
            userToUpdate.Password = modelDto.Password;

            await _context.SaveChangesAsync();

            return userToUpdate;
        }

        
    }
}
