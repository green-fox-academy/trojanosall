using GreenFoxQuizAPI.Entities;
using GreenFoxQuizAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace GreenFoxQuizAPI.Repositories
{
    public class QuizRepository
    {
        QuizContext quizContext;
        QuizQuestion quizQuestion;
        static readonly Random RandomNumber = new Random();

        public QuizRepository(QuizContext quizContex, QuizQuestion quizQuestion)
        {
            this.quizContext = quizContex;
            this.quizQuestion = quizQuestion;
        }

        public List<Quiz> GetRandomListOfQuiz()
        {
            List<Quiz> listOfQuestions = (from quizes in quizContext.Quizes
                                          orderby quizes.Id ascending
                                          select quizes).ToList();

            var randomQuiz1 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];
            listOfQuestions.Remove(randomQuiz1);

            var randomQuiz2 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];
            listOfQuestions.Remove(randomQuiz2);

            var randomQuiz3 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];
            listOfQuestions.Remove(randomQuiz3);

            var randomQuiz4 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];
            listOfQuestions.Remove(randomQuiz4);

            var randomQuiz5 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];

            var listOfQuiz = new List<Quiz>();

            listOfQuiz.Add(randomQuiz1);
            listOfQuiz.Add(randomQuiz2);
            listOfQuiz.Add(randomQuiz3);
            listOfQuiz.Add(randomQuiz4);
            listOfQuiz.Add(randomQuiz5);

            return listOfQuiz;
        }

        public List<Quiz> GetAnswerForRandomQuestion(List<QuizQuestion> quizQuestions)
        {
            List<Quiz> listOfAnswer = (from quizes in quizContext.Quizes where quizes.Id == quizQuestion.Id select quizes).ToList();

            return listOfAnswer;
        }



    }
}
