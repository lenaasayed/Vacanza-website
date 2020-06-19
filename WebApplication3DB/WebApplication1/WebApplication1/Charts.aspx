<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Charts.aspx.cs" Inherits="WebApplication1.Charts" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <script src="crystalreportviewers/js/crviewer/crv.js" type="text/javascript"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="Charts.aspx" Height="1202px" ReportSourceID="CrystalReportSource1" ToolbarImagesFolderUrl="Charts.aspx" ToolPanelWidth="200px" Width="1104px" />
            <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
                <Report FileName="CrystalReport1.rpt">
                </Report>
            </CR:CrystalReportSource>
        </div>
    </form>
</body>
</html>
