using Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Protocol;
using Thrift.Transport;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Client";
            using (TTransport transport = new TSocket("localhost", 8800))

            using (TProtocol protocol = new TBinaryProtocol(transport))

            using (var clientUser = new HelloWorldService.Client(protocol))

            {

                transport.Open();

                Console.WriteLine(clientUser.SayHello());
                Console.WriteLine(clientUser.SayBayBay());

            }

            Console.ReadKey();
        }
    }
}
