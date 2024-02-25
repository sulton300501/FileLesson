using FileAPILesson.Domain.Entities.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace FileAPILesson.Domain.Entities.DTOs
{
    public class UserProfileDTO
    {
      

        public string FullName { get; set; }
        public string Phone { get; set; }
        public Role UserRole { get; set; }



        [MinLength(5), MaxLength(30)]
        public required string Login { get; set; }



        [MinLength(6)]
        public string Password { get; set; }

        
      
       
    }
}
