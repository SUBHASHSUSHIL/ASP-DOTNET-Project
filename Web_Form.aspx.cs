using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_DOTNET
{
    public partial class Web_Form : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F1LI6MI;initial catalog=ASP_DOTNET_CRUD;integrated security=true;");
        SqlCommand cmd;
        public string Query { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Query = "Emp_Insert";
                using (cmd = new SqlCommand(Query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Email", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@Designation", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Salary", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@MobileNo", TextBox6.Text);
                    cmd.Parameters.AddWithValue("@Address", TextBox7.Text);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('Inserted Successfully..')</script>");
                    
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                Clear();
            }
            
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                Query = "Emp_Select";
                using(cmd = new SqlCommand(Query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
                    if(con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        TextBox1.Text = dr["Id"].ToString();
                        TextBox2.Text = dr["Name"].ToString();
                        TextBox3.Text = dr["Email"].ToString();
                        TextBox4.Text = dr["Designation"].ToString();
                        TextBox5.Text = dr["Salary"].ToString();
                        TextBox6.Text = dr["MobileNo"].ToString();
                        TextBox7.Text = dr["Address"].ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                { con.Close(); }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Query = "Emp_Update";
                using( cmd = new SqlCommand(Query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Name", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Email", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@Designation", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Salary", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@MobileNo", TextBox6.Text);
                    cmd.Parameters.AddWithValue("@Address", TextBox7.Text);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('Inserted Successfully..')</script>");
                }
            }
            catch(Exception ex)
            {
                Response.Write($"Error: {ex.ToString()}");
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                { con.Close(); }
                Clear();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Query = "Emp_Delete";
                using(cmd = new SqlCommand(Query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
                    if(con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('Deleted Successfully..')</script>");
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                { con.Close(); }
                Clear();
            }
        }

        private void Clear()
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox5.Text = string.Empty;
            TextBox6.Text = string.Empty;
            TextBox7.Text = string.Empty;
        }
    }
}