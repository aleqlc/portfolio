<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication7._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

    
        <br />
        <div>
        <asp:Label ID="Label3" runat="server" Text="User Registration Form" BackColor="#CC0000" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="White"></asp:Label>
            </div>
    
    <br />
        <asp:Label ID="Label4" runat="server" Text="User ID"></asp:Label>
        <asp:TextBox ID="txtuid" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>

    

<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" Width="79px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" Width="85px" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update" Width="86px" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" OnClientClick="return confirm('Are you sure to delete?')" Text="Delete" Width="90px" />
        <br />
        <asp:Label ID="lblmsg" runat="server" Font-Bold="True" ForeColor="#003300" Text="Label"></asp:Label>

    

<br />
<asp:GridView ID="GridView1" runat="server">
</asp:GridView>

    

</asp:Content>
