using FileAPILesson.Domain.Entities.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FileAPILesson.Domain.Entities.Models
{
    public class UserProfile
    {
        public int id { get; set; }

        [NotMapped]
        public  IFormFile Picture { get; set; }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public int UserRole { get; set; }

      
        
        [MinLength(5) ,MaxLength(30)]
        public required string Login {  get; set; }



        [MinLength(6)]
        public string Password { get; set; }
       
        public string PicturePath { get; set; }
                
    }
}
