<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practica.Linq.UI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">   
        <div class="panel panel-default">
              <div class="panel-heading">Practica LinQ</div>
              <div class="panel-body">
                    <asp:Button ID="consigna1" runat="server" CssClass="btn btn-primary" Text="Consigna 1" OnClick="consigna1_Click"/>
                    <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" Text="Consigna 2" OnClick="Button2_Click"/>
                    <asp:Button ID="Button3" runat="server" CssClass="btn btn-primary" Text="Consigna 3" OnClick="Button3_Click"/>
                    <asp:Button ID="Button4" runat="server" CssClass="btn btn-primary" Text="Consigna 4" OnClick="Button4_Click"/>
                    <asp:Button ID="Button5" runat="server" CssClass="btn btn-primary" Text="Consigna 5" OnClick="Button5_Click"/>
                    <asp:Button ID="Button6" runat="server" CssClass="btn btn-primary" Text="Consigna 6" OnClick="Button6_Click"/>
                    <asp:Button ID="Button7" runat="server" CssClass="btn btn-primary" Text="Consigna 7" OnClick="Button7_Click"/>
              </div>
        </div>

        <div class="panel panel-default">
              <div class="panel-heading">Consignas opcionales</div>
              <div class="panel-body">
                    <asp:Button ID="Button8" runat="server" CssClass="btn btn-primary" Text="Consigna 8" OnClick="Button8_Click"/>
                    <asp:Button ID="Button9" runat="server" CssClass="btn btn-primary" Text="Consigna 9" OnClick="Button9_Click"/>
                    <asp:Button ID="Button10" runat="server" CssClass="btn btn-primary" Text="Consigna 10" OnClick="Button10_Click"/>
                    <asp:Button ID="Button11" runat="server" CssClass="btn btn-primary" Text="Consigna 11" OnClick="Button11_Click"/>
                    <asp:Button ID="Button12" runat="server" CssClass="btn btn-primary" Text="Consigna 12" OnClick="Button12_Click"/>
                    <asp:Button ID="Button13" runat="server" CssClass="btn btn-primary" Text="Consigna 13" OnClick="Button13_Click"/>
              </div>
        </div>

        <div class="panel panel-default">
              <div class="panel-heading">Resultado</div>
              <div class="panel-body">
                  <div id="contenedor-resultado"> 
                      <asp:DataGrid ID="dgvResultado" runat="server">

                      </asp:DataGrid>
                  </div>
              </div>
        </div>

    </div>

</asp:Content>
