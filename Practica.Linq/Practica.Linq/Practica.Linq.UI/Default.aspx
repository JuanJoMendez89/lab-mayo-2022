<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practica.Linq.UI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel runat="server">
        <ContentTemplate>

            <div id="contenedor" class="container-fluid">   
                <asp:HiddenField ID="val" ClientIDMode="Static" runat="server" />
                <div class="panel panel-default">
                        <div class="panel-heading">Practica LinQ</div>
                        <div class="panel-body">
                            <asp:Button ID="BtnConsigna1" runat="server" CssClass="btn btn-primary" Text="Consigna 1" OnClientClick="return IngresarCustomerID()" OnClick="BtnConsigna1_Click" ToolTip="<%$Resources:Concepts, Consigna1 %>" />             
                            <asp:Button ID="BtnConsigna2" runat="server" CssClass="btn btn-primary" Text="Consigna 2" OnClick="BtnConsigna2_Click" ToolTip="<%$Resources:Concepts, Consigna2 %>"/>
                            <asp:Button ID="BtnConsigna3" runat="server" CssClass="btn btn-primary" Text="Consigna 3" OnClick="BtnConsigna3_Click" ToolTip="<%$Resources:Concepts, Consigna3 %>"/>
                            <asp:Button ID="BtnConsigna4" runat="server" CssClass="btn btn-primary" Text="Consigna 4" OnClick="BtnConsigna4_Click" ToolTip="<%$Resources:Concepts, Consigna4 %>"/>
                            <asp:Button ID="BtnConsigna5" runat="server" CssClass="btn btn-primary" Text="Consigna 5" OnClick="BtnConsigna5_Click" ToolTip="<%$Resources:Concepts, Consigna5 %>"/>
                            <asp:Button ID="BtnConsigna6" runat="server" CssClass="btn btn-primary" Text="Consigna 6" OnClick="BtnConsigna6_Click" ToolTip="<%$Resources:Concepts, Consigna6 %>"/>
                            <asp:Button ID="BtnConsigna7" runat="server" CssClass="btn btn-primary" Text="Consigna 7" OnClick="BtnConsigna7_Click" ToolTip="<%$Resources:Concepts, Consigna7 %>"/>
                        </div>
                </div>

                <div class="panel panel-default">
                        <div class="panel-heading">Consignas opcionales</div>
                        <div class="panel-body">
                            <asp:Button ID="BtnConsigna8" runat="server" CssClass="btn btn-primary" Text="Consigna 8" OnClick="BtnConsigna8_Click" ToolTip="<%$Resources:Concepts, Consigna8 %>"/>
                            <asp:Button ID="BtnConsigna9" runat="server" CssClass="btn btn-primary" Text="Consigna 9" OnClick="BtnConsigna9_Click" ToolTip="<%$Resources:Concepts, Consigna9 %>"/>
                            <asp:Button ID="BtnConsigna10" runat="server" CssClass="btn btn-primary" Text="Consigna 10" OnClick="BtnConsigna10_Click" ToolTip="<%$Resources:Concepts, Consigna10 %>"/>
                            <asp:Button ID="BtnConsigna11" runat="server" CssClass="btn btn-primary" Text="Consigna 11" OnClick="BtnConsigna11_Click" ToolTip="<%$Resources:Concepts, Consigna11 %>"/>
                            <asp:Button ID="BtnConsigna12" runat="server" CssClass="btn btn-primary" Text="Consigna 12" OnClick="BtnConsigna12_Click" ToolTip="<%$Resources:Concepts, Consigna12 %>"/>
                            <asp:Button ID="BtnConsigna13" runat="server" CssClass="btn btn-primary" Text="Consigna 13" OnClick="BtnConsigna13_Click" ToolTip="<%$Resources:Concepts, Consigna13 %>"/>
                        </div>
                </div>

                <div class="panel panel-default">
                        <div class="panel-heading">Descripcion</div>
                        <div class="panel-body">
                            <label id="Descripcion" runat="server"></label>
                        </div>
                </div>

                <div class="panel panel-default">
                        <div class="panel-heading">Resultado</div>
                        <div class="panel-body">
                            <div id="contenedor-resultado"> 
                                <asp:DataGrid ID="dgvResultado" runat="server" CssClass="table table-striped">
                                </asp:DataGrid>
                            </div>
                        </div>
                </div>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>


</asp:Content>
