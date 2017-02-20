using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Timers;

namespace FieldOfMiraclesClient
{
    class Program
    {
        static void SendCommand(int port)
        {
            byte[] bytes = new byte[1024];

            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);

            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            sender.Connect(ipEndPoint);

            Console.Write("Type your command: ");
            string command = Console.ReadLine();

            byte[] cmd = Encoding.UTF8.GetBytes(command);

            int bytesSent = sender.Send(cmd);

            int bytesRec = sender.Receive(bytes);

            Console.WriteLine(Encoding.UTF8.GetString(bytes, 0, bytesRec));

            if (command.IndexOf("<TheEnd>") == -1)
                SendCommand(port);

            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }

        static void SendNickFromSocket(int port)
        {
            byte[] bytes = new byte[1024];

            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);

            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            sender.Connect(ipEndPoint);

            Console.Write("Type your nickname: ");
            string nick = Console.ReadLine();
            
            byte[] nck = Encoding.UTF8.GetBytes(nick);
            //
            int bytesSent = sender.Send(nck);

            int bytesRec = sender.Receive(bytes);

            Console.WriteLine(Encoding.UTF8.GetString(bytes, 0, bytesRec));

            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }

        static void CheckResponse(int port)
        {
            byte[] bytes = new byte[1024];

            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);

            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            sender.Connect(ipEndPoint);

            int bytesRec = sender.Receive(bytes);

            Console.WriteLine(Encoding.UTF8.GetString(bytes, 0, bytesRec));

            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }
        static void Main(string[] args)
        {
            try
            { 
                SendNickFromSocket(11000);
                SendCommand(11000);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
