<%@ Page Title="" Language="C#" MasterPageFile="~/Userr.Master" AutoEventWireup="true" CodeBehind="WebMasterPage.aspx.cs" Inherits="technical_services_web.WebMasterPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Ürün Seri No:" Font-Bold="True"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Ara" OnClick="Button1_Click" CssClass="btn btn-primary" />
    <table class="table table-bordered" style="margin-top: 25px">
        <tr>
            <th>ACIKLAMA</th>
            <th>TARIH</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ACIKLAMA")%></td><%--veri tabanından bilgileri dogru yere eklemek olusturuldu--%>
                    <td><%# Eval("TARIH")%></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
