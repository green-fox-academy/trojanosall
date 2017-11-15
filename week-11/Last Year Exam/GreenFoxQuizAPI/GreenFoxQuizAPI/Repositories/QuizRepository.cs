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

        //public List<Quiz> GetRandomQuestions()
        //{
        //    List<Quiz> listOfQuestions = (from quizes in quizContext.Quizes
        //                                  orderby quizes.Id ascending
        //                                  select quizes).ToList();

        //    var randomQuiz1 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];
        //    listOfQuestions.Remove(randomQuiz1);

        //    var randomQuiz2 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];
        //    listOfQuestions.Remove(randomQuiz2);

        //    var randomQuiz3 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];
        //    listOfQuestions.Remove(randomQuiz3);

        //    var randomQuiz4 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];
        //    listOfQuestions.Remove(randomQuiz4);

        //    var randomQuiz5 = listOfQuestions[RandomNumber.Next(listOfQuestions.Count)];

        //    var listOfQuiz = new List<Quiz>();

        //    listOfQuiz.Add(randomQuiz1);
        //    listOfQuiz.Add(randomQuiz2);
        //    listOfQuiz.Add(randomQuiz3);
        //    listOfQuiz.Add(randomQuiz4);
        //    listOfQuiz.Add(randomQuiz5);

        //    return listOfQuiz;
        //}

        public List<string> GetRandomQuestions()
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

            List<string> RandomQuestions = new List<string>();
            RandomQuestions.Add(randomQuiz1.Question);
            RandomQuestions.Add(randomQuiz2.Question);
            RandomQuestions.Add(randomQuiz3.Question);
            RandomQuestions.Add(randomQuiz4.Question);
            RandomQuestions.Add(randomQuiz5.Question);

            return RandomQuestions;
        }
    }
}
