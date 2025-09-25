<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Button Kullanimi.aspx.cs" Inherits="ASPNET_Kontrolleri.Button_Kullanimi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Button Kullanımı</title>
    <style>
        .yakisikliButton {
            background-color: #09a916; /*Arkaplan rengi*/
            color: white; /*Yazı rengi*/
            padding: 10px 30px; /*İç boşluk (padding üst-alt sağ-sol)*/
            font-weight: 900; /*Yazı Kalınlığı*/
            font-size: 15px; /*Yazı Boyutu*/
            border: 1px solid #056b6d; /*Çerçeve rengi ve tipi*/
            border-radius: 10px; /*Çerçeve köşe yumuşaltma*/
        }
    </style>
</head>
<body>
    <%-- asp.net kontrollerinin çalışabilmesi için form etiketinin içinde olması gerekir --%>
    <form id="form1" runat="server">
        <div>
            <!--Her asp.net kontrolü ID'ye sahip olmak zorundadır-->
            <!--Her asp.net kontrolu runat attributuna sahip olmak zorundadır.-->
            <asp:Button ID="btn_tikla" Text="Tıkla" runat="server" CssClass="yakisikliButton" />
            <br />
            <asp:Button ID="btn_degistir" Text="Title Değiştir" runat="server" OnClick="btn_degistir_Click"/>
            <br />
            <asp:LinkButton ID="lbtn_tikla" Text="Link Görünümlü Button" runat="server" />
        </div>
    </form>
</body>
</html>
