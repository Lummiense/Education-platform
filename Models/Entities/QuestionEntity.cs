using Entities;

namespace Education_platform.Models.Entities
{
    public class QuestionEntity : IEntity
    {
        public uint Id { get ; set; }
        public string theme { get; set; }
        public string questionText { get; set; }
        public List <string> Answers { get; set; }
        public string correctAnswer { get; set; }
    }
}
