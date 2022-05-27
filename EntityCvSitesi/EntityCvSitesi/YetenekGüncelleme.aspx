<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekGüncelleme.aspx.cs" Inherits="EntityCvSitesi.YetenekGüncelleme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="container">
        <h2><strong>Yetenek Güncelle</strong></h2>
        <hr />
        
        <div class="form-group">
            <label class="form-label">Yetenek Adı</label>
            <asp:TextBox ID="txtyetad" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
         <div class="form-group">
            <label class="form-label">Derece</label>
            <asp:TextBox ID="txtyetderece" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" />
    </div>
</asp:Content>
