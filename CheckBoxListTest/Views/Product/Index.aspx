<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CheckedList<Product>>" %>
<%@ Import Namespace="CheckBoxListTest.Controllers"%>
<%@ Import Namespace="CheckBoxListTest.Models"%>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Products
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>
    <% using (Html.BeginForm()) { %>
            
    <%--<% for (int i = 0; i < Model.Count; i++) {
        Product product = Model.Keys.ToList()[i]; %>
        <p>
            <%= Html.Hidden("model[" + i + "].Key.Name", product.Name)%>
            <%= Html.CheckBox("model[" + i + "].Value", Model[product]) %> <%=Html.Encode(product.Name) %>
        </p>--%>
        <%= Html.CheckBoxList("model", "Id", "Name", Model, x=>x.Id, x=>x.Name) %>
    <%--<% } %>--%>
    <input type="submit" id="button" value="Save" />
    <% } %>
    
</asp:Content>
