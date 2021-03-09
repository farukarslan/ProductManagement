<%@ Page Title="" Language="C#" MasterPageFile="~/TUZLAMASTER.Master" AutoEventWireup="true" CodeBehind="urunekle.aspx.cs" Inherits="Uygulama_1.urunekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 400px">

        <h1 class="bg-info">Ürün Ekle</h1>
        <div class="form-group">
            <label class="sr-only" for="exampleInputAmount">Amount (in dollars)</label>
            <div class="input-group">
                <div class="input-group-addon">Kategori Seçiniz</div>
                <asp:DropDownList class="btn btn-default dropdown-toggle" ID="DropDownList1" runat="server"></asp:DropDownList>
            </div>
            <div class="input-group">
                <div class="input-group-addon">Ürün İsmini Giriniz</div>
                <asp:TextBox ID="TextBox_urunismi" runat="server" class="form-control" placeholder="Mega Tablet"></asp:TextBox>
            </div>
            <div class="input-group">
                <div class="input-group-addon">Ürün Fiyatını Girin</div>
                <asp:TextBox ID="TextBox_urunfiyati" runat="server" class="form-control" placeholder="100"></asp:TextBox>
            </div>
            <div class="input-group">
                <div class="input-group-addon">Ürün Markası Girin</div>

                <asp:TextBox ID="TextBox_urunmarkasi" runat="server" class="form-control" placeholder="Casper"></asp:TextBox>
            </div>
        </div>
        <div class="input-group">
            <div class="input-group-addon"><span class="glyphicon glyphicon-upload"></span></div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <br />
        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Kaydet" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
