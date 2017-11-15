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

            //var randomListOfQuestionsWithId = new List<Quiz>();

            //var randomListOfQuestionsWithId = (from randomQuestion in listOfQuiz orderby randomQuestion.Id
            //                            select new { randomQuestion.Id, randomQuestion.Question }).ToList();

            return listOfQuiz;
        }

        //public List<List<string>> GetRandomQuestions()
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

        //    List<string> IdAndQuestionRandomQuiz1 = new List<string>();
        //    IdAndQuestionRandomQuiz1.Add(randomQuiz1.Id.ToString());
        //    IdAndQuestionRandomQuiz1.Add(randomQuiz1.Question);

        //    List<string> IdAndQuestionRandomQuiz2 = new List<string>();
        //    IdAndQuestionRandomQuiz1.Add(randomQuiz2.Id.ToString());
        //    IdAndQuestionRandomQuiz1.Add(randomQuiz2.Question);

        //    List<string> IdAndQuestionRandomQuiz3 = new List<string>();
        //    IdAndQuestionRandomQuiz1.Add(randomQuiz3.Id.ToString());
        //    IdAndQuestionRandomQuiz1.Add(randomQuiz3.Question);

        //    List<string> IdAndQuestionRandomQuiz4 = new List<string>();
        //    IdAndQuestionRandomQuiz1.Add(randomQuiz4.Id.ToString());
        //    IdAndQuestionRandomQuiz1.Add(randomQuiz4.Question);

        //    List<string> IdAndQuestionRandomQuiz5 = new List<string>();
        //    IdAndQuestionRandomQuiz1.Add(randomQuiz5.Id.ToString());
        //    IdAndQuestionRandomQuiz1.Add(randomQuiz5.Question);

        //    List<List<string>> IdAndQuestionOfRandomQuizes = new List<List<string>>();
        //    IdAndQuestionOfRandomQuizes.Add(IdAndQuestionRandomQuiz1);
        //    IdAndQuestionOfRandomQuizes.Add(IdAndQuestionRandomQuiz2);
        //    IdAndQuestionOfRandomQuizes.Add(IdAndQuestionRandomQuiz3);
        //    IdAndQuestionOfRandomQuizes.Add(IdAndQuestionRandomQuiz4);
        //    IdAndQuestionOfRandomQuizes.Add(IdAndQuestionRandomQuiz5);

        //    return IdAndQuestionOfRandomQuizes;
        //}
    }
}
