<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Perfiles.aspx.cs" Inherits="Perfiles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" Runat="Server">

    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" Theme="SoftOrange"> 
        <Items>
            <dx:LayoutGroup>
                <Items>
                    <dx:LayoutItem>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox runat="server" ID="ASPxFormLayout1_E2"></dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterControlsPlaceHolder" Runat="Server">
</asp:Content>

