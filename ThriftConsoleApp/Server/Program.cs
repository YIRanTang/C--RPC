using Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Server;
using Thrift.Transport;
namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Server";
            TServerTransport transport = new TServerSocket(8800);

            var processor = new HelloWorldService.Processor(new HelloWorldServiceImpl());

            TServer server = new TThreadedServer(processor, transport);
            Console.WriteLine("监听8800端口~");

            server.Serve();
        }
    }
}
