<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_3.PotentiallyDangerousText.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="Please enter some potentially dangerous text: " runat="server" AssociatedControlID="Text" />
        <asp:TextBox runat="server" ID="Text" />
        <asp:Button Text="Submit" runat="server" OnClick="Submit_Click" />
        <br />
        <asp:Label Text="Text you entered: " runat="server" />
        <asp:Label runat="server" ID="TheText" />
    </div>
    </form>
</body>
</html>
