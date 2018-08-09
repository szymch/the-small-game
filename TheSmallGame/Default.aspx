<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-7">
            <h2>Log in to play The Small Game</h2>
            <p>
                <a class="btn btn-default" runat="server" href="~/Account/Login">Log in &raquo;</a>
            </p>
        </div>
        <div class="col-md-5">
            <h4>Register if you don't have an account.</h4>
            <p>
                <a class="btn btn-default" runat="server" href="~/Account/Register">Register &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>
