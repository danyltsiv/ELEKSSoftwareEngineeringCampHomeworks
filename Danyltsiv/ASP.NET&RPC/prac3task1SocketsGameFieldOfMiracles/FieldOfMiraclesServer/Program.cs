using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Timers;

namespace FieldOfMiraclesServer
{
    class Program
    {
        static void Main(string[] args)
        {
            GameFieldOfMiracles game = new GameFieldOfMiracles();
            var permission = new SocketPermission(NetworkAccess.Accept,
                   TransportType.Tcp, "localhost", 11000);

            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

            Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            sListener.Bind(ipEndPoint);
            sListener.Listen(10);
            Timer timer = new Timer(180000);
            string nick = null;

            try {
                Socket handler = sListener.Accept();

                byte[] bytes = new byte[1024];
                int bytesRec = handler.Receive(bytes);

                nick += Encoding.UTF8.GetString(bytes, 0, bytesRec);
                game.SetNickName(nick);
                string reply = game.Reset();
                byte[] msg = Encoding.UTF8.GetBytes(reply);
                handler.Send(msg);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                timer.Elapsed += (sender, argss) =>
                {
                    Socket handler = sListener.Accept();
                    string ResetReply = game.Reset();
                    byte[] rsmsg = Encoding.UTF8.GetBytes(ResetReply);
                    handler.Send(rsmsg);
                };

                timer.Start();
                timer.AutoReset = true;

                while (true)
                {
                    Socket handler = sListener.Accept();
                    string cmd = null;
                    
                    byte[] bytes = new byte[1024];
                    int bytesRec = handler.Receive(bytes);

                    cmd += Encoding.UTF8.GetString(bytes, 0, bytesRec);


                    string reply = game.ExecuteCommand(cmd, nick);
                    byte[] msg = Encoding.UTF8.GetBytes(reply);
                    handler.Send(msg);

                    if (cmd.IndexOf("<TheEnd>") > -1)
                    {
                        Console.WriteLine("Server close connection with client");
                        break;
                    }

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
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
