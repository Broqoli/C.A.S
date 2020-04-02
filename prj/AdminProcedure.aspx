<%@ Page Title="Admin Services - C.A.S" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminProcedure.aspx.cs" Inherits="Coiffeur_Appointment_System.AdminProcedure" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            font-size: xx-large;
            text-align: center;
            height: 100px;
        }
      
        .auto-style10 {
            width: 421px;
            font-size: xx-large;
            text-align: center;
            height: 100px;
        }
        .auto-style11 {
            width: 374px;
            font-size: xx-large;
            text-align: center;
            height: 100px;
        }
        .auto-style14 {
            width: 429px;
        }
        .auto-style15 {
            width: 309px;
        }
        .auto-style16 {
            width: 100%;
            height: 116px;
        }
        .auto-style17 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style10">PROCEDURE</td>
            <td class="auto-style11">APPROXIMATE TIME</td>
            <td class="auto-style8">PRICE</td>
        </tr>
    </table>
    &nbsp;<asp:DataList ID="DataList1" runat="server" Height="184px" Width="1046px">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style9">
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </td>
                    <td class="auto-style13">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("service_name") %>'></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("service_id") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    <br />
    <table class="auto-style16">
        <tr>
            <td class="auto-style14">Procedure Name:
                <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style15">Estimated Time:
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
            <td>Total Price:
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style17">
                <asp:Button ID="Button1" runat="server" Height="40px" Text="ADD" Width="137px" />
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
