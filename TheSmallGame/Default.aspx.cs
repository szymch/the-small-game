using System;
using System.Linq;
using System.Web.UI;
using TheSmallGame.DataSources;
using TheSmallGame.Models;

public partial class _Default : Page
{
    private string GameKeyName = "currentGame";

    protected GameEngine GameEngine => GetGameEngine();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            RefreshView(null);
    }

    protected void ButtonStartGame_Click(object sender, EventArgs e)
    {
        GameStateModel newGame = this.GameEngine.NewGame(User.Identity.Name);
        SaveGameState(newGame);
        RefreshView(newGame);
    }

    protected void ButtonAnswerTrue_Click(object sender, EventArgs e)
    {
        AnswerQuestion(true);
    }

    protected void ButtonAnswerFalse_Click(object sender, EventArgs e)
    {
        AnswerQuestion(false);
    }

    private void AnswerQuestion(bool answer)
    {
        GameStateModel newGameState = this.GameEngine.AnswerFirstQuestion(GetCurrentGame(), answer);
        SaveGameState(newGameState);
        RefreshView(newGameState);
    }

    /// <summary>
    /// Show/hide parts of the Webform depending on whether user is logged in and if game is in progress.
    /// </summary>
    private void RefreshView(GameStateModel currentGame)
    {
        LoggedView.Visible = User.Identity.IsAuthenticated;
        NotLoggedView.Visible = !LoggedView.Visible;

        GameNotStarted.Visible = (currentGame == null);
        GameStarted.Visible = !GameNotStarted.Visible;
        if (currentGame != null)
            RefreshGameView(currentGame);
    }

    /// <summary>
    /// Show/hide Webform elements depending on game state.
    /// </summary>
    private void RefreshGameView(GameStateModel currentGame)
    {
        QuestionToAnswer.Visible = GameWon.Visible = GameLost.Visible = false;
        GameEnding.Visible = currentGame.IsFinished;
        if (currentGame.IsFinished)
        {
            GameWon.Visible = currentGame.IsWon;
            GameLost.Visible = !GameWon.Visible;
            int secondsToWin = Convert.ToInt32(currentGame.RunningTime.TotalSeconds);
            WinningTime.Text = secondsToWin.ToString();
            CommentOnWinningTime.Text = secondsToWin < 20 ? "You were fast!" : "You could do better...";
        }
        else
        {
            RefreshQuestionView(currentGame);
        }
    }

    /// <summary>
    /// Display question and game timer.
    /// </summary>
    private void RefreshQuestionView(GameStateModel currentGame)
    {
        QuestionToAnswer.Visible = true;
        int secondsPassed = Convert.ToInt32(currentGame.RunningTime.TotalSeconds);
        GameTime.Text = secondsPassed.ToString();
        QuestionText.Text = currentGame.Questions.First().QuestionText;
    }

    private GameEngine GetGameEngine()
    {
        //TODO: how about using some DI mechanism
        return new GameEngine(new QuestionsStore(), new HighScoresStore(Application));
    }

    private GameStateModel GetCurrentGame()
    {
        return this.ViewState[GameKeyName] as GameStateModel;
    }

    private void SaveGameState(GameStateModel currentGame)
    {
        this.ViewState[GameKeyName] = currentGame;
    }

    protected void GameTimeRefresh_Tick(object sender, EventArgs e)
    {
        int secondsPassed = Convert.ToInt32(GameTime.Text) + 1;
        GameTime.Text = secondsPassed.ToString();
    }
}