using System;  
using System.Collections.Generic;  
using System.Text;  
using System.Runtime.Remoting;  
using System.Runtime.Remoting.Channels;  
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;
using remoteclass;

namespace remoteserver
{
    
    class RemoteCLockClass: MarshalByRefObject, IRemoteClock
    {
        public DateTime CurrentDate
        {
            get { return DateTime.Now; }
        }
    }

    class ServidorApp
    {
        static void Main(String[] args)
        {
            TcpChannel canal = new TcpChannel(1234);
            ChannelServices.RegisterChannel(canal);

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(remoteclass.xx),
                "Suma.soap",
                WellKnownObjectMode.Singleton);

            Console.WriteLine("Servidor Iniciado");
            Console.ReadLine();
        }
    }
}