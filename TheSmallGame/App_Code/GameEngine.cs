using System;
using System.Linq;
using TheSmallGame.DataSources;
using TheSmallGame.Models;

public class GameEngine
{
    private QuestionsStore _questionsStore;
    private HighScoresStore _highScoresStore;

    public GameEngine(QuestionsStore questionsStore, HighScoresStore highScoresStore)
    {
        _questionsStore = questionsStore;
        _highScoresStore = highScoresStore;
    }

    public GameStateModel NewGame(string playerName)
    {
        return new GameStateModel
        {
            Questions = _questionsStore.GetRandomQuestions(5).ToList(),
            PlayerName = playerName,
            StartTime = DateTime.Now
        };
    }

    public GameStateModel AnswerFirstQuestion(GameStateModel game, bool answer)
    {
        if (game.Questions.First().Answer == answer)
        {
            game.Questions.RemoveAt(0);
            game.RunningTime = DateTime.Now.Subtract(game.StartTime);
            if (game.Questions.Count() == 0)
            {
                game.IsFinished = true;
                game.IsWon = true;
                SaveHighScore(game);
            }
        }
        else
        {
            game.Questions.Clear();
            game.IsFinished = true;
            game.IsWon = false;
        }
        return game;
    }

    private void SaveHighScore(GameStateModel game)
    {
        var highScore = new HighScoreModel
        {
            DateFinished = DateTime.Now,
            PlayerName = game.PlayerName,
            SecondsToWin = game.RunningTime.TotalSeconds
        };
        _highScoresStore.SaveHighScore(highScore);
    }
}