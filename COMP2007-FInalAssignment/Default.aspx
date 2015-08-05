<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Frontend.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="COMP2007_FInalAssignment.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container CenterLogin">

      <form class="form-signin">
        <h2 class="center-text">Please enter user information:</h2>
        <label for="inputEmail" class="sr-only">Email address</label>
        <input type="email" id="inputEmail" class="form-control" placeholder="User Name" required autofocus>
        <label for="inputPassword" class="sr-only">Password</label>
        <input type="password" id="inputPassword" class="form-control" placeholder="Password" required>
        <div class="checkbox">
          <label class ="center-block">
            <input type="checkbox" value="remember-me"> Remember me
          </label>
        </div>
        <button class="btn btn-lg btn-Custom btn-block" type="submit">Sign in</button>
      </form>

    </div> <!-- /container -->

</asp:Content>