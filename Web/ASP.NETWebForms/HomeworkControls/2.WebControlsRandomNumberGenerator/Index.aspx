<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_2.WebControlsRandomNumberGenerator.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #Result {
            font-size: 30px;
            color: #085c26;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="Range Start: " runat="server" AssociatedControlID="From" />
        <asp:TextBox runat="server" ID="From" />
        <asp:Label Text="Range To: " runat="server" AssociatedControlID="To" />
        <asp:TextBox runat="server" ID="To" />
        <asp:Button Text="Generate" runat="server" OnClick="Random_Click" />
        <br />
        <asp:Label runat="server" ID="Result" />
    </div>
    </form>
</body>
</html>
