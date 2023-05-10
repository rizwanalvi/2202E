<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SMSApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             </br>
            <asp:TextBox ID="TextBox2" runat="server">

            </asp:TextBox>
            </br>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
            <br />
            <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="STDID" HeaderText="STUDENT ID" />
                    <asp:BoundField DataField="STDNAME" HeaderText="STUDENT NAME" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
