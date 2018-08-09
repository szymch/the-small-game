using System;
using System.Collections.Generic;
using System.Linq;
using TheSmallGame.Models;

namespace TheSmallGame.DataSources
{
    public class QuestionsService
    {
        private QuestionsStore _questionsStore;

        public QuestionsService(QuestionsStore questionsStore)
        {
            _questionsStore = questionsStore;
        }

        /// <summary>
        /// Provides a collection of unique, random questions
        /// </summary>
        public IEnumerable<QuestionModel> GetRandomQuestions(int limit)
        {
            // I assume number of questions is not going to be a challenge.
            // If it was, I would look into more optimal way to shuffle.
            return _questionsStore.GetQuestions().OrderBy(q => Guid.NewGuid()).Take(limit);
        }
    }
}