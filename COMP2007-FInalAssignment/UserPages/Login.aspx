<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Frontend.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="COMP2007_FInalAssignment.UserPages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NavBarPlaceHolder" runat="server">
    
      

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
              <asp:Login ID="Login1" runat="server" CreateUserText="Register" CreateUserUrl="~/UserPages/Register.aspx" DestinationPageUrl="~/Default.aspx" RenderOuterTable="False"></asp:Login>
            <asp:LoginStatus ID="LoginStatus1" runat="server" />
</asp:Content>
