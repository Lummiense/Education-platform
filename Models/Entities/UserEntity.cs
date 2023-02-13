using Education_platform.Models;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using Xunit.Abstractions;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace Entities
{
    public class UserEntity:IEntity
    {
        [Required]
        [StringLength(20,MinimumLength =2,ErrorMessage ="Длина имени должна быть от 2 до 20 символов")]
        public string? Name { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Длина фамилии должна быть от 2 до 30 символов")]
        public string? Surname { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Длина отчества должна быть от 2 до 30 символов")]
        public string? SecondName { get; set; }
        public DateOnly BirthDate { get; set; }
        [Required]
        [Phone]
        public string? Phone { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        public uint Id { get; set; }
            
        
    }
}