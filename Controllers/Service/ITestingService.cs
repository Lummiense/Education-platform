using Education_platform.Models.Entities;

namespace Education_platform.Controllers.Service
{
    public interface ITestingService
    {     
        Task<uint> AddQuestions(QuestionEntity question);       
    }
}
