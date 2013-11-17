using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raven.Abstractions.Data;
using Raven.Client.Document;
using Raven.Client.Embedded;
using DVFS.Entities;
using Raven.Database.Server;
using DVFS.Core;
namespace DVFS_Calculator
{
    public partial class VPCalculator : Form
    {
        public EmbeddableDocumentStore documentStore;
        public CalculatorFacade calculator;
        public VPCalculator(EmbeddableDocumentStore _store)
        {
            InitializeComponent();
            documentStore = _store;
            calculator = new CalculatorFacade(_store);
        }

        private void cmdVoltage_Click(object sender, EventArgs e)
        {
            txtNewVolt.Text =
                calculator.CalculateNewVoltage(Convert.ToDouble(txtExtension.Text), Convert.ToDouble(txtVoltageMax.Text),
                                               Convert.ToDouble(txtTreshold.Text)).ToString();

        }

        private void cmdPowerC_Click(object sender, EventArgs e)
        {
            txtNewPower.Text =
               calculator.CalculateNewPower(Convert.ToDouble(txtExtension.Text), Convert.ToDouble(txtVoltageMax.Text),Convert.ToDouble(txtNewVolt.Text),
                                              Convert.ToDouble(txtPowerd.Text)).ToString();
        }
    }
}
