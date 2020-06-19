using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Charts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportDocument r = new ReportDocument();
            r.Load(Server.MapPath("~/CrystalReport1.rpt"));
            CrystalReportViewer1.ReportSource = r;
        }
    }
}