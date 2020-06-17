using System;

namespace Ingresso19
{
    class Program
    {
        static void Main(string[] args)
        {
            Vip bilhete = new Vip();

            System.Console.WriteLine("Deseja se tornar Vip? se sim digite : 'True', se nao digite: 'False' ");
            bilhete.beVip = bool.Parse(Console.ReadLine());

            if(bilhete.beVip == true){
                System.Console.WriteLine("voce agora é um Vip");
            }else{ 
                System.Console.WriteLine("Você não se tornou um vip");
            }

            bilhete.ImprimirValor();
            bilhete.IngressoVip();
            
        }
    }
}
