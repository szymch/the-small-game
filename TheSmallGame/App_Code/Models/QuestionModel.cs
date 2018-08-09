namespace TheSmallGame.Models
{
    /// <summary>
    /// Model for questions presented to player during game.
    /// </summary>
    public class QuestionModel
    {
        public string Id { get; set; }
        public string QuestionText { get; set; }
        public bool IsTrue { get; set; }
    }
}