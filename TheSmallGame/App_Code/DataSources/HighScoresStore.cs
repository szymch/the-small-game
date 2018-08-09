using System.Collections.Generic;
using System.Web;
using TheSmallGame.Models;

namespace TheSmallGame.DataSources
{
    /// <summary>
    /// Saves/reads high scores from permanent data store
    /// </summary>
    public class HighScoresStore
    {
        private string KeyName = "highScores";
        private HttpApplicationState _application;

        public HighScoresStore(HttpApplicationState applicationState)
        {
            _application = applicationState;
        }

        public void SaveHighScore(HighScoreModel highScore)
        {
            var store = GetHighScores();
            store.Add(highScore);
            _application[KeyName] = store;
        }

        public List<HighScoreModel> GetHighScores()
        {
            if (_application[KeyName] == null)
                _application[KeyName] = new List<HighScoreModel>
            {
                new HighScoreModel {
                    DateFinished = new System.DateTime(2018, 8, 9),
                    PlayerName = "Szymon1",
                    SecondsToWin = 5
                },
                new HighScoreModel {
                    DateFinished = new System.DateTime(1998, 9, 30),
                    PlayerName = "Szymon2",
                    SecondsToWin = 20
                },
                new HighScoreModel {
                    DateFinished = new System.DateTime(1988, 3, 27),
                    PlayerName = "Szymon3",
                    SecondsToWin = 60
                }

            };
            return _application[KeyName] as List<HighScoreModel>;
        }
    }
}