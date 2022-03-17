using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubedaleitura
{
    internal class amigos
    public string nome;
    public string nomeDoResponsavel;
    public int numero;
    public string endereco;
    public bool jaTemUmaRevista;

    public void RegistrarPessoa()
    {

        Console.WriteLine("Qual o nome do nosso amigo?");
        nome = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Qual o nome do responsavel?");
        nomeDoResponsavel = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Qual o numero do responsavel?");
        numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qual endereço?");
        endereco = Convert.ToString(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("nosso amigo registrada com sucesso ");
        Console.ResetColor();
        Console.ReadLine();
    }
    public void Mostrar()
    {
        Console.WriteLine("Amigo: " + nome);
        Console.WriteLine("Nome do responsavel" + nomeDoResponsavel);
        Console.WriteLine("Endereço: " + endereco);
        Console.WriteLine("Numero do responsavel: " + numero);

        if (jaTemUmaRevista == true)
            Console.WriteLine("Esse nosso amigo está com uma revista!");
        else
            Console.WriteLine("Esse nosso amigo não tem nenhuma nenhuma revista");

        Console.ReadLine();
    }
}
