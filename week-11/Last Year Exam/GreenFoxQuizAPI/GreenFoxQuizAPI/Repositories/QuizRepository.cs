using GreenFoxQuizAPI.Entities;

namespace GreenFoxQuizAPI.Repositories
{
    public class QuizRepository
    {
        QuizContext quizContext;

        public QuizRepository(QuizContext quizContex)
        {
            this.quizContext = quizContex;
        }
    }
}
