using System.Collections.Generic;
using TheSmallGame.Models;

namespace TheSmallGame.DataSources
{
    /// <summary>
    /// Reads questions from permanent data store
    /// </summary>
    public class QuestionsStore
    {
        public IEnumerable<QuestionModel> GetQuestions()
        {
            return new List<QuestionModel>()
            {
                new QuestionModel
                {
                    Id = "1",
                    QuestionText = "Don Pablo is the capital city of San Escobar.",
                    Answer = false
                },
                new QuestionModel
                {
                    Id = "2",
                    QuestionText = "Real horse head was used as a prop in the Godfather movie.",
                    Answer = true
                },
                new QuestionModel
                {
                    Id = "3",
                    QuestionText = "Elvis is probably still alive.",
                    Answer = true
                },
                new QuestionModel
                {
                    Id = "4",
                    QuestionText = "Aconcagua is Andas highest peak.",
                    Answer = true
                },
                new QuestionModel
                {
                    Id = "5",
                    QuestionText = "Jarosław Kaczyński was mentioned in one of the South Park episodes.",
                    Answer = true
                },
                new QuestionModel
                {
                    Id = "6",
                    QuestionText = "\"Macrela\" is the the name of Macron and Merkel tandem.",
                    Answer = true
                },
                new QuestionModel
                {
                    Id = "7",
                    QuestionText = "Pablo Picasso designed a collection of plates.",
                    Answer = true
                },
                new QuestionModel
                {
                    Id = "8",
                    QuestionText = "Magda Gessler runs her own official Facebook fanpage herself.",
                    Answer = false
                },
                new QuestionModel
                {
                    Id = "9",
                    QuestionText = "Danuta Hojarska is no longer involved in politics.",
                    Answer = false
                },
                new QuestionModel
                {
                    Id = "10",
                    QuestionText = "Jacek Rozenek is Małgorzata Rozenek's husband.",
                    Answer = false
                },
                new QuestionModel
                {
                    Id = "11",
                    QuestionText = "Wojciech Szczęsny's son is named Liam.",
                    Answer = true
                },
                new QuestionModel
                {
                    Id = "12",
                    QuestionText = "It is believed that Donald Trump travels with Melania Trump lookalike.",
                    Answer = true
                },
                new QuestionModel
                {
                    Id = "13",
                    QuestionText = "Bill Clinton never had an affair.",
                    Answer = false
                },
                new QuestionModel
                {
                    Id = "14",
                    QuestionText = "You can buy an iPhone app that makes the phone water-proof.",
                    Answer = true
                },
                new QuestionModel
                {
                    Id = "15",
                    QuestionText = "You can buy an iPhone app that really makes the phone water-proof.",
                    Answer = false
                }
            };
        }
    }
}