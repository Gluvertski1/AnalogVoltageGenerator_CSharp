using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.DAQmx;

namespace AnalogVoltageOutput
{
    public partial class AnalogVoltageController : Form
    {
        public AnalogVoltageController()
        {
            InitializeComponent();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            
                double value = hScrollBar1.Value;
                value = value / 100;
                analogVoltageDisp.Text = value.ToString();
                update();
                
        }

        private void AnalogVoltageController_FormClosed(object sender, FormClosedEventArgs e)
        {
            hScrollBar1.Value = 0;
            analogVoltageDisp.Text = hScrollBar1.Value.ToString();
            update();
        }
        private void update()
        {
            try
            {
            using(Task analogtask = new Task())
                {
                    analogtask.AOChannels.CreateVoltageChannel("Dev1/ao0","aoChannel",-10,10, AOVoltageUnits.Volts);
                    AnalogSingleChannelWriter writer = new AnalogSingleChannelWriter(analogtask.Stream);
                    writer.WriteSingleSample(true,Convert.ToDouble(analogVoltageDisp.Text));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}