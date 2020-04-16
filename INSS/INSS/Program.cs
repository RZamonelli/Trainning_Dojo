using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aplicacao objAplicacao = new Aplicacao();
            objAplicacao.Inicializar();
            objAplicacao.Calcular();
            objAplicacao.Finalizar();
        }
    }
}