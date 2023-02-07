using Microsoft.Build.Framework;
using System;

namespace Entities
{
    public class UserEntity:IEntity
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Surname { get; set; }
        [Required]
        public string? SecondName { get; set; }
        public DateOnly BirthDate { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        public string? Email { get; set; }
        public uint Id { get; set; }
            
        
    }
}