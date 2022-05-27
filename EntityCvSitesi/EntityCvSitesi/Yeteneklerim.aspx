<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yeteneklerim.aspx.cs" Inherits="EntityCvSitesi.Yeteneklerim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered table-success table-striped">
        <thead>
            <tr>

                <th scope="col">ID</th>
                <th scope="col">Yetenek Adı</th>
                <th scope="col">Derece</th>
                <th scope="col">Güncelle</th>
                <th scope="col">Sil</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("ID")%></td>
                        <td><%#Eval("YETENEK")%></td>
                        <td><%#Eval("DERECE")%></td>
                        <td>
                            <asp:HyperLink CssClass="btn btn-danger" ID="HyperLink1" runat="server" NavigateUrl='<%#"YetenekSil.aspx?ID="+Eval("ID") %>'>Sil</asp:HyperLink>
                        <td>
                             <asp:HyperLink CssClass="btn btn-info" ID="HyperLink2" runat="server" NavigateUrl='<%#"YetenekGüncelleme.aspx?ID="+Eval("ID") %>'>Güncelleme</asp:HyperLink>
                        </td>
                    </tr>
                   
                </ItemTemplate>
            </asp:Repeater>
           

        </tbody>
    </table>
      <a href="YeniYetenek.aspx" class="btn btn-primary">Yeni Yetenek Ekle</a>
</asp:Content>

