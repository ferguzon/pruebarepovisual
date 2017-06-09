<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfLeer.aspx.cs" Inherits="proyectopruebarepovisual.wfLeer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="width: 604px">
                <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar" />
            </td>
            <td>
                <asp:Label ID="lblMostrar" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 604px">
                <asp:Button ID="btnMetodo" runat="server" OnClick="btnMetodo_Click" Text="Metodo" />
                Información devuelta:&nbsp;&nbsp;
                <asp:Label ID="lblMetodo" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Timer ID="timer" runat="server" Enabled="False" Interval="2000" OnTick="Timer1_Tick">
                </asp:Timer>
            &nbsp;</td>
        </tr>
    </table>
</asp:Content>
