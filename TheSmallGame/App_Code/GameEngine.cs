using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheSmallGame.DataSources;
using TheSmallGame.Models;

public class GameEngine
{
    private QuestionsService _questionsService;
    public GameEngine(QuestionsService questionsService)
    {
        _questionsService = questionsService;
    }

    public GameStateModel NewGame(string playerName)
    {
        return new GameStateModel
        {
            Questions = _questionsService.GetRandomQuestions(5).ToList(),
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
}