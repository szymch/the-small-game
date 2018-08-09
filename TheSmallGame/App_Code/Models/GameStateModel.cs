using System;
using System.Collections.Generic;

namespace TheSmallGame.Models
{
    /// <summary>
    /// Stores state of an ongoing or finished game.
    /// </summary>
    public class GameStateModel
    {
        public IEnumerable<QuestionModel> Questions { get; set; }
        public DateTime StartTime { get; set; }
        public bool IsLost { get; set; }
        public TimeSpan TimeToWin { get; set; }
    }
}