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
using System.Threading;


namespace DnaSynthMonitor
{
    
    public partial class Form1 : Form
    {
        // reference https://blog.csdn.net/huang_we_i/article/details/83744275
        //public SerialPort eventPort = new SerialPort("COM1");  //define the serial port number of DNA Synthesizer
        //private SerialPort dataPort = new SerialPort("COM1");   //define the serial port number of absorptiometer

        AbmData data_in;
        int DataChart_flag = 0;
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
            ////this.textBox1.AppendText(data_in.DataProcess().ToString());
            byte[] data_plot = data_in.DataProcess();
            this.textBox1.AppendText(BitConverter.ToString(data_plot));
            if (this.ch1_show.Checked & (data_plot.Length == 41))
            {
                int d_h = data_plot[3] & 0x0F;
                int d_l = data_plot[4];
                int d_y = d_h*0xFF + d_l;
           
                this.DataChart.Series[0].Points.AddY(d_y);
                    
            }
            if (this.ch2_show.Checked && (data_plot.Length == 41))
            {
                int d_h = data_plot[5] & 0x0F;
                int d_l = data_plot[6];
                int d_y = d_h * 0xFF + d_l;

                this.DataChart.Series[1].Points.AddY(d_y);

            }


        }

        private void dataChart_plot_run()
        {
            while (DataChart_flag == 1)
            {
                byte[] data_plot = data_in.DataProcess();
                if (data_plot.Length == 41)
                {
                    
                    int d_h = data_plot[3] & 0x0F;
                    int d_l = data_plot[4];
                    int d_y = d_h * 0xFF + d_l;
                    this.DataChart.Series[0].Points.  AddY(d_y);


                    d_h = data_plot[5] & 0x0F;
                    d_l = data_plot[6];
                    d_y = d_h * (0xFF + d_l);
                    this.DataChart.Series[1].Points.AddY(d_y);

                }
                Thread.Sleep(500);

            }
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

        private void  ch1_show_CheckedChanged(object sender, EventArgs e)
        {
            
            this.DataChart.Series[0].Enabled = ch1_show.Checked;
        }

        private void ch2_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[1].Enabled = ch2_show.Checked;
        }

        private void ch3_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[2].Enabled = ch3_show.Checked;
        }

        private void ch4_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[3].Enabled = ch5_show.Checked;
        }

        private void ch5_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[4].Enabled = ch13_show.Checked;
        }

        private void ch6_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[5].Enabled = ch12_show.Checked;
        }

        private void ch7_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[6].Enabled = ch11_show.Checked;
        }

        private void ch8_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[7].Enabled = ch10_show.Checked;
        }

        private void ch9_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[8].Enabled = ch9_show.Checked;
        }

        private void ch10_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[9].Enabled = ch10_show.Checked;
        }

        private void ch11_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[10].Enabled = ch11_show.Checked;
        }

        private void ch12_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[11].Enabled = ch12_show.Checked;
        }

        private void ch13_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[12].Enabled = ch13_show.Checked;
        }

        private void ch14_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[13].Enabled = ch14_show.Checked;
        }

        private void ch15_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[14].Enabled = ch15_show.Checked;
        }

        private void ch16_show_CheckedChanged(object sender, EventArgs e)
        {
            this.DataChart.Series[15].Enabled = ch16_show.Checked;
        }
    }
}
