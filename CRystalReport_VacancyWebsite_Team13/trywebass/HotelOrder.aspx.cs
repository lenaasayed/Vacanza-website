using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using trywebass;

    public partial class HotelOrder : System.Web.UI.Page
    {
    char c;

    Controller Ctrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            c ='0';
            Ctrl = new Controller();
        }
    
        protected void orderstar_Click(object sender, EventArgs e)
        {
        

        GridView1.DataSource = Ctrl.HotelOrderp(c);
        GridView1.EditIndex = -1;
        GridView1.DataBind();
        
        if (c == '0')
            c = '1';
        else c = '0';
    }
}
