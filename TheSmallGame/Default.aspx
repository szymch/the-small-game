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
            <asp:Button ID="ButtonStartGame" runat="server" Text="Start The Game!" OnClick="ButtonStartGame_Click"  />
        </div>
        <div runat="server" id="GameStarted">
            Game started!
        </div>
    </div>
</asp:Content>
