using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApp12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                LoadData();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
         GridViewRow _row =(GridViewRow)     GridView1.Rows[e.RowIndex];
          Label lblId =(Label) _row.FindControl("Label1");
          TextBox txtName = (TextBox)_row.FindControl("TextBox2");
            TextBox txtPrice = (TextBox)_row.FindControl("TextBox3");
            TextBox txtQut = (TextBox)_row.FindControl("TextBox4");
            TextBox txtStock = (TextBox)_row.FindControl("TextBox5");
            SqlConnection _con = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=DumSms;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _con.Open();
            //UPDATE PRODUCTS SET PRONAME =@PNAME,PRICE =@PRICE,QUANTITY=@QUT,INSTOCK=@ISSTOCK WHERE ID=@ID
            SqlCommand _cmd = new SqlCommand("UPDATE PRODUCTS SET PRONAME =@PNAME,PRICE =@PRICE,QUANTITY=@QUT,INSTOCK=@ISSTOCK WHERE ID=@ID", _con);
            _cmd.Parameters.AddWithValue("@ID", lblId.Text);
            _cmd.Parameters.AddWithValue("@PNAME", txtName.Text);
            _cmd.Parameters.AddWithValue("@PRICE", txtPrice.Text);
            _cmd.Parameters.AddWithValue("@QUT", txtQut.Text);
            _cmd.Parameters.AddWithValue("@ISSTOCK", txtStock.Text);
            _cmd.ExecuteNonQuery();
            _con.Close();
            GridView1.EditIndex = -1;
            LoadData();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadData();
        }
        public void LoadData() {
            SqlConnection _con = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=DumSms;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _con.Open();
            SqlCommand _cmd = new SqlCommand("SELECT * FROM PRODUCTS", _con);
            SqlDataReader _dReader = _cmd.ExecuteReader();
            GridView1.DataSource = _dReader;
            GridView1.DataBind();
            _con.Close();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow _row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lblId = (Label)_row.FindControl("Label1");
            SqlConnection _con = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=DumSms;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _con.Open();
            SqlCommand _cmd = new SqlCommand("DELETE FROM PRODUCTS WHERE ID =@ID", _con);
            _cmd.Parameters.AddWithValue("@ID", lblId.Text);
            _cmd.ExecuteNonQuery();
            _con.Close();
            LoadData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection _con = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=DumSms;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _con.Open();
            //UPDATE PRODUCTS SET PRONAME =@PNAME,PRICE =@PRICE,QUANTITY=@QUT,INSTOCK=@ISSTOCK WHERE ID=@ID
            SqlCommand _cmd = new SqlCommand("INSERT INTO PRODUCTS VALUES(@PNAME,@PRICE,@QUT,@ISSTOCK)", _con);
           
            _cmd.Parameters.AddWithValue("@PNAME", TextBox1.Text);
            _cmd.Parameters.AddWithValue("@PRICE", TextBox6.Text);
            _cmd.Parameters.AddWithValue("@QUT", TextBox7.Text);
            _cmd.Parameters.AddWithValue("@ISSTOCK", TextBox8.Text);
            _cmd.ExecuteNonQuery();
            _con.Close();
            LoadData();
        }
    }
}