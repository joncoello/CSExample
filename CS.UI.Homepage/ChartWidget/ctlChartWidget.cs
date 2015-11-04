using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MYOB.CSS;

namespace CS.UI.Homepage.ChartWidget
{
    public partial class ctlChartWidget : Homepagebase
    {
        private DataTable _data;

        public ctlChartWidget()
        {
            InitializeComponent();
        }

        public override string DisplayName
        {
            get
            {
                return "Custom widget";
            }
        }

        public override void LoadData(bool Cache, bool StartNewThread)
        {
            if (!Cache)
            {
                if (StartNewThread)
                {
                    var t = new Thread(GetData);
                }
                else
                {
                    GetData();
                }
            }
        }

        private void GetData()
        {
            _data = new DataTable();
            _data.Columns.Add("Description", typeof(string));
            _data.Columns.Add("Count", typeof(int));
            _data.Rows.Add("Group 1", 46);
            _data.Rows.Add("Group 2", 321);
            _data.Rows.Add("Group 3", 134);
            _data.Rows.Add("Group 4", 23);
            _data.Rows.Add("Group 5", 273);
            _data.Rows.Add("Group 6", 102);

            this.Invoke(new Action(BindData));

        }

        private void BindData()
        {
            chartControl.DataSource = _data;
            chartControl.DataBind();
        }

        private void ctlChartWidget_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void chartControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var formToLoad = new Common.FormFactory.ClientList();
            CssContext.Instance.Host.Register(formToLoad);
        }
    }
}
