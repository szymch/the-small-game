using System;
using System.Collections.Generic;

namespace TheSmallGame.Models
{
    /// <summary>
    /// Stores state of an ongoing or finished game.
    /// </summary>
    [Serializable]
    public class GameStateModel
    {
        public string PlayerName { get; set; }
        public List<QuestionModel> Questions { get; set; }
        public DateTime StartTime { get; set; }
        public bool IsFinished { get; set; }
        public bool IsWon { get; set; }
        public TimeSpan RunningTime { get; set; }
    }
}