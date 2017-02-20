using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using MafiaClassLibrary.Entities;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace MafiaServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketServer();
        }

        static void TicketServer()
        {

            ArquiteturaBaseadaEmObjetos();
            System.Console.WriteLine("Serv is on...");
            System.Console.WriteLine("Starting clients...");
            startClients();
            System.Console.WriteLine("Clients Started.");
            System.Console.WriteLine("Press ENTER to quit");
            System.Console.ReadLine();

        }

        private static void startClients()
        {
            string pathClient = @"..\..\..\MafiaClient\bin\Debug\MafiaClient.exe";
            Process.Start(pathClient);
            Process.Start(pathClient);
            Process.Start(pathClient);
        }

        private static void ArquiteturaBaseadaEmObjetos()
        {
            TcpChannel tcpChannel = new TcpChannel(9998);
            ChannelServices.RegisterChannel(tcpChannel, false);

            Type commonInterfaceType = typeof(Mafia);

            RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType,
            "Mafia", WellKnownObjectMode.Singleton);
        }
    }
}
