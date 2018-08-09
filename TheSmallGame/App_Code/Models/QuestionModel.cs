using System;

namespace TheSmallGame.Models
{
    /// <summary>
    /// Model for questions presented to player during game.
    /// </summary>
    [Serializable]
    public class QuestionModel
    {
        public string Id { get; set; }
        public string QuestionText { get; set; }
        public bool Answer { get; set; }
    }
}