using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace DnaSynthMonitor
{
    internal class AbmData
    {
        private SerialPort dataPort;


        public AbmData(string p_name)
        {
            dataPort = new SerialPort(p_name);
        }

        public bool start_com()
        {
            bool isok = false;
            if (!(dataPort.IsOpen))
            {
                dataPort.BaudRate = 115200;
                dataPort.Parity = Parity.None;
                dataPort.StopBits = StopBits.One;
                dataPort.DataBits = 8;
                try
                {
                    dataPort.Open();
                }
                catch (Exception ex)
                {
                    return isok;
                }

            }
            if (dataPort.IsOpen)
            {
                isok = true;
                return isok;
            }
            else
            {
                isok = false;
                return isok;
            }
        }

    }
}
