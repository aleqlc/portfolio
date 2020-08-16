using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqCrudInWinform
{

    public partial class Form1 : Form
    {
        SalesDataContext salesDb = new SalesDataContext();//dbml파일 인스턴스화
        public Form1()
        {
            InitializeComponent();

            //Read
            var data = salesDb.Customers//Customer에 s붙여야함
                .Select(c => c);//모든 정보 label에 읽어옴
            List<Customers> customers = data.ToList();//Customer에 s붙여야함

            foreach(Customers c in customers)
            {
                lblResult.Text += $"{c.FirstName} {c.LastName} has a budget of {c.Budget}\n";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            Customers customerInsert = new Customers()
            {
                FirstName = "Besty",
                LastName = "Smith",
                Budget = 4000
            };
            salesDb.Customers.InsertOnSubmit(customerInsert);
            salesDb.SubmitChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var data = salesDb.Customers//Customer에 s붙여야함
                .Where(c => c.FirstName == "Besty")
                .Select(c => c);

            List<Customers> customers = data.ToList();

            customers[0].FirstName = "Elizabeth";
            salesDb.SubmitChanges();
            lblResult.Text = "Updated";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var data = salesDb.Customers//Customer에 s붙여야함
                .Where(c => c.CustomerId == 5)
                .Select(c => c);

            List<Customers> customers = data.ToList();

            salesDb.Customers.DeleteOnSubmit(customers[0]);

            salesDb.SubmitChanges();

            lblResult.Text = "Deleted";
        }
    }
}
