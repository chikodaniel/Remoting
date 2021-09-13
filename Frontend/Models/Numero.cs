using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
namespace Frontend.Models
{

    public class NumeroCollection : ObservableCollection<Numero>
    {

    }

    public class Numero
    {
        private int _variableX;
        
        public int variableX
        {
            get { return _variableX; }
            set { _variableX = value; }
        }

        private int _variableY;

        public int variableY
        {
            get { return _variableY; }
            set { _variableY = value; }
        }

        private int _resultado;

        public int resultado
        {
            get { return _resultado; }
            set { _resultado = value; }
        }

        public Numero()
        {

        }

        public Numero(int VariableX, int VariableY, int Resultado)
        {
            variableX = VariableX;
            variableY = VariableY;
            resultado = Resultado;
        }   
    }
}
