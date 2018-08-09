using System;

namespace TheSmallGame.Models
{
    /// <summary>
    /// Stores results of successfully finished games.
    /// </summary>
    public class ScoreModel
    {
        public string UserName { get; set; }
        public DateTime DateFinished { get; set; }
        public TimeSpan TimeToWin { get; set; }
    }
}