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
}