using System;
using Order;
using Grpc.Core;

namespace WaiterClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = Waiter.NewClient(channel);
            Console.WriteLine("Type stop if you want to stop your request cycle");
            while (true)
            {
                Console.WriteLine("Type order products to check it available");
                String order = Console.ReadLine();
                if (order == "stop") break;

                var reply = client.informOrder(new OrderRequest { Order = order });
                Console.WriteLine(reply.Message);
            }

            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

