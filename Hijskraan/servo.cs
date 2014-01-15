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
    class arduino
    {
        private string name;
        private string COM;
        private SerialPort myCom;
        private Thread myThread;
        private int myBAUD;
        public string myLabel;
        public string sendMessage { get; private set; }
        public string toSendMessage { get; set; }

        public arduino(string ComPoort, string name, int BAUD)
        {
            myLabel = "Aan het verbinden";
            myThread = new Thread(new ThreadStart(arduinoThread));
            myCom = new SerialPort();
            this.myBAUD = BAUD;
            this.name = name;
            this.COM = ComPoort;
            myThread.Name = name;
            myThread.IsBackground = true;
            myThread.Start();
        }//Constructor

        private void arduinoThread()
        {
            if (myCom.IsOpen)
            {
                throw new Exception("COM poort is open" + Environment.NewLine + myCom.PortName + Environment.NewLine + myThread.Name);
            }
            else
            {
                myCom.PortName = COM;
                myCom.BaudRate = myBAUD;
                try
                {
                    myCom.Open();
                    myLabel = "Verbonden met " + myCom.PortName;
                }
                catch (Exception e) {throw new Exception("Verbinden mislukt" + Environment.NewLine + myCom.PortName + Environment.NewLine + myThread.Name + Environment.NewLine + e); } 
            }

            while (true)
            {
                if (sendMessage != toSendMessage)
                {
                    try
                    {
                        if (myCom.IsOpen)
                        {
                            myCom.Write("#" + toSendMessage + "%");
                            sendMessage = toSendMessage;
                            myLabel = "Verbonden met " + myCom.PortName + " - Laatst gestuurde bericht: " + sendMessage;
                        }
                    }
                    catch (Exception e) { throw new Exception("Versturen mislukt" + Environment.NewLine + myCom.PortName + Environment.NewLine + myThread.Name + Environment.NewLine + toSendMessage + Environment.NewLine + e ); }
                }
            }//While true
        }//arduino Thread

        public void Dispose()
        {
            try
            {
                myCom.Dispose();
                myThread.Abort();
                myThread = null;
            }
            catch { MessageBox.Show("ERROR dispose failure, restarting"); Application.Restart(); }
        }
    }//Class
}//Namespace
