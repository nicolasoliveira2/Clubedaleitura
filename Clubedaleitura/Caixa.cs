using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubedaleitura
{
   
    
        public int numerodaCaixa;
        public string cordaCaixa;
        public string entiquetadaCaixa;



    public void RegistrarCaixa()
    {

        Console.WriteLine("Qual o numero da caixa?");
        numerodaCaixa = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qual a cor da caixa?");
        cordaCaixa = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Qual a entiqueta da caixa?");
        entiquetadaCaixa = Convert.ToString(Console.ReadLine());
    }
    public void Mostrar()
    {
        Console.WriteLine("Numero da caixa: " + numerodaCaixa);
        Console.WriteLine("Cor da caixa: " + cordaCaixa);
        Console.WriteLine("Entiqueta da caixa: " + entiquetadaCaixa);

        Console.ReadLine();
    }

}