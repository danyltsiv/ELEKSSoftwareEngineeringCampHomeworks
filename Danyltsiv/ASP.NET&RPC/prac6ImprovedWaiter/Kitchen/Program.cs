using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiterServiceProto;
using Grpc.Core;

namespace Kitchen
{
    class WaiterServiceImpl : WaiterService.IWaiterService
    {
        public Storage storage = new Storage();
        public Task<Bool> addOrder(Order request, ServerCallContext context)
        {
            Bool result = new Bool();
            result.Value = false;

            var availableProducts = storage.products.Values.Select(g => g.Name);
            var orderedProducts = request.Products.Values.Select(g => g.Name);
            var notAvailableOrderedProducts = orderedProducts.Where(g => !availableProducts.Contains(g))
                .Select(g => g).ToList();

            if (notAvailableOrderedProducts.Count == 0)
            {
                int id = 0;
                if (storage.activeOrders.Values.Count != 0)
                    id = storage.activeOrders.Values.Select(g => g.Id).Max() + 1;
                request.Id = id;
                storage.activeOrders.Values.Add(request);
                result.Value = true;
                return Task.FromResult(result);
            };
                return Task.FromResult(result);
        }

        public Task<Bool> cancelOrder(Id request, ServerCallContext context)
        {
            Order orderToCancel = storage.activeOrders.Values.FirstOrDefault(g => request.Value == g.Id);
            Bool result = new Bool();
            result.Value = false;
            if(orderToCancel != null)
            {
                storage.activeOrders.Values.Remove(orderToCancel);
                result.Value = true;
                return Task.FromResult(result);
            }

            return Task.FromResult(result);
        }

        public Task<productArr> checkProducts(Empty request, ServerCallContext context)
        {
            return Task.FromResult(storage.products);
        }

        public Task<Bool> closeOrder(Id request, ServerCallContext context)
        {
            Order orderToClose = storage.activeOrders.Values.FirstOrDefault(g => request.Value == g.Id);
            Bool result = new Bool();
            result.Value = false;

            if (orderToClose != null)
            {
                Id id = new Id();
                id.Value = orderToClose.Id;
                cancelOrder(id, context);

                int newId = 0;
                if (storage.closedOrders.Values.Count != 0)
                    newId = storage.closedOrders.Values.Select(g => g.Id).Max() + 1;
                orderToClose.Id = newId;

                storage.closedOrders.Values.Add(orderToClose);
                result.Value = true;
                return Task.FromResult(result);
            }

            return Task.FromResult(result);
        }

        public Task<orderArr> getActiveOrders(Empty request, ServerCallContext context)
        {
            return Task.FromResult(storage.activeOrders);
        }

        public Task<orderArr> getClosedOrders(Empty request, ServerCallContext context)
        {
            return Task.FromResult(storage.closedOrders);
        }
    }
    class Program
    {
        const int Port = 50051;

        static void Main(string[] args)
        {
            Grpc.Core.Server server = new Grpc.Core.Server
            {
                Services = { WaiterService.BindService(new WaiterServiceImpl()) },
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
