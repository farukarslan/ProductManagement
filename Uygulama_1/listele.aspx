<%@ Page Title="" Language="C#" MasterPageFile="~/TUZLAMASTER.Master" AutoEventWireup="true" CodeBehind="listele.aspx.cs" Inherits="Uygulama_1.listele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-3 col-md-2 sidebar">
                <ul class="nav nav-sidebar">
                    <asp:Repeater ID="Repeater_kategori" runat="server">
                        <ItemTemplate>
                            <li><a href="listele.aspx?katidyolla=<%# Eval("id")%>"><%# Eval("kategori_ismi")%></a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
            <div class="col-sm-9 col-sm-offset-3 col-md-10 col-md-offset-2 main">
                <h2 class="sub-header">Ürün Detayları
                    <asp:Label ID="Label_katismi" runat="server" Text="Label"></asp:Label>
                </h2>
                <br />

                <br />
                <div class="table-responsive">
                    <table class="table table-striped">

                        <tbody>
                            <asp:Repeater ID="Repeater_urunliste" runat="server">

                                <ItemTemplate>

                                    <tr class="danger">
                                        <td><%# Eval("urun_ismi")%></td>
                                        <td><%# Eval("fiyat")%></td>
                                        <td><%# Eval("markasi")%></td>
                                        <td>
                                            <img style="width: 100px;" src="<%# Eval("resim_ismi")%>" /></td>
                                        <td>><a href="sil.aspx?urunidyolla=<%# Eval("id")%>"> SİL </a></td>
                                        <td>><a href="guncel.aspx?urunidyolla=<%# Eval("id")%>"> GÜNCELLE </a></td>
                                    </tr>

                                </ItemTemplate>
                                <AlternatingItemTemplate>
                                    <tr class="warning">
                                        <td><%# Eval("urun_ismi")%></td>
                                        <td><%# Eval("fiyat")%></td>
                                        <td><%# Eval("markasi")%></td>
                                        <td>
                                            <img style="width: 100px;" src="<%# Eval("resim_ismi")%>" /></td>
                                        <td>><a href="sil.aspx?urunidyolla=<%# Eval("id")%>"> SİL </a></td>
                                        <td>><a href="guncel.aspx?urunidyolla=<%# Eval("id")%>"> GÜNCELLE </a></td>
                                    </tr>
                                </AlternatingItemTemplate>
                            </asp:Repeater>

                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
