using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Specialized;

namespace PacapAnalytics
{
   /* class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"packet.pcap";
            string outFile = @"transfer.log";
            using (StreamWriter write = File.AppendText(outFile))
            {
                using (PacapReader reader = new PacapReader(fileName))
                {
                    List<PacapData> dataList = reader.Parse();
                    foreach (PacapData data in dataList)
                    {
                        if (data.ProtocolType == ProtocolType.TCP)
                        {
                            string msg = data.ToString(Encoding.UTF8); 
                           // if (msg.IndexOf("N: TransferV4", StringComparison.OrdinalIgnoreCase) >= 0)
                            { 
                                write.WriteLine(msg);
                            }
                        }
                    }
                }
            }
        }
    }*/
}
