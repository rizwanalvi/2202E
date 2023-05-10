using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMSApp.Models;
namespace SMSApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //StudentDAL _StdDal = new StudentDAL();
            //_StdDal.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text);
            new StudentDAL().Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text);
            LoadData();
        }

        public void LoadData() {
            GridView1.DataSource = new StudentDAL().ReadAllData();
            GridView1.DataBind();
        }
    }
}