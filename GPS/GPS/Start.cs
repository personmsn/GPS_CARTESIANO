using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RULES;
using BE;

namespace GPS
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nosso objetivo é mostrar quais são os amigos mais próximos um dos outros.");
            Console.WriteLine("Temos uma lista de 7 amigos, com posições definidas num plano cartesiano.");
            Console.WriteLine("Para cada amigo, iremos mostrar a posição dos outros conforme a proximidade.");
            Console.Write("\nPressione qualquer tecla para continuar ... \n");
            Console.ReadKey(true);

            List<Localizacao> lst = RULES.Regras.Main();
            Show(lst);

            Console.ReadKey(true);
        }


        static void Show(List<Localizacao> lstLocal)
        {
            Console.WriteLine("");
            
            foreach (var amigo in lstLocal)
            {
                Console.WriteLine("Amigos Mais Próximos de " + amigo.NomeAmigo + ":");
                int i = 0;
                foreach (var proximos in amigo.lstAmigos)
                {
                    i += 1;
                    Console.WriteLine("Amigo nº " + i + " " + proximos.AmigoNome + " com a distância de " + proximos.AmigoP);
                }

                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("FIM");
            Console.WriteLine("******");

        }


    }
}
