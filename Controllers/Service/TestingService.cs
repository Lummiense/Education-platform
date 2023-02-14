using Education_platform.Models.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using Service;

namespace Education_platform.Controllers.Service
{
    public class TestingService : ITestingService
    {
        private readonly IDataBase _database;
        public TestingService(IDataBase database)
        {
            _database = database;
        }
        public async Task<uint> AddQuestions(QuestionEntity question)
        {
            try
            {
                using (StreamReader reader = new StreamReader("Education platform\\wwwroot\\lib\\Test.txt"))
                {
                    string? line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        if (line.Contains("Тема:"))
                        {
                            line = line.Remove(0, 6);
                            question.theme = line;
                        }
                        else if (line.Contains("Вопрос:"))
                        {
                            line = line.Remove(0, 8);
                            question.questionText= line;

                        }
                        else if(line.Contains("Ответ:"))
                        {
                            line = line.Remove(0, 7);
                            question.correctAnswer = line;
                        }
                        else
                        {
                            question.Answers.Add(line);
                        }
                    }
                }
            }
            catch
            {
                throw new Exception("Считать данные не удалось");
            }
            Random rnd = new Random();
            question.Id = (uint)rnd.Next(2000000000);
            try
            {
                var result = await _database.Add(question);
                await _database.SaveChangeAsync();
                return result;
            }
            catch 
            {
                throw new Exception ("Сохранить в базу данных не удалось");
            }
        }

        

     
    }
}
