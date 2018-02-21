<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HW 2 - Marco Colasito</title>

</head>

<body>
    <p>Home</p>

    <h2>Course Registration System</h2>

    <form id="limit" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Available Classes</td>
                    <td>&nbsp;</td>
                    <td>Registered Classes</td>
                </tr>
                <tr>
                    <td>
                        <asp:ListBox ID="lbxAvailableClasses" runat="server"  Height="200px" SelectionMode="Multiple"></asp:ListBox>
                    </td>
                    <td>
                        <asp:Button ID="add_btn" runat="server" Text="Add" OnClick="btnAdd_Click" />
                        <br />
                        <asp:Button ID="del_btn" runat="server" Text="Remove" OnClick="btnRemove_Click"/>
                        <br />
                        <asp:Button ID="reset_btn" runat="server" Text="Reset" OnClick="reset"/>
                        <br />
                        Total Hours:<asp:Label ID="lblHours" runat="server"></asp:Label>
                        <br />
                        Total Cost:<asp:Label ID="lblCost" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:ListBox ID="lbxRegisteredClasses" runat="server" Height="180px" Width="110px" SelectionMode="Multiple"></asp:ListBox>
                    </td>
                </tr>
            </table>

        </div>
        You cannot register for more than 19 hours

    </form>
</body>
</html>
