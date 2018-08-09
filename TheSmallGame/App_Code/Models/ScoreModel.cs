using System;

namespace TheSmallGame.Models
{
    /// <summary>
    /// Result of a successfully finished game.
    /// </summary>
    public class ScoreModel
    {
        public string PlayerName { get; set; }
        public DateTime DateFinished { get; set; }
        public double SecondsToWin { get; set; }
    }
}