using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prac1task1
{
    class Program
    {
        class EnviromentUserNameProvider : IUserNameProvider
        {
            string username;
            public EnviromentUserNameProvider()
            {
                this.username = Environment.UserName;
            }

            public void GetUserName()
            {
                Console.WriteLine("Hello {0}", this.username);
            }
            public override string ToString()
            {
                return this.username;
            }
        }

        class ConsoleUserNameProvider : IUserNameProvider
        {
            string username;
            public ConsoleUserNameProvider()
            {
                Console.WriteLine("Vvedit imya ");
                var name = Console.ReadLine();
                this.username = name;
            }

            public void GetUserName()
            {
                Console.WriteLine("Hello {0}", this.username);
            }

            public override string ToString()
            {
                return this.username;
            }
        }

        class ArgumentUserNameProvider : IUserNameProvider
        {
            string username;
            public ArgumentUserNameProvider(string name)
            {

                this.username = name;
            }

            public void GetUserName()
            {
                Console.WriteLine("Hello {0}", this.username);
            }
            public override string ToString()
            {
                return this.username;
            }
        }

        class FileUserNameProvider : IUserNameProvider
        {
            string username;
            public FileUserNameProvider()
            {
                string currDir = Directory.GetCurrentDirectory() + "\\UserName.txt";
                string[] lines = System.IO.File.ReadAllLines(currDir);
                this.username = lines[0];
            }

            public void GetUserName()
            {
                Console.WriteLine("Hello {0}", this.username);
            }
            public override string ToString()
            {
                return this.username;
            }
        }

        class EasyLevelUserNameProvider : IUserNameProvider
        {
            string username;
            public EasyLevelUserNameProvider()
            {

                this.username = "World";
            }

            public void GetUserName()
            {
                Console.WriteLine("Hello {0}", this.username);
            }
            public override string ToString()
            {
                return this.username;
            }
        }
        static void Main(string[] args)
        {
            //IUserNameProvider user = new EnviromentUserNameProvider();
            //IUserNameProvider user = new ConsoleUserNameProvider();
            //IUserNameProvider user = new ArgumentUserNameProvider(args[0]);
            //IUserNameProvider user = new EasyLevelUserNameProvider();
            IUserNameProvider user = new FileUserNameProvider();
            Console.WriteLine(user);
            user.GetUserName();
            Console.ReadKey();
        }
    }
}
