using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

namespace Hijskraan
{
    public partial class Form1 : Form
    {
        arduino arduinoLinks;
        arduino arduinoRechts;
        bool openneer = false;
        public Form1()
        {
            InitializeComponent();
            FillSerialPortSelectionBoxWithAvailablePorts();
        }

        private void achteruitButton_Click(object sender, EventArgs e)
        {
            arduinoLinks.toSendMessage = "BACK";
            arduinoRechts.toSendMessage = "FWD";

        }

        private void vooruitButton_Click(object sender, EventArgs e)
        {
            arduinoLinks.toSendMessage = "FWD";
            arduinoRechts.toSendMessage = "BACK";
        }

        private void openneerButton_Click(object sender, EventArgs e)
        {
            Thread ThereAndBackAgainThread = new Thread(new ThreadStart(ThereAndBackAgain));
            openneer = !openneer;
            ThereAndBackAgainThread.Start();
        }

        private void ThereAndBackAgain()
        {
            while (openneer)
            {
                arduinoLinks.toSendMessage = "FWD";
                arduinoRechts.toSendMessage = "BACK";
                Thread.Sleep(Convert.ToInt16(textBox1.Text));
                arduinoLinks.toSendMessage = "BACK";
                arduinoRechts.toSendMessage = "FWD";
                Thread.Sleep(Convert.ToInt16(textBox1.Text));
            }
            arduinoLinks.toSendMessage = "STOP";
            arduinoRechts.toSendMessage = "STOP";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            arduinoLinks.toSendMessage = "STOP";
            arduinoRechts.toSendMessage = "STOP";
        }

        private void FillSerialPortSelectionBoxWithAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            ComLinksBox.Items.Clear();
            ComRechtsBox.Items.Clear();
            foreach (String port in ports)
            {
                ComLinksBox.Items.Add(port);
                ComRechtsBox.Items.Add(port);

            }
        }



        private void ConnectLinks_Click(object sender, EventArgs e)
        {
            if (arduinoLinks == null)
            {
                arduinoLinks = new arduino(ComLinksBox.Text, "Arduino links", 9600);
                connectLinksButton.Text = "Disconnect";
                ComLinksBox.Enabled = false;
                ComRechtsBox.Items.Remove(ComLinksBox.Text);
                ComLinksBox.Items.Remove(ComLinksBox.Text);
                UpdateLabels();
            }
            else
            {
                arduinoLinks.Dispose();
                arduinoLinks = null;
                connectLinksButton.Enabled = true;
                connectLinksButton.Text = "Connect";
                FillSerialPortSelectionBoxWithAvailablePorts();
                UpdateLabels();
            }
        }
        
        private void ConnectRechts_Click(object sender, EventArgs e)
        {
            if (arduinoRechts == null)
            {
                arduinoRechts = new arduino(ComRechtsBox.Text, "Arduino Rechts", 9600);
                ConnectRechts.Text = "Disconnect";
                ComRechtsBox.Enabled = false;
                ComRechtsBox.Items.Remove(ComRechtsBox.Text);
                ComLinksBox.Items.Remove(ComRechtsBox.Text);
                UpdateLabels();
            }
            else
            {
                arduinoRechts.Dispose();
                arduinoRechts = null;
                ConnectRechts.Text = "Connect";
                ConnectRechts.Enabled = true;
                FillSerialPortSelectionBoxWithAvailablePorts();
                UpdateLabels();
            }
        }

        private void UpdateLabels()
        {
            //throw new NotImplementedException();
        }

        private void labelTimer_Tick(object sender, EventArgs e)
        {
            if (arduinoLinks != null && arduinoRechts != null)
            {
                statusLabelLinks.Text = arduinoLinks.myLabel;
                statusLabelRechts.Text = arduinoRechts.myLabel;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arduinoLinks.Dispose();
            arduinoRechts.Dispose();
            Application.Restart();
        }

        private void rescanButton_Click(object sender, EventArgs e)
        {
            FillSerialPortSelectionBoxWithAvailablePorts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        
    }
}
