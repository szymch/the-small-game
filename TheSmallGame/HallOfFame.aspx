<%@ Page Title="Top Scores" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HallOfFame.aspx.cs" Inherits="HallOfFame" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>The fastest players in the history of mankind</h2>
    <asp:GridView ID="HallOfFameTable" runat="server" ItemType="TheSmallGame.Models.HighScoreModel"
        CssClass="table" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Player name" DataField="PlayerName" />
            <asp:BoundField HeaderText="Date of Achievement" DataField="DateFinished" DataFormatString="{0:yyyy-MM-dd}" />
            <asp:BoundField HeaderText="Time to Win" DataField="SecondsToWin" DataFormatString="{0:#} seconds" />
        </Columns>
    </asp:GridView>
</asp:Content>

