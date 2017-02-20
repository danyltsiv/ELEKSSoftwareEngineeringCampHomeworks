using System;
using WaiterServiceProto;
using Grpc.Core;

namespace WaiterClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = WaiterService.NewClient(channel);
            Console.WriteLine("\nCommands available:\nstop\ncheckProducts\naddOrder id products\n"+
                "closeOrder id\ncancelOrder id\nshowActiveOrders\nshowClosedOrders\n");
            while (true)
            {
                Console.WriteLine("Type command: ");
                String command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }
                else if (command == "checkProducts")
                {
                    var reply = client.checkProducts(new Empty());
                    var iterator = reply.Values.GetEnumerator();
                    string productsMsg = "";
                    do
                    {
                        var prd = iterator.Current;
                        if (prd != null)
                        {
                            productsMsg += String.Format("id:{0} name:{1} description:{2} \n", prd.Id,
                                prd.Name, prd.Description);
                        }
                    } while (iterator.MoveNext());
                    Console.WriteLine(productsMsg);
                }
                else if(command.Contains("addOrder") && command.Split(' ').Length == 3)
                {
                    var splitedCommand = command.Split(' ');
                    var productsOrdered = splitedCommand[2].Split(',');
                    productArr productsOrderedRequest = new productArr();
                    foreach (var prod in productsOrdered)
                    {
                        Product product = new Product();
                        product.Name = prod;
                        productsOrderedRequest.Values.Add(product);
                    }
                    Order order = new Order();
                    order.Products = productsOrderedRequest;
                    order.Table = int.Parse(splitedCommand[1]);
                    Bool result = client.addOrder(order);

                    if (result.Value)
                    {
                        Console.WriteLine("Order added succesfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("You typed some not available products!\n");
                    }
                }
                else if (command.Contains("cancelOrder") && command.Split(' ').Length == 2)
                {
                    var splitedCommand = command.Split(' ');
                    int CancelId = int.Parse(splitedCommand[1]);
                    Id RequestId = new Id();
                    RequestId.Value = CancelId;
                    Bool result = client.cancelOrder(RequestId);

                    if (result.Value)
                    {
                        Console.WriteLine("Order canceled succesfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("Order does not exist!\n");
                    }
                }
                else if (command.Contains("closeOrder") && command.Split(' ').Length == 2)
                {
                    var splitedCommand = command.Split(' ');
                    int CloseId = int.Parse(splitedCommand[1]);
                    Id RequestId = new Id();
                    RequestId.Value = CloseId;
                    Bool result = client.closeOrder(RequestId);

                    if (result.Value)
                    {
                        Console.WriteLine("Order closed succesfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("Order does not exist!\n");
                    }
                }
                else if (command == "showActiveOrders")
                {
                    var reply = client.getActiveOrders(new Empty());
                    var iterator = reply.Values.GetEnumerator();
                    string activeOrdersMsg = "";
                    do
                    {
                        var OrderIt = iterator.Current;
                        if (OrderIt != null)
                        {
                            var ProductsIt = OrderIt.Products.Values.GetEnumerator();
                            string productsMsg = "";

                            do
                            {
                                var prd = ProductsIt.Current;
                                if (prd != null)
                                {
                                    productsMsg += prd.Name + ",";
                                }
                            } while (ProductsIt.MoveNext());

                            activeOrdersMsg += String.Format("id:{0} table:{1} products:{2} \n", OrderIt.Id,
                                OrderIt.Table, productsMsg);
                        }
                    } while (iterator.MoveNext());
                    
                    if (String.IsNullOrEmpty(activeOrdersMsg))
                        Console.WriteLine("No active orders yet\n");
                            else Console.WriteLine(activeOrdersMsg);
                }
                else if (command == "showClosedOrders")
                {
                    var reply = client.getClosedOrders(new Empty());
                    var iterator = reply.Values.GetEnumerator();
                    string closedOrdersMsg = "";
                    do
                    {
                        var OrderIt = iterator.Current;
                        if (OrderIt != null)
                        {
                            var ProductsIt = OrderIt.Products.Values.GetEnumerator();
                            string productsMsg = "";

                            do
                            {
                                var prd = ProductsIt.Current;
                                if (prd != null)
                                {
                                    productsMsg += prd.Name + ",";
                                }
                            } while (ProductsIt.MoveNext());

                            closedOrdersMsg += String.Format("id:{0} table:{1} products:{2} \n", OrderIt.Id,
                                OrderIt.Table, productsMsg);
                        }
                    } while (iterator.MoveNext());

                    if (String.IsNullOrEmpty(closedOrdersMsg))
                        Console.WriteLine("No closed orders yet\n");
                            else Console.WriteLine(closedOrdersMsg);
                }
                else
                {
                    Console.WriteLine("Wrong command\n");
                }
            }

            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

