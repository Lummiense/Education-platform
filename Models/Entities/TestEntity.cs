using Entities;

namespace Education_platform.Models.Entities
{
    public class TestEntity : IEntity
    {
        public uint Id { get; set; }
        List<QuestionEntity> questions { get; }
        Timer timer { get; set; }
        uint questionsCount { get; set; }
        uint correctAnswersCount { get; set; }
        double successRate { get; set; }

    }
}
