<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_6.WebCalculator.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>6. Calculator</title>
    <style>
        table {
            border: 1px solid black;
        }

        #DisplayCell {
            height: 20px;
            width: 137px;
            border: 1px solid black;
            text-align: right;
        }

        #Cell_Eq {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell ColumnSpan="4" ID="DisplayCell">
                <asp:label runat="server" ID="Display" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:button text="1" runat="server" OnClick="Btn1_Click" /></asp:TableCell>
            <asp:TableCell><asp:button text="2" runat="server" OnClick="Btn2_Click" /></asp:TableCell>
            <asp:TableCell><asp:button text="3" runat="server" OnClick="Btn3_Click" /></asp:TableCell>
            <asp:TableCell><asp:button text="+" runat="server" OnClick="Plus_Click" /></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:button text="4" runat="server" OnClick="Btn4_Click" /></asp:TableCell>
            <asp:TableCell><asp:button text="5" runat="server" OnClick="Btn5_Click" /></asp:TableCell>
            <asp:TableCell><asp:button text="6" runat="server" OnClick="Btn6_Click" /></asp:TableCell>
            <asp:TableCell><asp:button text="-" runat="server" OnClick="Minus_Click" /></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:button text="7" runat="server" OnClick="Btn7_Click" /></asp:TableCell>
            <asp:TableCell><asp:button text="8" runat="server" OnClick="Btn8_Click" /></asp:TableCell>
            <asp:TableCell><asp:button text="9" runat="server" OnClick="Btn9_Click" /></asp:TableCell>
            <asp:TableCell><asp:button text="X" runat="server" OnClick="Multiply_Click" /></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:button text="0" runat="server" OnClick="Btn0_Click" /></asp:TableCell>
            <asp:TableCell><asp:button text="C" runat="server" OnClick="Clear_Click" /></asp:TableCell>
            <asp:TableCell><asp:button text="&radic;" runat="server" OnClick="Sqrt_Click" /></asp:TableCell>
            <asp:TableCell><asp:button text="/" runat="server" OnClick="Divide_Click" /></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="4" ID="Cell_Eq" ><asp:button text="=" runat="server" OnClick="Equals_Click" /></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
    </form>
</body>
</html>
