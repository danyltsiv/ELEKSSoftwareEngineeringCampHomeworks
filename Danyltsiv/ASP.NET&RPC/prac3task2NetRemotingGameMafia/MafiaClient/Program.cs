using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using MafiaClassLibrary.Contracts;
using System.IO;
using System.Threading;
using System.Timers;

namespace MafiaClient
{
    class Program
    {
        public static Object lockObj;
        public static string screen = "";
        public static IMafia remoteObject;
        public static int id;

        static void Main(string[] args)
        {
            lockObj = new object();
            ArchitectureBasedOnObject();
        }


        private static void ArchitectureBasedOnObject()
        {
            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel, false);

            Type requiredType = typeof(IMafia);

            remoteObject = (IMafia)Activator.GetObject(requiredType,
            "tcp://localhost:9998/Mafia");
            Console.WriteLine("Type your nickname:");
            string nickname = Console.ReadLine();
            id = remoteObject.RegisterPlayer(nickname);

            Console.WriteLine("Hello {0}!\nPlease wait for other players...", nickname);

            while (remoteObject.GetCountOfPlayers() != 3)
            {
            }
            remoteObject.NewRound();

            setTimers();

            new Thread(refreshScreen).Start();
            string message = "say connected!";

            while (true)
            {
                lock (lockObj)
                {
                    remoteObject.ExecuteCommand(id,message);
                    screen = remoteObject.GetScreen(id);
                    Console.WriteLine(screen);
                }

                message = System.Console.ReadLine();
                Console.Clear();
            }
        }

        static void refreshScreen()
        {
            while (true)
            {
                lock (lockObj)
                {
                    if (!screen.Equals(remoteObject.GetScreen(id)))
                    {
                        screen = remoteObject.GetScreen(id);
                        Console.Clear();
                        Console.WriteLine(screen);
                    }
                }
                Thread.Sleep(500);
            }
        }

        static void setTimers()
        {
            System.Timers.Timer timeSwitchTimer = new System.Timers.Timer(60000);
            timeSwitchTimer.Elapsed += (sender, args) =>
            {
                remoteObject.ToggleTime();
            };
            timeSwitchTimer.Start();
            timeSwitchTimer.AutoReset = true;


            System.Timers.Timer newRndTimer = new System.Timers.Timer(15*60000);
            newRndTimer.Elapsed += (sender, args) =>
            {
                remoteObject.NewRound();
            };
            newRndTimer.Start();
            newRndTimer.AutoReset = true;
        }
    }
}
