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

        public byte[] ReadCom()
        {
            byte[] data_byte = new byte[1];
            string frame_tail = "VOID";
            if (dataPort.IsOpen)
            {
                if (dataPort.BytesToRead != 0)
                {
                    data_byte[0] = (byte)dataPort.ReadByte();
                    while (data_byte[0] != (byte)0xDD)
                    {
                      data_byte[0] = (byte)dataPort.ReadByte();
                    }

                    frame_tail = dataPort.ReadTo("dEND");
                }


            }
            data_byte = System.Text.Encoding.Default.GetBytes(frame_tail);
            return data_byte;
        }
        public byte[] DataProcess()
        {
            byte[] data_byte = ReadCom();
            if (data_byte.Length == 41)
            {
                return data_byte;
            }
            return new byte[1];
        }



        public int CycMonit() 
        {
            byte[] data_byte = new byte[38];
            if (dataPort.IsOpen)
            {
                if (dataPort.BytesToRead != 0)
                {
                    data_byte[0] = (byte)dataPort.ReadByte();
                    while (data_byte[0] != (byte)0x53)
                    {
                        data_byte[0] = (byte)dataPort.ReadByte();
                    }
                    dataPort.Read(data_byte, 1, 37);
                    if ((data_byte[34] == (byte)0x34) && (data_byte[35] == (byte)0x37))
                    {
                        return 1;
                        
                    }
                    else if((data_byte[34] == (byte)0x32) && (data_byte[35] == (byte)0x31))
                    {
                        return 2;
                    }
                }
                return 0;
            }
            return -1;
        }
        
/*
        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }*/


    }
}
