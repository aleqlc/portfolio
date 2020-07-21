using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication7.ServiceReference1;

namespace WebApplication7
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        protected void Button1_Click(object sender, EventArgs e)
        {
            InsertUser u = new InsertUser();
            u.Name = TextBox1.Text;
            u.Email = TextBox2.Text;
            string r = client.Insert(u);
            lblmsg.Text = r.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.gettestdata g = new ServiceReference1.gettestdata();
            g = client.GetInfo();
            DataTable dt = new DataTable("mytab");
            dt = g.usertab;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            UpdateUser u = new UpdateUser();
            u.UID = int.Parse(txtuid.Text);
            u.Name = TextBox1.Text;
            u.Email = TextBox2.Text;
            string result = client.Update(u);
            lblmsg.Text = result.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DeleteUser d = new DeleteUser();
            d.UID = int.Parse(txtuid.Text);
            string res = client.Delete(d);
            lblmsg.Text = res.ToString();
        }
    }
}