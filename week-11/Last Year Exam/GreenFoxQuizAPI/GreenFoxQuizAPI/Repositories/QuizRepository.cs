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
        static readonly Random RandomNumber = new Random();

        public QuizRepository(QuizContext quizContex)
        {
            this.quizContext = quizContex;
        }

        public List<Quiz> GetRandomQuestions()
        {
            var listOfQuestions = (from quizes in quizContext.Quizes
                                   orderby quizes.Id ascending
                                   select quizes).ToList();

            var randomQuiz1 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];
            var randomQuiz2 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];
            var randomQuiz3 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];
            var randomQuiz4 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];
            var randomQuiz5 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];
            var listOfQuiz = new List<Quiz>();

            listOfQuiz.Add(randomQuiz1);
            listOfQuiz.Add(randomQuiz2);
            listOfQuiz.Add(randomQuiz3);
            listOfQuiz.Add(randomQuiz4);
            listOfQuiz.Add(randomQuiz5);

            return listOfQuiz;
        }
    }
}
