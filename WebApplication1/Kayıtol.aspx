<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Kayıtol.aspx.cs" Inherits="WebApplication1.Kayıtol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Kayıt Ol</h2>
        <div>
        </div>
        <div>
        </div>
        <div>
        </div>
        <div>
            <asp:TextBox ID="tboxUsername" runat="server" placeholder="Kullanıcı Adı"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="tboxMail" runat="server" placeholder="E-posta" TextMode="Email"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="tboxPassword" runat="server" TextMode="Password" placeholder="Şifre"></asp:TextBox>
        </div>
        <div>
        </div>
        <div>
            <asp:Button ID="btnRegister" runat="server" Text="Kayıt Ol" OnClick="btnRegister_Click" />
        </div>
    </div>
</asp:Content>
