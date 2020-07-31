using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InotifyPracticeWinform2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            University u1 = new University("acronym1", "name1", "address1");
            University u2 = new University("acronym2", "name2", "address2");
            University u3 = new University("acronym3", "name3", "address3");
            University u4 = new University("acronym4", "name4", "address4");
            List<University> ListUniv = new List<University>();
            ListUniv.Add(u1);
            ListUniv.Add(u2);
            ListUniv.Add(u3);
            ListUniv.Add(u4);
            BindingSource cboBindingSource = new BindingSource();
            cboBindingSource.DataSource = ListUniv;
            comboBox1.DataSource = cboBindingSource;
            comboBox1.DisplayMember = "UnivAcronym";
            textBox1.DataBindings.Add("Text", cboBindingSource, "UnivName");
            textBox2.DataBindings.Add("Text", cboBindingSource, "UnivAddress");
            
        }
    }
}
