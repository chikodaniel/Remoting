using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using remoteclass;

namespace RemoteClient
{
    class ClientApp
    {
        static void Main(string[] args)
        {
            remoteclass.xx obj = new remoteclass.xx();

            obj = (remoteclass.xx)Activator.GetObject(typeof(remoteclass.xx),
                "tcp://localhost:1234/Suma.Soap");

            IRemoteClock rc = (IRemoteClock)Activator.GetObject(
                typeof(IRemoteClock),
                "tcp://localhost:1234/RemoteClock.soap");


            Console.WriteLine("Por favor inserta el primer numero");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor inserta el segundo numero");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La Suma de " + x + "+" + y + " es: " + obj.sum(x, y));
            Console.WriteLine(rc.CurrentDate.ToString();
            Console.WriteLine("Adios");
        }
    }
}

