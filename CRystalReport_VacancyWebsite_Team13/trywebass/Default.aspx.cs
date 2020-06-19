using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ReportDocument r = new ReportDocument();
        r.Load(Server.MapPath("~/CrystalReport0.rpt"));

        CrystalReportViewer1.ReportSource = r;

    }
}