﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sorting.aspx.cs" Inherits="ASPDOTNETSORTING.Sorting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sorting in GridView</title>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <table>
                <tr>
                    <td style="font-size:x-large;background-color:aqua;font-weight:bold"> Sorting in GridView</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="gvEmployeeData" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" AllowSorting="True" OnSorting="OnSorting">
                            <Columns>
                                <asp:BoundField HeaderText="EmployeeId" DataField="EmployeeId"  SortExpression="EmployeeId">
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                                </asp:BoundField>
                                <asp:BoundField HeaderText="EmployeeName" DataField="EmployeeName"  SortExpression="EmployeeName">
<ItemStyle HorizontalAlign="Left"></ItemStyle>
                                </asp:BoundField>
                                <asp:BoundField HeaderText="EmployeeSalary" DataField="EmployeeSalary"  SortExpression="EmployeeSalary  ">
<ItemStyle HorizontalAlign="Left"></ItemStyle>
                                </asp:BoundField>
                            </Columns>
                            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                            <RowStyle BackColor="White" ForeColor="#330099" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                            <SortedAscendingCellStyle BackColor="#FEFCEB" />
                            <SortedAscendingHeaderStyle BackColor="#AF0101" />
                            <SortedDescendingCellStyle BackColor="#F6F0C0" />
                            <SortedDescendingHeaderStyle BackColor="#7E0000" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMessage" runat="server"  Font-Bold="true" ForeColor="Green"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
