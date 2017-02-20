using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order;
using Grpc.Core;

namespace Kitchen
{
    class WaiterImpl : Waiter.IWaiter
    {
        public Task<OrderReply> informOrder(OrderRequest request, ServerCallContext context)
        {
            string[] separators = { ", "," ,", "," };

            List<string> reqList = new List<string>(request.Order.Split(separators, StringSplitOptions.RemoveEmptyEntries));

            var availableProductsList = reqList.Where(
                g=>AvailableProducts.products.Contains(g)
                ).Select(g=>g).ToList();

            string availableProducts = String.Join(", ",availableProductsList.ToArray());

            if (String.IsNullOrEmpty(availableProducts)) availableProducts = "These products are not available";

            return Task.FromResult(new OrderReply { Message = "Products available: " + availableProducts });
        }
    }
    class Program
    {
        const int Port = 50051;

        static void Main(string[] args)
        {
            Grpc.Core.Server server = new Grpc.Core.Server
            {
                Services = { Waiter.BindService(new WaiterImpl()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("Kitchen server listening on port " + Port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}
