<%@ Page Title="" Language="C#" MasterPageFile="~/TUZLAMASTER.Master" AutoEventWireup="true" CodeBehind="kategoriekle.aspx.cs" Inherits="Uygulama_1.kategoriekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label_uyari" runat="server" Text=""></asp:Label><br />

    <div style="width: 400px">
        <h1 class="bg-info">Kategori Ekle</h1>
        <div class="form-group">
            <label class="sr-only" for="exampleInputAmount">Amount (in dollars)</label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Bu alan boş geçilemez"></asp:RequiredFieldValidator>
            <br />
            <div class="input-group">
                <div class="input-group-addon">Kategori İsmi</div>
                <asp:TextBox ID="TextBox1" class="form-control" placeholder="Örn: Beyaz Eşya" runat="server"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Kaydet" OnClick="Button1_Click" />

    </div>
</asp:Content>
