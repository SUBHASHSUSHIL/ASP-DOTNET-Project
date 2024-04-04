<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web_Form.aspx.cs" Inherits="ASP_DOTNET.Web_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <th colspan="2"> ASP CRUD</th>
                </tr>
                <tr>
                    <th>Id:</th>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Name</th>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Email Id:</th>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Designation:</th>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Salary:</th>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>MobileNo:</th>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Address:</th>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th colspan="2">
                        <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" />
                        <asp:Button ID="btnSelect" runat="server" Text="Select" OnClick="btnSelect_Click" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                    </th>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
