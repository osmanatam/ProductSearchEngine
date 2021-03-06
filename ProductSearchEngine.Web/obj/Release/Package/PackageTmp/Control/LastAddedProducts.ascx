﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LastAddedProducts.ascx.cs"
    Inherits="ProductSearchEngine.Web.Control.LastAddedProducts" %>
<div id="featured_side" class="s_box clearfix">
    <h2>
        Last Added Products</h2>
    <asp:Repeater ID="LastAddedProductsRepeater" runat="server" OnItemDataBound="LastAddedProductsRepeater_DataBound">
    <ItemTemplate>
    

        <div class="s_item s_size_1 clearfix">
            <a class="s_thumb" href="#">
                <img src='/Images/Products/<%#GetProductUniqueName(Container.DataItem) %>' width="38"
                    height="38" title='<%#Eval("Title") %>' alt='<%#Eval("Title") %>' /></a>
            <h3>
                <a href='/ProductDetail.aspx?p=<%#Eval("Id") %>'>
                    <%#Eval("Title") %></a></h3>
            <p>
                <a href='/ProductDetail.aspx?p=<%#Eval("Id") %>'><span class="s_main_color"><span class="s_currency s_before">TL </span>
                    <%#Eval("Price") %></span></a></p>
            <div style="display: none" runat="server" ID="RatingHolderDiv" class="s_rating_holder clearfix">
                <p class="s_rating s_rating_small s_rating_5 left">
                    <span style='width: <%#GetRatePercentage(Container.DataItem) %>%;' class="s_percent">
                    </span>
                </p>
                <span class="left">&nbsp;<%#GetRate(Container.DataItem) %>/5</span></div>
        </div>
            </ItemTemplate>
    </asp:Repeater>
</div>
