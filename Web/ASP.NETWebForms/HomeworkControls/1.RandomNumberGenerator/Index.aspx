<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_1.RandomNumberGenerator.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="RandomForm" runat="server">
        <label runat="server" for="From">Range Start: </label>
        <input runat="server" type="text" id="From" />
        <label runat="server" for="To">Range To: </label>
        <input runat="server" type="text" id="To" />
        <input runat="server" type="button" value="Generate" onserverclick="Random_ServerClick" />
        <h3 runat="server" id="Result"></h3>
    </form>
</body>
</html>
