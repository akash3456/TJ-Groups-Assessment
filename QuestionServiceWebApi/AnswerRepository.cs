using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuestionServiceWebApi.Interfaces;

namespace QuestionServiceWebApi
{
    public class AnswerRepository : IAnswerRepository
    {

        public Answer GetAnswer() {

            return new Answer {
                AnswerText = "Answer to Question",
                AnswerTitle = new List<string> {
                    "Cities",
                    "Havana",
                    "Paris",
                    "Warsaw",
                    "Berlin"
                }
            };
        }
    }
}