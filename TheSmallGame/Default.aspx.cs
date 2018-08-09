using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheSmallGame;
using TheSmallGame.DataSources;
using TheSmallGame.Models;

public partial class _Default : Page
{
    private string GameKeyName = "currentGame";

    protected GameEngine GameEngine => GetGameEngine();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            RefreshView();
    }

    protected void RefreshView()
    {
        LoggedView.Visible = User.Identity.IsAuthenticated;
        NotLoggedView.Visible = !LoggedView.Visible;

        GameStateModel currentGame = this.ViewState[GameKeyName] as GameStateModel;

        GameNotStarted.Visible = (currentGame == null);
        GameStarted.Visible = !GameNotStarted.Visible;

        if (currentGame != null)
        {

        }
    }

    protected GameEngine GetGameEngine()
    {
        QuestionsStore questionsStore = new QuestionsStore();
        QuestionsService questionsService = new QuestionsService(questionsStore);
        return new GameEngine(questionsService);
    }

    protected void ButtonStartGame_Click(object sender, EventArgs e)
    {
        this.ViewState[GameKeyName] = this.GameEngine.NewGame(User.Identity.Name);
        RefreshView();
    }
}