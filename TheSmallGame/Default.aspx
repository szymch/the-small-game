<%@ Page ViewStateEncryptionMode="Always" EnableViewState="true" Title="Play" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row" runat="server" id="NotLoggedView">
        <div class="col-md-7">
            <h2>Log in to play The Small Game</h2>
            <p>
                <a class="btn btn-default" runat="server" href="~/Account/Login">Log in &raquo;</a>
            </p>
        </div>
        <div class="col-md-5">
            <h3>Don't have an account?</h3>
            <p>
                <a class="btn btn-default" runat="server" href="~/Account/Register">Register &raquo;</a>
            </p>
        </div>
    </div>
    <div runat="server" id="LoggedView">
        <div class="jumbotron text-center" runat="server" id="GameNotStarted">
            <asp:Button ID="ButtonStartGame" CssClass="btn btn-lg btn-primary" runat="server" Text="Start The Game!" OnClick="ButtonStartGame_Click" />
        </div>
        <div runat="server" id="GameStarted">
            <div runat="server" class="jumbotron text-center" id="QuestionToAnswer">
                
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Timer ID="GameTimeRefresh" Interval="999" runat="server" OnTick="GameTimeRefresh_Tick"></asp:Timer>
                        Your time:
                        <asp:Label ID="GameTime" runat="server" Text=""></asp:Label>
                        seconds.
                    </ContentTemplate>
                </asp:UpdatePanel>
                <br />
                <h2>Is the following statement true or false?</h2>
                <div class="mv2">
                    <asp:Label ID="QuestionText" runat="server" Text=""></asp:Label>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <asp:Button ID="ButtonAnswerTrue" CssClass="btn btn-lg btn-success" runat="server" Text="True" OnClick="ButtonAnswerTrue_Click" />
                    </div>
                    <div class="col-md-6">
                        <asp:Button ID="ButtonAnswerFalse" CssClass="btn btn-lg btn-danger" runat="server" Text="False" OnClick="ButtonAnswerFalse_Click" />
                    </div>
                </div>
            </div>
            <div runat="server" id="GameEnding" class="jumbotron text-center">
                <div runat="server" id="GameWon">
                    <span class="text-success">CONGRATULATIONS!!!</span>
                    <br />
                    Your time: <asp:Label ID="WinningTime" runat="server" Text=""></asp:Label> seconds.
                    <br />
                    <asp:Label ID="CommentOnWinningTime" runat="server" Text=""></asp:Label>
                </div>
                <div runat="server" id="GameLost">
                    <span class="text-danger">!!!LOOSER!!!</span>
                </div>
                <asp:Button ID="ButtonTryAgain" CssClass="btn btn-lg btn-primary mv2" runat="server" Text="Let me try again!" OnClick="ButtonStartGame_Click" />
            </div>
        </div>
    </div>
</asp:Content>
