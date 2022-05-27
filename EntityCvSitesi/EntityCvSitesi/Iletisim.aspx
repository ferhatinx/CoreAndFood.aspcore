<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="EntityCvSitesi.Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered table-success table-striped">
        <thead>
            <tr>

                <th scope="col">Ad Soyad</th>
                <th scope="col">E-posta Adresi</th>
                <th scope="col">Konu</th>
                <th scope="col">Mesaj</th>

            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("ADSOYAD")%></td>
                        <td><%#Eval("MAIL")%></td>
                        <td><%#Eval("KONU")%></td>
                        <td>
                          <%#Eval("MESAJ")%>
                        </td>

                    </tr>

                </ItemTemplate>
            </asp:Repeater>


        </tbody>
    </table>
</asp:Content>
