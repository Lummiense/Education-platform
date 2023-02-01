using System;

namespace api.Entities
{
    public class UserEntity:IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public uint Id { get; set; }
            
        
    }
}