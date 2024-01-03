<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="WebApplication1.Kayıt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <h2>Giriş Yap</h2>
    <asp:TextBox ID="tboxMail" runat="server" placeholder="Kullanıcı Adı"></asp:TextBox><br />
    <asp:TextBox ID="tboxPassword" runat="server" TextMode="Password" placeholder="Şifre"></asp:TextBox>
    <br />
    <asp:Button ID="btnLogin" runat="server" style="height: 26px" Text="Giriş Yap" OnClick="btnLogin_Click" />
    <br />

</div>
</asp:Content>
