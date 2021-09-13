using System;
using System.Collections.Generic;
using System.Text;

namespace remoteclass
{
    public class xx : MarshalByRefObject
    {
        public Tuple<int,int,int,int> Operaciones(int a, int b)
        {
            var tuple = new Tuple<int, int, int, int>(a + b, a - b, a * b, a / b);
            return tuple;
        }

        public int Operacion(int a, int b)
        {
            return a + b;
        }

        public int tabla (int a)
        {
            for (int i = 0; i<9, i++)
            {

            }
        }
       
    }

    public interface IRemoteClock
    {
        DateTime CurrentDate
        {
            get;
        }
    }
}