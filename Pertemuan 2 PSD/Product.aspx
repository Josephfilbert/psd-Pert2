<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Pertemuan_2_PSD.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pertemuan 2</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>Nama :</td>
                <td>
                    <asp:TextBox ID="txtNama" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Harga :</td>
                <td>
                    <asp:TextBox ID="txtHarga" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click"/>
                </td>
            </tr>


        </table>
    </div>
    </form>
</body>
</html>
