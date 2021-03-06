﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SpecialProducts.ascx.cs" Inherits="ProductSearchEngine.Web.Control.SpecialProducts" %>

 <div id="special_home" class="grid_12">
            <h2 class="s_title_1">
                <span class="s_main_color">Specials</span> Products</h2>
            <div class="clear">
            </div>
            <div class="s_listing s_grid_view clearfix">
            <asp:Repeater ID="SpeacialProductsRepeater" runat="server">
            <ItemTemplate>
             <div class="s_item grid_2">
                    <a class="s_thumb" href='/ProductDetail.aspx?p=<%#Eval("Id") %>'>
                        <img src='/Images/Products/<%#GetProductUniqueName(Container.DataItem) %>' title='<%#Eval("Title") %>' alt='<%#Eval("Title") %>' /></a>
                    <h3>
                        <a href='/ProductDetail.aspx?p=<%#Eval("Id") %>'><%#Eval("Title") %></a></h3>
                    <p class="s_model">
                        Product <%#Eval("Id") %></p>
                    <p class="s_price s_promo_price" style="line-height:40px;">
                        <span
                            class="s_currency s_before">TL</span><%#Eval("Price") %></p>
                    <a class="s_button_add_to_cart" href='../ProductDetail.aspx?p=<%#Eval("Id") %>'><span class="s_icon_16"><span
                        class="s_icon"></span>View Details</span></a>
                </div>
            </ItemTemplate>
            </asp:Repeater>
               
               
                <div class="clear">
                </div>
            </div>
        </div>
