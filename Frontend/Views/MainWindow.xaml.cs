using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using remoteclass;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;

namespace Frontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        remoteclass.xx obj = new remoteclass.xx();
        public void conexion()
        {
            obj = (remoteclass.xx)Activator.GetObject(typeof(remoteclass.xx),
                    "tcp://localhost:1234/Suma.Soap");
        }


        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void CalcularClick(object sender, RoutedEventArgs e)
        {
            conexion();
            int x = Int32.Parse(VariableX.Text);
            int y = Int32.Parse(VariableY.Text);
            ResultadoSuma.Text =(obj.Operacion(x,y).ToString());
        }
        private void CalcularTodoClick(object sender, RoutedEventArgs e)
        {
            conexion();
            int x = Int32.Parse(VariableX.Text);
            int y = Int32.Parse(VariableY.Text);
            var resultset = obj.Operaciones(x, y);
            ResultadoSuma.Text = resultset.Item1.ToString();
            ResultadoResta.Text = resultset.Item2.ToString();
            ResultadoMultiplicacion.Text = resultset.Item3.ToString();
            ResultadoDivision.Text = resultset.Item4.ToString();
        }



        
    }


}
