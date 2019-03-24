using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteConnection
{
    public partial class ProgressBar : Form
    {
        public Action Worker { get; set; }
        public ProgressBar(Action worker)
        {
            InitializeComponent();
            if (worker == null)
                throw new ArgumentNullException();

            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(p => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
