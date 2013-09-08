<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_4.StudentRegistration.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="First Name: " runat="server" AssociatedControlID="FirstName" />
        <asp:TextBox runat="server" ID="FirstName" />
        <br />
        <asp:Label Text="Last Name: " runat="server" AssociatedControlID="LastName" />
        <asp:TextBox runat="server" ID="LastName" />
        <br />
        <asp:Label Text="Faculty Number: " runat="server" AssociatedControlID="FacNumber" />
        <asp:TextBox runat="server" ID="FacNumber" />
        <br />
        <asp:Label Text="University: " runat="server" AssociatedControlID="UniversitySelect" />
        <asp:DropDownList runat="server" ID="UniversitySelect">
            <asp:ListItem Text="Sofia University" />
            <asp:ListItem Text="UNWE" />
            <asp:ListItem Text="Teleric Academy" />
        </asp:DropDownList>
        <br />
        <asp:Label Text="Speciality: " runat="server" AssociatedControlID="SpecialitySelect" />
        <asp:DropDownList runat="server" ID="SpecialitySelect">
            <asp:ListItem Text="IT" />
            <asp:ListItem Text="Science" />
            <asp:ListItem Text="Art" />
        </asp:DropDownList>
        <br />
        <asp:Label Text="Courses: " runat="server" AssociatedControlID="CoursesList" />
        <asp:ListBox runat="server" SelectionMode="Multiple" ID="CoursesList">
            <asp:ListItem Text="JavaScript" />
            <asp:ListItem Text="Biology" />
            <asp:ListItem Text="Music" />
        </asp:ListBox>
        <br />
        <asp:Button Text="Submit" runat="server" OnClick="Submit_Click" />
    </div>
        <asp:Panel runat="server" ID="Details">

        </asp:Panel>
    </form>
</body>
</html>
