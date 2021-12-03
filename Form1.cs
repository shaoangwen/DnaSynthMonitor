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
        //public SerialPort eventPort = new SerialPort("COM1");  //define the serial port number of DNA Synthesizer
        //private SerialPort dataPort = new SerialPort("COM1");   //define the serial port number of absorptiometer

        AbmData data_in;
        public Form1()
        {
            InitializeComponent();
            //init_run();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            data_in = new AbmData(this.synth_port.Text);
            if (data_in.start_com())
            {
                curr_stat.Text = synth_port.Text + "串口成功打开";
            }
            else
            {
                curr_stat.Text = synth_port.Text + "串口打开失败！";
            }
            /*
            eventPort = new SerialPort(synth_port.Text);
            if (!(eventPort.IsOpen)) 
            {
                eventPort.BaudRate = 115200;
                eventPort.Parity = Parity.None;
                eventPort.StopBits = StopBits.One;
                eventPort.DataBits = 8;
                try
                {
                    eventPort.Open();
                }
                catch (Exception ex) 
                {
                    //textBox1.Text = ex.Message;
                    curr_stat.Text = synth_port.Text + "无法打开";
                }
                
                if (eventPort.IsOpen)
                {
                    curr_stat.Text = synth_port.Text + "串口成功打开";
                }
                else
                {
                    curr_stat.Text = synth_port.Text + "串口打开失败！";
                }
            }*/
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*
            int i;
            Byte[] dataBuf = new Byte[128];
            int synBufLen = this.BytesToRead;
            if (synBufLen > 0)
            {
                for (i = 0; i < synBufLen; i++)
                {
                    dataBuf[i] = (Byte)this.eventPort.ReadByte();
                }
                this.textBox1.Text = ""; 
                this.textBox1.AppendText(BitConverter.ToString(dataBuf));

            }*/

            //this.textBox1.AppendText(System.Text.Encoding.Default.GetString(data_in.ReadCom()));
            //this.textBox1.AppendText(BitConverter.ToString(data_in.ReadCom()));
            this.textBox1.AppendText(data_in.DataProcess().ToString());


        }

        private void synth_com1_CheckedChanged(object sender, EventArgs e)
        {
            if (synth_com1.Checked)
            {
                synth_port.Text = "COM1";
                synth_com2.CheckState = CheckState.Unchecked;
                synth_com3.CheckState = CheckState.Unchecked;
                synth_com4.CheckState = CheckState.Unchecked;
                synth_com5.CheckState = CheckState.Unchecked;
            }
        }

        private void synth_com2_CheckedChanged(object sender, EventArgs e)
        {
            if (synth_com2.Checked)
            {
                synth_port.Text = "COM2";
                synth_com1.CheckState = CheckState.Unchecked;
                synth_com3.CheckState = CheckState.Unchecked;
                synth_com4.CheckState = CheckState.Unchecked;
                synth_com5.CheckState = CheckState.Unchecked;
            }
        }

        private void synth_com3_CheckedChanged(object sender, EventArgs e)
        {
            if (synth_com3.Checked)
            {
                synth_port.Text = "COM3";
                synth_com1.CheckState = CheckState.Unchecked;
                synth_com2.CheckState = CheckState.Unchecked;
                synth_com4.CheckState = CheckState.Unchecked;
                synth_com5.CheckState = CheckState.Unchecked;
            }
        }
        private void synth_com4_CheckedChanged(object sender, EventArgs e)
        {
            if (synth_com4.Checked)
            {
                synth_port.Text = "COM4";
                synth_com1.CheckState = CheckState.Unchecked;
                synth_com2.CheckState = CheckState.Unchecked;
                synth_com3.CheckState = CheckState.Unchecked;
                synth_com5.CheckState = CheckState.Unchecked;
            }
        }

        private void synth_com5_CheckedChanged(object sender, EventArgs e)
        {
            if (synth_com5.Checked)
            {
                synth_port.Text = "COM5";
                synth_com1.CheckState = CheckState.Unchecked;
                synth_com2.CheckState = CheckState.Unchecked;
                synth_com3.CheckState = CheckState.Unchecked;
                synth_com4.CheckState = CheckState.Unchecked;
            }
        }

        private void abm_com1_CheckedChanged(object sender, EventArgs e)
        {
            if (abm_com1.Checked)
            {
                abm_port.Text = "COM1";
                abm_com2.CheckState= CheckState.Unchecked;
                abm_com3.CheckState= CheckState.Unchecked;
                abm_com4.CheckState= CheckState.Unchecked;
                abm_com5.CheckState= CheckState.Unchecked;
            }
        }

        private void abm_com2_CheckedChanged(object sender, EventArgs e)
        {
            if (abm_com2.Checked)
            {
                abm_port.Text = "COM2";
                abm_com1.CheckState = CheckState.Unchecked;
                abm_com3.CheckState = CheckState.Unchecked;
                abm_com4.CheckState = CheckState.Unchecked;
                abm_com5.CheckState = CheckState.Unchecked;
            }
        }

        private void abm_com3_CheckedChanged(object sender, EventArgs e)
        {
            if (abm_com3.Checked)
            {
                abm_port.Text = "COM3";
                abm_com1.CheckState = CheckState.Unchecked;
                abm_com2.CheckState = CheckState.Unchecked;
                abm_com4.CheckState = CheckState.Unchecked;
                abm_com5.CheckState = CheckState.Unchecked;
            }
        }

        private void abm_com4_CheckedChanged(object sender, EventArgs e)
        {
            if (abm_com4.Checked)
            {
                abm_port.Text = "COM4";
                abm_com1.CheckState = CheckState.Unchecked;
                abm_com2.CheckState = CheckState.Unchecked;
                abm_com3.CheckState = CheckState.Unchecked;
                abm_com5.CheckState = CheckState.Unchecked;
            }
        }

        private void abm_com5_CheckedChanged(object sender, EventArgs e)
        {
            if (abm_com5.Checked)
            {
                abm_port.Text = "COM5";
                abm_com1.CheckState = CheckState.Unchecked;
                abm_com2.CheckState = CheckState.Unchecked;
                abm_com3.CheckState = CheckState.Unchecked;
                abm_com4.CheckState = CheckState.Unchecked;
            }
        }
    }
}
