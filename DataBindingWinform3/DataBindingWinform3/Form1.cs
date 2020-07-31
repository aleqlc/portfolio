using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingWinform3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Department> departments = new List<Department>();

            Department d1 = new Department("Computer Network");
            d1.Add(new Student("name1", "address1"));
            d1.Add(new Student("name2", "address2"));

            Department d2 = new Department("Computer Science");
            d2.Add(new Student("name3", "address3"));
            d2.Add(new Student("name4", "address4"));
            d2.Add(new Student("name5", "address5"));

            departments.Add(d1);
            departments.Add(d2);

            BindingSource cboBindingSource = new BindingSource();
            BindingSource lboBindingSource = new BindingSource();
            
            cboBindingSource.DataSource = departments;
            
            lboBindingSource.DataSource = cboBindingSource;
            lboBindingSource.DataMember = "Members";
            
            comboBox1.DataSource = cboBindingSource;
            comboBox1.DisplayMember="DepartmentName";
            
            listBox1.DataSource = lboBindingSource;
            listBox1.DisplayMember = "StudentName";
            
            textBox1.DataBindings.Add("Text", lboBindingSource, "StudentAddress");
        }
    }
}
