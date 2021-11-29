using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace DnaSynthMonitor
{
    
    public partial class Form1 : Form
    {
        // reference https://blog.csdn.net/huang_we_i/article/details/83744275
        private SerialPort eventPort = new SerialPort("COM3");  //define the serial port number of DNA Synthesizer
        private SerialPort dataPort = new SerialPort("COM5");   //define the serial port number of absorptiometer
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!(eventPort.IsOpen)) 
            {
                eventPort.BaudRate = 115200;
                eventPort.Parity = Parity.None;
                eventPort.StopBits = StopBits.One;
                eventPort.DataBits = 8;
                eventPort.Open();
                if (eventPort.IsOpen)
                {
                    textBox1.Text = "COM3串口成功打开";
                }
                else
                {
                    textBox1.Text = "COM3打开失败！";
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (eventPort.IsOpen)
            {
                eventPort.Write("Hello Dr. Wen ~ \n");
            }

        }
    }
}
