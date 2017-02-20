using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PortsChecker
{
    partial class PortCheck : ServiceBase
    {
        private string pathAP = @"D:\activePorts.txt";
        private string pathAPS = @"D:\activePortsSummary.txt";
        private Timer timerAP = new Timer(3000);
        private Timer timerAPS = new Timer(6000);
        public PortCheck()
        {
            InitializeComponent();
        }

        public TcpConnectionInformation[] GetActivePorts()
        {
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] connections = properties.GetActiveTcpConnections();
            return connections;
        }

        public void PortsInformationToFile()
        {
            var connections = GetActivePorts();
            string activePorts = "";
            foreach (TcpConnectionInformation c in connections)
            {
                activePorts+=String.Format("{0} <==> {1}{2}",
                    c.LocalEndPoint.ToString(),
                    c.RemoteEndPoint.ToString(),Environment.NewLine);
            }

            File.AppendAllText(pathAP, activePorts);
        }

        public void PortsInfSummaryToFile()
        {
            List<string> ports = new List<string>(File.ReadAllLines(pathAP));
            string activePortsDistText = "";
            var distinctPorts = ports.Distinct().Select(g=>g).ToList();
            foreach(var port in distinctPorts)
            {
                activePortsDistText += String.Format("{0}{1}", port, Environment.NewLine);
            }
            File.WriteAllText(pathAPS, activePortsDistText);                        
        }

        public void Test()
        {
            this.OnStart(new string[0]);
        }

        protected override void OnStart(string[] args)
        {
            //PortsInformationToFile();
            timerAP.Elapsed += (sender, argss) =>
            {
                PortsInformationToFile();
            };

            timerAP.Start();
            timerAP.AutoReset = true;


            timerAPS.Elapsed += (sender, argss) =>
            {
                PortsInfSummaryToFile();
            };

            timerAPS.Start();
            timerAPS.AutoReset = true;
        }

        protected override void OnStop()
        {
        }
    }
}
