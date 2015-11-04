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
using System.Xml;
using MYOB.CSSInterface;

namespace CS.UI.Homepage.ChartWidget
{
    public partial class ctlChartWidget : Homepagebase
    {
        private DataTable _data;

        public ctlChartWidget()
        {
            InitializeComponent();

            AddHandles();
        }

        private void AddHandles()
        {
            CSSFormEventHandler.Instance.AddHandle("ClearSky.Example", "MyTextChanged", MyTextChanged);
        }

        private void MyTextChanged(object sender, EventArgs e)
        {
            var eArgs = e as FrameworkEventArgs;
            if (eArgs != null)
            {
                string text = eArgs.PropertyBag["MyText"].ToString();
                textBox1.Text = text;
            }
        }

        private void RemoveHandles()
        {
            CSSFormEventHandler.Instance.RemoveHandle("ClearSky.Example", "MyTextChanged", MyTextChanged);
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

            Thread.Sleep(3000);

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
            var formToLoad = new Common.FormFactory.ClientList(Guid.NewGuid());
            CssContext.Instance.Host.Register(formToLoad);
        }

        public override void RestoreCustomisation(XmlElement Customisation)
        {
            if (Customisation.HasAttribute("mytext"))
            {
                string value = Customisation.Attributes["mytext"].Value;
                textBox1.Text = value;
            }
        }

        public override void SaveCustomisation(XmlTextWriter XW)
        {
            XW.WriteAttributeString("mytext", textBox1.Text);
        }
    }
}
