<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextBox Kullanimi.aspx.cs" Inherits="ASPNET_Kontrolleri.TextBox_Kullanimi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Textbox metinsel veri girişi için kullanılan kontroldür. <br />
            içine yazılan veri kontroladi.text özelliği ile alınır. <br />
            <asp:TextBox ID="tb_metin" runat="server"> </asp:TextBox>
            <br />
            <asp:Button ID="btn_titleDeğiştir" runat="server" OnClick="btn_titleDeğiştir_Click" Text="Title Değiştir"/>
        </div>
    </form>
</body>
</html>
