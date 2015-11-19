<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.master" AutoEventWireup="true" CodeBehind="CreateCustomer.aspx.cs" Inherits="AdminstrationFrontend.CreateCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="content">
        <h1 runat="server" id="Headline">Create Customer</h1>
        <table>
            <tr>
                <td>
                    <asp:Label ID="FirstNameLabel" runat="server" Text="Firstname: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="FirstnameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LastnameLabel" runat="server" Text="Lasname: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="LastnameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="PhoneLabel" runat="server" Text="Phone: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="PhoneTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="MailLabel" runat="server" Text="E-mail: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="MailTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="StreetLabel" runat="server" Text="Street: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="StreetTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="HouseNumberLabel" runat="server" Text="House Number: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="HouseNumberTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="PostalCodeLabel" runat="server" Text="Postal Code: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="PostalCodeTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="CityLabel" runat="server" Text="City: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="NativeLabel" runat="server" Text="Native: "></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="NativeCheckBox" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="FreeRidesLabel" runat="server" Text="Free Rides: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="FreeRidesTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td style="text-align: right">
                    <asp:Button ID="SubmitButton" runat="server" Text="Create" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
