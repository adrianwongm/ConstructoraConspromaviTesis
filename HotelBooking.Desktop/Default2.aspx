<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" Runat="Server"> 
   
    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" Width="100%" Theme="Metropolis">
        <Items>
            <dx:LayoutGroup ColCount="4" Caption="Datos de usuario">
                <Items>
                    <dx:LayoutItem Caption="Empleado">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxComboBox runat="server" ID="cmbEmpleado" ClientInstanceName="cmbEmpleado"></dx:ASPxComboBox>

                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Usuario">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtUsuario" ClientInstanceName="txtUsuario" runat="server" Width="170px" Theme="Metropolis"></dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Contrasena">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox runat="server" Width="170px" Password="True" ClientInstanceName="txtPassword" ID="txtPassword"></dx:ASPxTextBox>


                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Estado">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxComboBox runat="server" ID="cmbEstado" ClientInstanceName="cmbEstado" Theme="Metropolis"></dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
            <dx:LayoutGroup Caption="REGISTROS">
                <Items>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxGridView ID="grdListadoUsuarios" runat="server" ClientInstanceName="grdListadoUsuarios"
                                    Theme="SoftOrange" OnDataBinding="grdListadoUsuarios_DataBinding" Width="100%">
                                    <Columns>
                                        <dx:GridViewCommandColumn ShowSelectButton="true"></dx:GridViewCommandColumn>
                                        <dx:GridViewDataColumn Caption="Login" FieldName="Usuario"></dx:GridViewDataColumn>
                                        <dx:GridViewDataColumn Caption="Empleado" FieldName="Empleado_Nombres"></dx:GridViewDataColumn>
                                        <dx:GridViewDataColumn Caption="Estado" FieldName="Estado"></dx:GridViewDataColumn>
                                    </Columns>
                                </dx:ASPxGridView>
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

