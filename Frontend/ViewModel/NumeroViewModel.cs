using Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frontend.ViewModel
{
    public class NumeroViewModel
    {
        private NumeroCollection _ListaNumeros = new NumeroCollection();

        public NumeroCollection ListaNumeros
        {
            get { return _ListaNumeros; }
            set { _ListaNumeros = value; }
        }

        private Numero _currentNumero;

        public Numero CurrentNumero
        {
            get { return _currentNumero; }
            set { _currentNumero = value; }
        }
    }
}
