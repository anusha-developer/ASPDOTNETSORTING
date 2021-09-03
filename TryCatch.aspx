<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryCatch.aspx.cs" Inherits="ASPDOTNETSORTING.TryCatch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Exception Handling Example</h3>
            <asp:Label ID="lblMessage" CssClass="bg-error" runat="server" Text="Message" Visible="false"></asp:Label>
            <br />
            <label>This Should be a Decimal</label>
            <table>
                <tr>
                    <td>
                        <asp:TextBox ID="txtDecimal" runat="server"></asp:TextBox>
                    </td>
                   
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit"  CssClass="btn btn-success" OnClick="btnSubmit_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
