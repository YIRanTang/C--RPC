using Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class HelloWorldServiceImpl: HelloWorldService.Iface
    {
        public string SayBayBay()
        {
            return "BayBay!~~~~~~~~~~~~~";
        }

        public string SayHello()
        {
            return "Hello World!~~~~~~~~~~~~~";
        }
    }
}
