using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplexClient
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class Form1 : Form,ReportServices.IReportServiceCallback
    {
        public delegate void SetTextbox();

        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        public void Process(int percenTageCompleted)
        {
                textBox1.Text = percenTageCompleted.ToString() + "% completed";
        }
        


        private void btnProcessReport_Click(object sender, EventArgs e)
        {

            InstanceContext instanceContext = new InstanceContext(this);
            ReportServices.ReportServiceClient client = new ReportServices.ReportServiceClient(instanceContext);
            client.ProcessReport();
        }
    }
}
