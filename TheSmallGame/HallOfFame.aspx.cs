using System;
using System.Linq;
using TheSmallGame.DataSources;

public partial class HallOfFame : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var highScoresStore = new HighScoresStore(Application);
        HallOfFameTable.DataSource = highScoresStore.GetHighScores().OrderBy(s => s.SecondsToWin);
        HallOfFameTable.DataBind();
    }
}