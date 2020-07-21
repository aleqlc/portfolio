using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace AboutUIAutomationInvoke
{
    class AECollection
    {
        AutomationElementCollection collection;
        DataTable dataTable;
        public DataTable DataTable
        {
            get
            {
                if (dataTable == null)
                {
                    dataTable = MakeDataTable();
                }
                return dataTable;
            }
        }
        private DataTable MakeDataTable()
        {
            dataTable = new DataTable("AETable");
            dataTable.Columns.Add(new DataColumn("name", typeof(string)));
            dataTable.Columns.Add(new DataColumn("ae", typeof(AutomationElement)));
            dataTable.Columns.Add(new DataColumn("aeInvokePattern", typeof(object)));

            DataColumn[] pk = new DataColumn[1];
            pk[0] = new DataColumn("aeid", typeof(string));
            dataTable.Columns.Add(pk[0]);
            dataTable.PrimaryKey = pk;

            DataRow dr;
            object obj;

            foreach(AutomationElement ae in collection)
            {
                dr = dataTable.NewRow();

                dr["name"] = ae.Current.Name;
                dr["aeid"] = ae.Current.GetHashCode();
                if(ae.TryGetCurrentPattern(InvokePattern.Pattern, out obj))
                {
                    dr["aeInvokePattern"] = obj;
                    dr["ae"] = ae;
                    dataTable.Rows.Add(dr);
                }
            }
            return dataTable;
        }

        public AECollection(string proname)
        {

        Process process = Process.Start(proname);
            Thread.Sleep(3000);

            IntPtr MainHWnd = process.MainWindowHandle;

            AutomationElement ae = AutomationElement.FromHandle(MainHWnd);
            Condition condition = new AndCondition(
                new PropertyCondition(AutomationElement.IsInvokePatternAvailableProperty, true),
                new PropertyCondition(AutomationElement.IsEnabledProperty, true));
            collection = ae.FindAll(TreeScope.Children, condition);
        }

        public bool InvokeAE(string aeid)
        {
            DataRow dr = dataTable.Rows.Find(aeid);

            if (dr == null)
            {
                return false;
            }

            object obj = dr["aeInvokePattern"];
            InvokePattern invokePattern = obj as InvokePattern;

            invokePattern.Invoke();
            return true;
        }
    }
}
