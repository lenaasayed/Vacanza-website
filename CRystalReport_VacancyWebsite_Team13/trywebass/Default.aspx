<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        
        <CR:CrystalReportViewer ID="CrystalReportViewer3" runat="server" AutoDataBind="true" ReportSourceID="CrystalReportSource2" />
        
        <CR:CrystalReportViewer ID="CrystalReportViewer2" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="~/crystalreportviewers/crystalimagehandler.asp" Height="1202px" ReportSourceID="CrystalReportSource3" ToolbarImagesFolderUrl="~/crystalreportviewers/crystalimagehandler.asp" ToolPanelWidth="200px" Width="1104px" />
        <CR:CrystalReportSource ID="CrystalReportSource3" runat="server">
            <Report FileName="CrystalReport3.rpt">
            </Report>
        </CR:CrystalReportSource>
        <CR:CrystalReportSource ID="CrystalReportSource2" runat="server">
            <Report FileName="CrystalReport4.rpt">
            </Report>
        </CR:CrystalReportSource>
        
        <CR:CrystalReportViewer ID="CrystalReportViewer4" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="~/crystalreportviewers/crystalimagehandler.asp" Height="1202px" ReportSourceID="CrystalReportSource6" ToolbarImagesFolderUrl="~/crystalreportviewers/crystalimagehandler.asp" ToolPanelWidth="200px" Width="1104px" />
        <CR:CrystalReportViewer ID="CrystalReportViewer5" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="~/crystalreportviewers/crystalimagehandler.asp" Height="1202px" ReportSourceID="CrystalReportSource7" ToolbarImagesFolderUrl="~/crystalreportviewers/crystalimagehandler.asp" ToolPanelWidth="200px" Width="1104px" />
        <CR:CrystalReportSource ID="CrystalReportSource7" runat="server">
            <Report FileName="CrystalReport7.rpt">
            </Report>
        </CR:CrystalReportSource>
        <CR:CrystalReportSource ID="CrystalReportSource6" runat="server">
            <Report FileName="CrystalReport6.rpt">
            </Report>
        </CR:CrystalReportSource>
        
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="~/crystalreportviewers/crystalimagehandler.asp" Height="1202px" ReportSourceID="CrystalReportSrc" ToolbarImagesFolderUrl="~/crystalreportviewers/crystalimagehandler.asp" ToolPanelWidth="200px" Width="1104px" BorderStyle="Dotted" BorderWidth="7px" OnDataBinding="Page_Load" OnLoad="Page_Load" OnPreRender="Page_Load" ShowAllPageIds="True" />
        <CR:CrystalReportSource ID="CrystalReportSrc" runat="server">
           
            <Report FileName="CrystalReport0.rpt">
 
            </Report>
        </CR:CrystalReportSource>
        
    </div>
</asp:Content>
