<%@ Page Title="" Language="C#" MasterPageFile="~/TUZLAMASTER.Master" AutoEventWireup="true" CodeBehind="katlistele.aspx.cs" Inherits="Uygulama_1.katlistele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="table-responsive">
        <table class="table table-striped">
            <tbody>
                <asp:Repeater ID="Repeater_katliste" runat="server">
                    <ItemTemplate>
                        <tr class="danger">
                            <td><%# Eval("id")%></td>
                            <td><%# Eval("kategori_ismi")%></td>
                            <td>
                                <input type="button" value="Kategori Sil" onclick="confirmDelete(<%#Eval("id")%>)">
                            </td>
                        </tr>

                    </ItemTemplate>
                    <AlternatingItemTemplate>
                        <tr class="warning">
                            <td><%# Eval("id")%></td>
                            <td><%# Eval("kategori_ismi")%></td>
                            <td>
                                <input type="button" value="Kategori Sil" onclick="confirmDelete(<%#Eval("id")%>)">
                            </td>


                        </tr>
                    </AlternatingItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>



</asp:Content>
